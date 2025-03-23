using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUICommerce.Shared.Dtos;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ViewModels
{
    public partial class CartViewModel : ObservableObject
    {
        public ObservableCollection<CartItem> CartItem { get; set; } = new();

        [ObservableProperty]
        private int _count;

        [ObservableProperty]
        private decimal _totalAmount;

        private void RecalculateTotalAmount() => 
            TotalAmount = CartItem.Sum(x => x.Amount);
        [RelayCommand]
        private void IncreaseCartItemQuantity(Guid cartItemId)
        {
            var item = CartItem.FirstOrDefault(x => x.Id == cartItemId);
            if (item is not null)
            {
                item.Quantity++;
                RecalculateTotalAmount();
            }
        }

        [RelayCommand]
        private void AddToCart(ProductDto product)
        {
            var item = CartItem.FirstOrDefault(x => x.ProductId == product.Id);
            if (item is not null)
            {
                item.Quantity++;
            }
            else
            {
                item = new CartItem
                {
                    Id = Guid.NewGuid(),                  
                    ProductName = product.Name,
                    ProductId = product.Id,
                    Price = product.Price,
                    Quantity = 1
                };
                CartItem.Add(item);
                Count = CartItem.Count;
            }
            RecalculateTotalAmount();
        }

        [RelayCommand]
        private void RemoveFromCart(int productId)
        {
            var item = CartItem.FirstOrDefault(x => x.ProductId == productId);
            if (item is not null)
            {
                if (item.Quantity == 1)
                {
                    CartItem.Remove(item);
                    Count = CartItem.Count;
                }
                else
                {
                    item.Quantity--;
                }
            }
            RecalculateTotalAmount();
        }

        private void ClearCart()
        {
            CartItem.Clear();
            Count = 0;
            RecalculateTotalAmount();
        }
    }
}
