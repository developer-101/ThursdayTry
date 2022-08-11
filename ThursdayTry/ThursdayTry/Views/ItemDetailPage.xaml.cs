using System.ComponentModel;
using ThursdayTry.ViewModels;
using Xamarin.Forms;

namespace ThursdayTry.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}