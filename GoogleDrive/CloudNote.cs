using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Upload;
using File = Google.Apis.Drive.v3.Data.File;

namespace GoogleDrive
{
	public class CloudNote
	{
		//todo поменять пути к файлам
		private const string PathToServiceAccountKeyFile =
			@"C:\Users\Artem\RiderProjects\NoteApp\noteapp-359513-256e4981656e.json";

		private const string ServiceAccountEmail = "testname@sharp-quest-359006.iam.gserviceaccount.com";
		private const string UploadFileName = @"C:\Users\Artem\RiderProjects\NoteApp\NoteApp.notes";
		private const string DirectoryId = "1DFPage9cKRuuJ-7MkZOEc2VfqoAn3876";

		private static DriveService _driveService;
		private string _fileId;

		private void SignIn()
		{
			var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile)
				.CreateScoped(DriveService.ScopeConstants.Drive);

			_driveService = new DriveService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential
			});
		}

		public void Rename(string newName)
		{
			var fileMetadata = new Google.Apis.Drive.v3.Data.File()
			{
				//todo в имя файла пихать user id
				Name = newName + ".notes",
			};

			using var fileStream = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read);
			var request = _driveService.Files.Update(fileMetadata, _fileId, fileStream, "text/plain");
			var result = request.Upload();

			if (result.Status == UploadStatus.Failed)
				throw new Exception();
		}

		private void Rewrite()
		{
		}

		public void Upload()
		{
			// Upload file Metadata
			var fileMetadata = new Google.Apis.Drive.v3.Data.File()
			{
				//todo в имя файла пихать user id
				Name = "NoteApp.notes",
				Parents = new List<string>() { DirectoryId }
			};

			// Create a new file on Google Drive
			using var fileStream = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read);
			// Create a new file, with metadata and stream.
			var request = _driveService.Files.Create(fileMetadata, fileStream, "text/plain");
			request.Fields = "*";
			//var results = await request.UploadAsync(CancellationToken.None);
			var results = request.Upload();

			if (results.Status == UploadStatus.Failed)
			{
				Console.WriteLine($"Error uploading file: {results.Exception.Message}");
			}

			// the file id of the new file we created
			_fileId = request.ResponseBody?.Id;
		}

		private void CreateFolder()
		{
			//https://developers.google.com/drive/api/guides/folder
		}

		public void Download()
		{
			var list = new List<File>();
			FilesResource.ListRequest request = _driveService.Files.List();
			
			_driveService

			do
			{
				try
				{
					FileList files = request.Execute();

					list.AddRange(files.Files);
					request.PageToken = files.NextPageToken;
				}
				catch (Exception e)
				{
					Console.WriteLine("An error occurred: " + e.Message);
					request.PageToken = null;
				}
			} while (!String.IsNullOrEmpty(request.PageToken));

			foreach (var file in list)
			{
				_driveService.Files.Delete(file.Id);
			}
		}


		/*var allFiles = new Google.Apis.Drive.v3.Data.FileList();
		allFiles.Files = new List<Google.Apis.Drive.v3.Data.File>();
		foreach (var file in allFiles.Files)
		{
			if (file.Name == "160.notes")
			{
				using var fileStream = new FileStream(@"C:\Users\Artem\Desktop\" + file.Name, FileMode.Create,
					FileAccess.Write);
				_driveService.Files.Get(file.Id).Download(fileStream);
			}
		}*/


		public CloudNote()
		{
			SignIn();
		}
	}
}