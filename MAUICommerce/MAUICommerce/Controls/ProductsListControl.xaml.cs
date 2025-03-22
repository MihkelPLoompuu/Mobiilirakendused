using MAUICommerce.Shared.Dtos;

namespace Controls;

public partial class ProductsListControl : ContentView
{
	public static readonly BindableProperty ProductsProperty =
		BindableProperty.Create(nameof(Products), typeof(IEnumerable<ProductDto>), typeof(ProductsListControl), Enumerable.Empty<ProductDto>());

    public ProductsListControl()
	{
		InitializeComponent();
	}
    public IEnumerable<ProductDto> Products 
	{
		get => (IEnumerable<ProductDto>)GetValue(ProductsProperty);
        set => SetValue(ProductsProperty, value);
    }
}