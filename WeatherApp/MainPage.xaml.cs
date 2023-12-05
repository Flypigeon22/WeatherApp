﻿using WeatherApp.Services;
using WeatherApp.Models;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

      protected async override void OnAppearing()
        {
            base.OnAppearing();
            var result = await ApiService.GetWeather(24.1469, 120.6839);
            LblCity.Text = result.city.name;
            LblWeatherDescription.Text = result.list[0].weather[0].description;
        }
    }
}