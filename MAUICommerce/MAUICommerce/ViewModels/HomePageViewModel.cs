using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUICommerce.Shared.Dtos;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ViewModels
{
    public  partial class HomePageViewModel : ObservableObject, IDisposable
    {
        private readonly CategoryService _categoryService;
        private readonly OffersServices _offersServices;
        private readonly ProductsServices _productsServices;
        private readonly CartViewModel _cartViewModel;
        public HomePageViewModel(CategoryService categoryService, OffersServices offersServices,ProductsServices productsServices, CartViewModel cartViewModel)
        {
            _categoryService = categoryService;
            _offersServices = offersServices;
            _productsServices = productsServices;
            _cartViewModel = cartViewModel;

            _cartViewModel.CartCountUpdated += CartViewModel_CartCountUpdated;
            _cartViewModel.CartItemUpdated += CartViewModel_CartItemUpdated;
            _cartViewModel.CartItemRemoved += CartViewModel_CartItemRemoved;
        }

        private void CartViewModel_CartItemRemoved(object sender, int productId)
            => ModifyProductQuantity(productId, 0);

        private void CartViewModel_CartItemUpdated(object sender, CartItem e)
            => ModifyProductQuantity(e.ProductId, e.Quantity);
        private void ModifyProductQuantity(int productId, int quantity)
        {
            var product = PopularProducts.FirstOrDefault(p => p.Id == productId);
            if (product is not null)
            {
                product.CartQuanity += quantity;
            }
        }

        private void CartViewModel_CartCountUpdated(object sender, int cartCount)
            => CartCount = cartCount;

        public ObservableCollection<Category> Categories { get; set; } = new();
        public ObservableCollection<Offer> Offers { get; set; } = new();
        public ObservableCollection<ProductDto> PopularProducts { get; set; } = new();

        [ObservableProperty]
        private bool _isBusy = true;

        [ObservableProperty]
        private int _cartCount;

        private bool _isInitialized = false;
        public async void InitializeAsync()
        {
            if (_isInitialized)
                return;
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
                _isInitialized = true;
            }          
           finally 
            {
                IsBusy = false;
            }          
        }

        [RelayCommand]
        private void AddToCart(int productId) => UpdaetCart(productId, 1);
        [RelayCommand]
        private void RemoveFromCart(int productId) => UpdaetCart(productId, -1);
        private void UpdaetCart(int productId,int count)
        {
            var product = PopularProducts.FirstOrDefault(p => p.Id == productId);
            if (product is not null)
            {
                product.CartQuanity += count;

                if(count == -1)
                {
                    _cartViewModel.RemoveFromCartCommand.Execute(product.Id);
                }
                else
                {
                    _cartViewModel.AddToCartCommand.Execute(product);
                }
                CartCount = _cartViewModel.Count;
            }
        }
        public void Dispose()
        {
            _cartViewModel.CartCountUpdated -= CartViewModel_CartCountUpdated;
            _cartViewModel.CartItemUpdated -= CartViewModel_CartItemUpdated;
            _cartViewModel.CartItemRemoved -= CartViewModel_CartItemRemoved;
        }
    }
}
