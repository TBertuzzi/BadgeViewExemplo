using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Badge.Plugin;
using Xamarin.Forms;

namespace BadgeViewExemplo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Clicked(object sender, EventArgs e)
        {

            CrossBadge.Current.SetBadge(105);

        }

        private void btnRemover_Clicked(object sender, EventArgs e)
        {

            CrossBadge.Current.ClearBadge();

        }
    }
}
