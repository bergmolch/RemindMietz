using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemindMietz.ViewModels;
using Xamarin.Forms;

namespace RemindMietz
{
    public partial class MainPage : ContentPage
    {

        public MainViewModel Vm
        {
            get;
            set;
        }

        public MainPage()
        {
            InitializeComponent();
            Vm = new MainViewModel();
            BindingContext = Vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Vm.Date = DateTime.Now;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
