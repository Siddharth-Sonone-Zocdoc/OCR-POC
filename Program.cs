using System;
using Amazon.Textract;

namespace FeedbackOCR
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var awsAmazonTextractClient = new AmazonTextractClient();
            var sampleFile1 = "C:\\Users\\siddharth.sonone\\Desktop\\FeedBackOCR\\FeedbackOCR\\sample-form-1.png";
            var sampleFile2 = "C:\\Users\\siddharth.sonone\\Desktop\\FeedBackOCR\\FeedbackOCR\\sample-form-2.jpg";
            var sampleFile3 = "C:\\Users\\siddharth.sonone\\Desktop\\FeedBackOCR\\FeedbackOCR\\sample-form-3.jpg";

            var feedBackOcr = new FeedBackFormOCR(awsAmazonTextractClient);
            Console.WriteLine("\nPrinted Response\n");
            feedBackOcr.PrintResponse(feedBackOcr.DetectTextLocalFile(sampleFile1));
            Console.WriteLine("\nJSON Response\n");
            feedBackOcr.CreateJson(feedBackOcr.DetectTextLocalFile(sampleFile1));
            Console.ReadLine();
        }
    }
}
