using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class BlobStorageService
    {
        readonly static CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=dropvoteprototype;AccountKey=3q4b3dn686HyF4jzTpRh/6cbuu8K6MNkXLgTC5kqabqlz0d6UOl9g60QjdjQszXkGM/DwEugjBP/LzC8rjN2DA==;EndpointSuffix=core.windows.net");
        readonly static CloudBlobClient blobClient = cloudStorageAccount.CreateCloudBlobClient();

        public static async Task<List<T>> GetBlobs<T>(string containerName = "teststorage1", string prefix = "", int? maxresultsPerQuery = null, BlobListingDetails blobListingDetails = BlobListingDetails.None) where T: ICloudBlob
        {
            var blobContainer = blobClient.GetContainerReference(containerName);

            var blobList = new List<T>();
            BlobContinuationToken continuationToken = null;

            try
            {
                do
                {
                    var response = await blobContainer.ListBlobsSegmentedAsync(prefix, true, blobListingDetails, maxresultsPerQuery, continuationToken, null, null);

                    continuationToken = response?.ContinuationToken;

                    foreach (var blob in response?.Results?.OfType<T>())
                    {
                        blobList.Add(blob);
                    }
                } while (continuationToken != null);
            }
            catch (Exception e)
            {
                //catch an exception
            }
            return blobList;
        }

        public static async Task<CloudBlockBlob> SaveBlockBlob(byte[] blob, string blobTitle, string containerName = "teststorage1")
        {
            var blobContainer = blobClient.GetContainerReference(containerName);

            var blockBlob = blobContainer.GetBlockBlobReference(blobTitle);
            await blockBlob.UploadFromByteArrayAsync(blob, 0, blob.Length);

            return blockBlob;
        }
    }
}
