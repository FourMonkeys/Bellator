using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Bellator.Models;
using Bellator.Views;
using Bellator.ViewModels;

namespace Bellator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProblematicItems : ContentPage
    {
        ProblematicItemsViewModel viewModel;

        public ProblematicItems()
        {
            InitializeComponent();
            BindingContext = viewModel = new ProblematicItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
