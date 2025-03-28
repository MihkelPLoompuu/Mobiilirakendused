﻿using Services;
using ViewModels;
using Pages;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Constants;
using Interfaces;

namespace MAUICommerce
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
             builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
                    fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuBold");
                }).UseMauiCommunityToolkit();

            builder.Services.AddSingleton<IPlatformHttpMessageHandler>(sp =>
            {
#if ANDROID
                return new Platforms.Android.AndroidHttpMessageHandler();
#elif IOS
            return new Platforms.iOS.IosHttpMessageHandler();
#endif
                return null;
            });

            builder.Services.AddHttpClient(Constants.AppConstants.HttpClientName, httpClient =>
            {
                var baseAddress = DeviceInfo.Platform == DevicePlatform.Android ?
                "https://10.0.2.2:12345" 
                : "https://localhost:12345";
                httpClient.BaseAddress = new Uri(baseAddress);
            })
                .ConfigureHttpMessageHandlerBuilder(confifBuilder =>
                {
                    var platformHttpMessageHandler = confifBuilder.Services.GetRequiredService<IPlatformHttpMessageHandler>();
                    confifBuilder.PrimaryHandler = platformHttpMessageHandler.GetHttpMessageHandler();
                });

            builder.Services.AddSingleton<CategoryService>();
            builder.Services.AddSingleton<ProductsServices>();
            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddTransient<OffersServices>();

            builder.Services.AddSingleton<CartViewModel>();
            builder.Services.AddTransient<CartPage>();

            builder.Services.AddTransient<CategoriesPage>();

            builder.Services.AddTransientWithShellRoute<CategoryProductsPage, CategoryProductsViewModel>(nameof(CategoryProductsPage));

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
