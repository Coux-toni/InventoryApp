using InventoryApp.Coree.Models;

namespace InventoryApp.Gui
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage(DashboardViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;
        }

     
    }

}
