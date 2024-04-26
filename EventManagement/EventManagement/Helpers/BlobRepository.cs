



using Azure.Storage.Blobs;

public interface IBlobRepository
{
    Task<BlobClient> UploadBlobAsync(IFormFile file);
    Task<Stream> GetBlobAsync(string blobName);
    Task<bool> DeleteBlobAsync(string blobName);
}

public class AzureBlobRepository : IBlobRepository
{
    private readonly BlobServiceClient _blobServiceClient;
    private readonly string _containerName;
    private readonly BlobContainerClient _blobContiner;

    public AzureBlobRepository(string connectionString, string containerName)
    {
        if (string.IsNullOrEmpty(connectionString))
            throw new Exception("Connection String is null");
        if (string.IsNullOrEmpty(containerName))
            throw new Exception("container name or containerId is null");


        _blobServiceClient = new BlobServiceClient(connectionString);
        _containerName = containerName;

        _blobContiner = _blobServiceClient.GetBlobContainerClient(_containerName);
        if (_blobContiner != null)
        {
            Task.Run(async () => await _blobContiner.CreateIfNotExistsAsync());
        }
    }

    public async Task<BlobClient> UploadBlobAsync(IFormFile file)
    {
        var blobClient = _blobContiner.GetBlobClient(file.FileName);

        using (var stream = file.OpenReadStream())
        {
            await blobClient.UploadAsync(stream, true);
        }

        return blobClient;
    }

    public async Task<Stream> GetBlobAsync(string blobName)
    {
        var blobClient = _blobContiner.GetBlobClient(blobName);

        var response = await blobClient.DownloadAsync();
        return response.Value.Content;
    }


    public async Task<bool> DeleteBlobAsync(string blobName)
    {
        var blobClient = _blobContiner.GetBlobClient(blobName);

        var response = await blobClient.DeleteIfExistsAsync();
        return response.Value;
    }
}