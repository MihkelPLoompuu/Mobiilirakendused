using Models;
using Services;
using System.Collections.ObjectModel;
using ViewModels;

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
            var parameter = new Dictionary<string, object>
            {
                [nameof(CategoryProductsViewModel.SelectedCategory)] = categories
            };
            await Shell.Current.GoToAsync(nameof(CategoryProductsPage), animate : true, parameter);
        }
    }
}