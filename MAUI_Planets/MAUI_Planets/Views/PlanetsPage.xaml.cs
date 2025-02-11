using Models;
using Services;

namespace Views;

public partial class PlanetsPage : ContentPage
{
	private const uint AnimationDuration = 800u;
	public PlanetsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
		lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
    }

	async void Planets_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
	{
		await Navigation.PushAsync(new PlanetsDetailsPage(e.CurrentSelection.First() as Planet));
	}
}