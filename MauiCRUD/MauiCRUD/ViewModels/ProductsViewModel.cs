using CommunityToolkit.Mvvm.ComponentModel;
using Data;
using Models;
using System.Collections.ObjectModel;


namespace ViewModels
{
    public partial class ProductsViewModel : ObservableObject
    {
        private readonly DatabaseContext _context;

        public ProductsViewModel(DatabaseContext context)
        {
            _context = context;
        }

        [ObservableProperty]
        private ObservableCollection<Product> _products = new();

        [ObservableProperty]
        private Product _
    }
}
