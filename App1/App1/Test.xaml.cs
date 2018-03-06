using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test : ContentPage
    {
        
        public Test()
        {
            InitializeComponent();
        }


        public Test(List<Amazon.Rekognition.Model.Label> pType, Stream pPhoto)
        {
            InitializeComponent();
            ItemsLinesView.ItemsSource = pType;
            PhotoImage.Source = ImageSource.FromStream(() => { return pPhoto; });
        }


        public async void UpdateLabel()
        {
            await Navigation.PushAsync(new Test());
        }

        //protected override void OnAppearing()
        //{s
        //    base.OnAppearing();

        //    MessagingCenter.Subscribe<App, List<string>>((App)Xamarin.Forms.Application.Current, "ImagesSelected", (s, images) =>
        //    {
        //        listItems.FlowItemsSource = images;
        //        _images = images;
        //    });
        //}

        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //    MessagingCenter.Unsubscribe<App, List<string>>(this, "ImagesSelected");
        //}

        //async void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    await DependencyService.Get<IMediaService>().OpenGallery();
        //}

       
    }
}