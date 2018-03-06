using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CameraButton.Clicked += CameraButton_Clicked;

            
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

                if (photo != null)
                {
                    ARGNSAmazonService mAmazonService = new ARGNSAmazonService();

                    List<Stream> mStreamList = new List<Stream>();

                    mStreamList.Add(photo.GetStream());

                    Task<List<Amazon.Rekognition.Model.Label>> mAddImgToS3ResponseTask = mAmazonService.AddImageToS3(mStreamList);
                    List<Amazon.Rekognition.Model.Label> mAddImgToS3Response = await mAddImgToS3ResponseTask;
                    List<string> mListRec = new List<string>();

                    //foreach (var item in mAddImgToS3Response)
                    //{
                    //    mListRec.Add(item.Name);
                    //}
                    
                    //PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });

                    await Navigation.PushAsync(new Test(mAddImgToS3Response, photo.GetStream()));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void Test_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://wwww.hotmail.com"));

        }

        public async void UpdateLabel()
        {
            await Navigation.PushAsync(new Test());
        }


    }
}
