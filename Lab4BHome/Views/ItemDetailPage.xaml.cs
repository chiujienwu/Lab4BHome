using Lab4BHome.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab4BHome.Views
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