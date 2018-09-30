using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Bellator.Models;
using Bellator.Services;

using System.Threading.Tasks;
using System.Diagnostics;

namespace Bellator.ViewModels
{
    public class ProblematicItemsViewModel : BaseViewModel
    {
        public ObservableCollection<ProblematicItem> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ProblematicItemsViewModel()
        {
            Title = "Problematic Items";
            Items = new ObservableCollection<ProblematicItem>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            ProblematicItems items = new ProblematicItems();

            try
            {
                Items.Clear();
                //var items = await DataStore.GetItemsAsync(true);
                ProblematicItems pi = new ProblematicItems();


                foreach (ProblematicItem item in pi.items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

