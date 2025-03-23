using Models;
using Services;
using System.Collections.ObjectModel;

namespace Pages;

public partial class Categories : ContentPage
{
    private readonly CategoryService _categoryService;
    public Categories (CategoryService categoryService)
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
}