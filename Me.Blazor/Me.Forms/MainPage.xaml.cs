﻿using BlazorMobile.Components;
using BlazorMobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Me.Forms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();

            //Blazor WebView agnostic contoller logic
            IBlazorWebView webview = BlazorWebViewFactory.Create();

            //WebView rendering customization on page
            View webviewView = webview.GetView();
            webviewView.VerticalOptions = LayoutOptions.FillAndExpand;
            webviewView.HorizontalOptions = LayoutOptions.FillAndExpand;

            webview.LaunchBlazorApp();

            content.Children.Add(webviewView);
        }
	}
}
