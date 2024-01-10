using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPropertiesTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Application.Current.Properties.TryGetValue("test", out var value);

            Application.Current.Properties["test"] = "123";
            Application.Current.SavePropertiesAsync();
        }
    }
}
