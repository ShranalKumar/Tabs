﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace Tabs
{
    public partial class AzureTable : ContentPage
    {

        public AzureTable()
        {
            InitializeComponent();

        }

        async void Handle_ClickedAsync(object sender, System.EventArgs e)
        {
            List<shranalNotHotdogModel> notHotDogInformation = await AzureManager.AzureManagerInstance.GetHotDogInformation();

            HotDogList.ItemsSource = notHotDogInformation;
        }

    }
}