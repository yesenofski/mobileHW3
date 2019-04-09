using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Content.Res;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobileHW3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            
       
            Navigation.PushAsync(new Page2(Entry.Text)); 
        }
    }
    
}