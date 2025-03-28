using Pages;
using System.ComponentModel;

namespace Controls;

public partial class CartControl : ContentView
{
	public static readonly BindableProperty CountProperty = BindableProperty.Create(
		nameof(Count), typeof(int), typeof(CartControl), 0, propertyChanged: OnCountChanged);
    public CartControl()
	{
		InitializeComponent();
	}

	public int Count 
	{ 
		get => (int)GetValue(CountProperty);
		set => SetValue(CountProperty, value); 
	}

	private bool _alredyAllocated;
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        if (!_alredyAllocated)
        {
            container.Scale = 0;
            _alredyAllocated = true;
        }
    }

    private async Task AnimateContainer(AnimationType animationType)
	{
		switch (animationType)
		{
			case AnimationType.In:
				await Task.WhenAll(container.ScaleTo(1.5),container.RotateTo(360));
                await Pulse();
                break;
            case AnimationType.Out:
                await Task.WhenAll(container.ScaleTo(0), container.RotateTo(-360));
                break;
			default:
                await Pulse();
                break;
        }

		async Task Pulse()
		{
			await container.ScaleTo(1, 180);
			await container.ScaleTo(1.2, 180);
			await container.ScaleTo(1, 180);
			await container.ScaleTo(1.2, 180);
			await container.ScaleTo(1, 180);
		}
	}
	enum AnimationType
	{
		Out,
		In,
        Pulse
    }

    private static void OnCountChanged(BindableObject bindable, object oldValue, object newValue)
    {
		int oldCount = (int)oldValue;
        int newCount = (int)newValue;

        if (oldCount != newCount)
		{
            var cartControl = (CartControl)bindable;
            if (newCount < 1)
			{
				//there are no item in the cart
				cartControl.AnimateContainer(AnimationType.Out);
            }
			else if(oldCount < 1 && newCount > 1)
			{
                //This is the first itme to be added to the cart
                cartControl.AnimateContainer(AnimationType.In);
            }
			else
			{
                //Iccrease
                cartControl.AnimateContainer(AnimationType.Pulse);
            }
		}
    }

	private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CartPage));
    }
}