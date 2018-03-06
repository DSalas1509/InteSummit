using Amazon.Rekognition.Model;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class ARGNSAmazonService
    {
        public async Task<List<Label>> AddImageToS3(List<Stream> pImageList)
        {
            try
            {
                if (pImageList.Count > 0)
                {
                    foreach (Stream mImage in pImageList)
                    {
                        AmazonS3Config mS3Config = new AmazonS3Config();
                        IAmazonS3 mClient;
                        List<Label> mLabelList = new List<Label>();

                        string mImageName = System.DateTime.Now.Day.ToString() + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Year.ToString() + System.DateTime.Now.Minute.ToString() + System.DateTime.Now.Second.ToString() + ".jpg";

                        PutObjectRequest request = new PutObjectRequest()
                        {
                            BucketName = "innovationsummit20182",
                            Key = mImageName,
                            InputStream = mImage
                        };

                        mS3Config.RegionEndpoint = Amazon.RegionEndpoint.EUWest1;
                        mClient = new AmazonS3Client("AKIAIHLRHZDRJ7VN25AA", "LA2U98sp68uZ4rlEqjq/Mb8B0oFFPIJPwyBT+y5z", mS3Config);
                        Task<PutObjectResponse> mS3ResponseTask = mClient.PutObjectAsync(request);
                        PutObjectResponse mS3Response = await mS3ResponseTask;

                        if(mS3Response.HttpStatusCode == System.Net.HttpStatusCode.OK)
                        { 
                            Task<List<Label>> mLabelListTask = AnalizeImageAmazonRekognition(mImageName, "innovationsummit20182", Amazon.RegionEndpoint.EUWest1, "AKIAIHLRHZDRJ7VN25AA", "LA2U98sp68uZ4rlEqjq/Mb8B0oFFPIJPwyBT+y5z");

                            mLabelList = await mLabelListTask;
                        }
                        ////GetObjectResponse mResponse = this.GetAmazonS3Image(mFilePost.FileName);
                        ////https://s3-eu-west-1.amazonaws.com/innovationsummit20182/scarg.png

                        //foreach (Label mLabel in mLabelList.Where(c => c.Confidence >= 90).ToList())
                        //{
                        //    switch (mLabel.Name)
                        //    {
                        //        case "Scarf":
                        //            {
                        //                //return Json(new AmazonRekognitionResult("Scarf", "https://s3-eu-west-1.amazonaws.com/innovationsummit20182/" + mFilePost.FileName, "test"));

                        //                return true;
                        //            }
                        //        case "Shirt":
                        //            {
                        //                //return Json(new AmazonRekognitionResult("Scarf", "https://s3-eu-west-1.amazonaws.com/innovationsummit20182/" + mFilePost.FileName, "test"));

                        //                return true;
                        //            }
                        //    }
                        //}

                        return mLabelList;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Label>> AnalizeImageAmazonRekognition(string pImageName, string pBucketName, Amazon.RegionEndpoint pAmazonRegion, string pAmazonAdminUser, string pAmazonAdminPassword)
        {
            Amazon.Rekognition.AmazonRekognitionClient mAmazonClient = new Amazon.Rekognition.AmazonRekognitionClient(pAmazonAdminUser, pAmazonAdminPassword, pAmazonRegion);

            Amazon.Rekognition.Model.S3Object mS3Object = new Amazon.Rekognition.Model.S3Object();
            mS3Object.Bucket = pBucketName;
            mS3Object.Name = pImageName;

            DetectLabelsRequest mRequest = new DetectLabelsRequest();
            DetectLabelsResponse mDetectLabelsResponse = new DetectLabelsResponse();
            Image mImage = new Image();
            mImage.S3Object = mS3Object;
            mRequest.Image = mImage;

            try
            {


                var detectResponses = await mAmazonClient.DetectLabelsAsync(mRequest);


                //foreach (var label in detectResponses.Labels)
                //{

                //}

                ////return mResponse.Labels;

                return detectResponses.Labels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
