using System.ComponentModel;
using Xamarin.Forms;
using NOOKC01.ViewModels;

namespace NOOKC01.Views
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