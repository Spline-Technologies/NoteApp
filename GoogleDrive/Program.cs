using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Upload;

namespace GoogleDrive
{
	internal class Program
	{
		private const string PathToServiceAccountKeyFile =
			@"C:\Users\Artem\Downloads\sharp-quest-359006-5133f2f8765d.json";
		private const string ServiceAccountEmail = "testname@sharp-quest-359006.iam.gserviceaccount.com";
		private const string UploadFileName =  "../../../NoteApp.notes";
		private const string DirectoryId = "1Prp3UGsUjyALsay2TcuNsgd8pH3UUALG";

		public static async Task Main(string[] args)
		{
			// Load the Service account credentials and define the scope of its access.
			var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile)
				.CreateScoped(DriveService.ScopeConstants.Drive);

			// Create the  Drive service.
			var service = new DriveService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential
			});

			// Upload file Metadata
			var fileMetadata = new Google.Apis.Drive.v3.Data.File()
			{
				Name = "Test hello uploaded.txt",
				Parents = new List<string>() { DirectoryId }
			};

			string uploadedFileId;
// Create a new file on Google Drive
			using (var fsSource = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read))
			{
				// Create a new file, with metadata and stream.
				var request = service.Files.Create(fileMetadata, fsSource, "text/plain");
				request.Fields = "*";
				var results = await request.UploadAsync(CancellationToken.None);

				if (results.Status == UploadStatus.Failed)
				{
					Console.WriteLine($"Error uploading file: {results.Exception.Message}");
				}

				// the file id of the new file we created
				uploadedFileId = request.ResponseBody?.Id;
			}

			// Let's change the files name.
// Note: not all fields are writeable watch out, you cant just send uploadedFile back.
			var updateFileBody = new Google.Apis.Drive.v3.Data.File()
			{
				Name = "update.txt"
			};

			// Let's add some text to our file.
			File.WriteAllText(UploadFileName, "Text changed in file.");

			// Then upload the file again with a new name and new data.
			using (var uploadStream = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read))
			{
				// Update the file id, with new metadata and stream.
				var updateRequest = service.Files.Update(updateFileBody, uploadedFileId, uploadStream, "text/plain");
				var result = await updateRequest.UploadAsync(CancellationToken.None);

				if (result.Status == UploadStatus.Failed)
				{
					Console.WriteLine($"Error uploading file: {result.Exception.Message}");
				}
			}
		}
	}
}