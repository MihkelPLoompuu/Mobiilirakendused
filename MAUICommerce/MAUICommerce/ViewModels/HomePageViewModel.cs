using CommunityToolkit.Mvvm.ComponentModel;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ViewModels
{
    public  class HomePageViewModel : ObservableObject
    {
        private readonly CategoryService _categoryService;
        private readonly OffersServices _offersServices;
        public HomePageViewModel(CategoryService categoryService, OffersServices offersServices)
        {
            _categoryService = categoryService;
            _offersServices = offersServices;
        }
        public ObservableCollection<Category> Categories { get; set; } = new();
        public ObservableCollection<Offer> Offers { get; set; } = new();

        public async void InitializeAsync()
        {
            var offersTask = _offersServices.GetActiveOffersAsync();
           foreach (var category in await _categoryService.GetMainCategoriesAsync())
           {
               Categories.Add(category);
           } 
           foreach (var offer in await offersTask)
           {
               Offers.Add(offer);
           }
        }
    }
}
