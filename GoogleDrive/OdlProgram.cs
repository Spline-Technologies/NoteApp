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
	internal class OdlProgram
	{
		private const string PathToServiceAccountKeyFile =
			@"C:\Users\Artem\RiderProjects\NoteApp\noteapp-359513-256e4981656e.json";
		private const string ServiceAccountEmail = "testname@sharp-quest-359006.iam.gserviceaccount.com";
		private const string UploadFileName =  @"C:\Users\Artem\RiderProjects\NoteApp\NoteApp.notes";
		private const string DirectoryId = "1DFPage9cKRuuJ-7MkZOEc2VfqoAn3876";

		private static DriveService _service;
		
		private static void SignUp()
		{
			// Load the Service account credentials and define the scope of its access.
			var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile)
				.CreateScoped(DriveService.ScopeConstants.Drive);

			// Create the  Drive service.
			_service = new DriveService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential
			});
		}

		private static void UploadFile()
		{
			// Upload file Metadata
			var fileMetadata = new Google.Apis.Drive.v3.Data.File()
			{
				//todo в имя файла пихать user id
				Name = "NoteApp.notes",
				Parents = new List<string>() { DirectoryId }
			};
			
			string uploadedFileId;
// Create a new file on Google Drive
			using (var fsSource = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read))
			{
				// Create a new file, with metadata and stream.
				var request = _service.Files.Create(fileMetadata, fsSource, "text/plain");
				request.Fields = "*";
				//var results = await request.UploadAsync(CancellationToken.None);
				var results =  request.Upload();

				if (results.Status == UploadStatus.Failed)
				{
					Console.WriteLine($"Error uploading file: {results.Exception.Message}");
				}

				// the file id of the new file we created
				uploadedFileId = request.ResponseBody?.Id;
			}
		}
		
		public static void OldMain(string[] args)
		{
			SignUp();


			UploadFile();


			/*// Let's change the files name.
// Note: not all fields are writeable watch out, you cant just send uploadedFile back.
			var updateFileBody = new Google.Apis.Drive.v3.Data.File()
			{
				Name = "update.txt"
			};

			// Let's add some text to our file.
			File.AppendAllText(UploadFileName, "2");

			// Then upload the file again with a new name and new data.
			using (var uploadStream = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read))
			{
				// Update the file id, with new metadata and stream.
				var updateRequest = _service.Files.Update(fileMetadata, uploadedFileId, uploadStream, "text/plain");
				var result = await updateRequest.UploadAsync(CancellationToken.None);

				if (result.Status == UploadStatus.Failed)
				{
					Console.WriteLine($"Error uploading file: {result.Exception.Message}");
				}
			}*/
		}
	}
}