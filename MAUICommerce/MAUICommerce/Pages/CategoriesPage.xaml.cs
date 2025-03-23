using Models;
using Services;
using System.Collections.ObjectModel;

namespace Pages;

public partial class CategoriesPage : ContentPage
{
    private readonly CategoryService _categoryService;
    public CategoriesPage(CategoryService categoryService)
	{
        InitializeComponent();
        _categoryService = categoryService;
        BindingContext = this;
    }

	public ObservableCollection<Category> Categories { get; set; } = new ();

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        Categories.Clear();
        foreach(var categories in await _categoryService.GetCategoriesAsync())
        {
            Categories.Add(categories);
        }
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection?[0] is Category categories)
        {
            await Shell.Current.GoToAsync(nameof(CategoryProductsPage));
        }
    }
}