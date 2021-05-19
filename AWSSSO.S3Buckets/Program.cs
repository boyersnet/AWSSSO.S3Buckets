using System;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Configuration;

namespace AWSSSO.S3Buckets
{
    class Program
    {
        private static IAmazonS3 _s3Client;

        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var options = builder.Build().GetAWSOptions();

            _s3Client = options.CreateServiceClient<IAmazonS3>();
            ListBuckets().Wait();
        }

        private static async Task ListBuckets()
        {
            ListBucketsRequest request = new ListBucketsRequest();
            ListBucketsResponse response = await _s3Client.ListBucketsAsync(request);
            // Process response.
            foreach (S3Bucket bucket in response.Buckets)
            {
                Console.WriteLine($"{bucket.BucketName}");
            }

        }
    }
}
