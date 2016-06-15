using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace demoXamarin
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            lblTexto.Text = "Hola";
            btn.Clicked += (sender, args) =>
            {
                lblTexto.Text = "Cambio";
                lblTexto.IsVisible = !lblTexto.IsVisible;
            };
        }
    }
}
