using CommunityToolkit.Mvvm.ComponentModel;
using MAUICommerce.Shared.Dtos;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ViewModels
{
    public  partial class HomePageViewModel : ObservableObject
    {
        private readonly CategoryService _categoryService;
        private readonly OffersServices _offersServices;
        private readonly ProductsServices _productsServices;
        public HomePageViewModel(CategoryService categoryService, OffersServices offersServices,ProductsServices productsServices)
        {
            _categoryService = categoryService;
            _offersServices = offersServices;
            _productsServices = productsServices;
        }
        public ObservableCollection<Category> Categories { get; set; } = new();
        public ObservableCollection<Offer> Offers { get; set; } = new();
        public ObservableCollection<ProductDto> PopularProducts { get; set; } = new();

        [ObservableProperty]
        private bool _isBusy;
        public async void InitializeAsync()
        {
            try
            {
                var offersTask = _offersServices.GetActiveOffersAsync();
                var popularProductsTask = _productsServices.GetPopularProductsAsync();
                foreach (var category in await _categoryService.GetMainCategoriesAsync())
                {
                    Categories.Add(category);
                }
                foreach (var offer in await offersTask)
                {
                    Offers.Add(offer);
                }
                foreach (var product in await popularProductsTask)
                {
                    PopularProducts.Add(product);
                }
            }          
           finally 
            {
                IsBusy = false;
            }          
        }
    }
}
