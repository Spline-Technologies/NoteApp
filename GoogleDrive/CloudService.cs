namespace GoogleDrive;

using System.Collections.Generic;
using System.IO;
using File = Google.Apis.Drive.v3.Data.File;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

public static class CloudService
{
	//todo поменять пути к файлам
	private const string PathToServiceAccountKeyFile =
		@"C:\Users\Artem\RiderProjects\NoteApp\noteapp-359513-256e4981656e.json";

	private const string UploadFileName =
		@"C:\Users\Artem\RiderProjects\NoteApp\NoteApp.notes";

	private const string DirectoryId = "1DFPage9cKRuuJ-7MkZOEc2VfqoAn3876";
	private static DriveService _driveService;


	static CloudService()
	{
		SignIn();
	}

	private static void SignIn()
	{
		_driveService = new DriveService(new BaseClientService.Initializer()
		{
			HttpClientInitializer = GoogleCredential.FromFile(PathToServiceAccountKeyFile)
				.CreateScoped(DriveService.ScopeConstants.Drive)
		});
	}

	public static string CreateFile()
	{
		var fileMetadata = new File()
		{
			Parents = new List<string>() { DirectoryId }
		};

		using var fileStream = new FileStream(UploadFileName, FileMode.Create, FileAccess.ReadWrite);

		var request = _driveService.Files.Create(fileMetadata, fileStream, "text/plain");
		request.Upload();

		return request.ResponseBody?.Id;
	}

	public static void Upload(string id)
	{
		var fileMetadata = new File();
		using var fileStream = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read);
		_driveService.Files.Update(fileMetadata, id, fileStream, "text/plain").Upload();
	}

	public static void Download(string id)
	{
		var stream = new MemoryStream();
		_driveService.Files.Get(id).Download(stream);
		
		using var filestream = new FileStream(UploadFileName, FileMode.Create, FileAccess.Write);
		stream.WriteTo(filestream);
	}

	public static void Rename(string id)
	{
		var fileMetadata = new File()
		{
			Name = id
		};

		_driveService.Files.Update(fileMetadata, id).Execute();
	}

	public static void CreateFileCopy(string id)
	{
		var fileMetadata = new File()
		{
			Name = id + ".old",
			Parents = new List<string>() { DirectoryId }
		};

		_driveService.Files.Copy(fileMetadata, id).Execute();
	}
}