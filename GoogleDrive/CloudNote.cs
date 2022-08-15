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
	public class CloudNote
	{
		//todo поменять пути к файлам
		private const string PathToServiceAccountKeyFile =
			@"C:\Users\Artem\RiderProjects\NoteApp\noteapp-359513-256e4981656e.json";

		private const string ServiceAccountEmail = "testname@sharp-quest-359006.iam.gserviceaccount.com";
		private const string UploadFileName = @"C:\Users\Artem\RiderProjects\NoteApp\NoteApp.notes";
		private const string DirectoryId = "1DFPage9cKRuuJ-7MkZOEc2VfqoAn3876";

		private void SignIn()
		{
			var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile)
				.CreateScoped(DriveService.ScopeConstants.Drive);

			// Create the  Drive service.
			var service = new DriveService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential
			});
		}

		private void Rename()
		{
		}

		private void Rewrite()
		{
		}

		private void Upload()
		{
		}

		private void Download()
		{
		}
	}
}