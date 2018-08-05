﻿using System.Collections.Generic;
using BrickController2.UI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrickController2.UI.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreationListPage : ContentPage
	{
		public CreationListPage(ViewModelFactory viewModelFactory, IDictionary<string, object> parameters)
		{
			InitializeComponent();
		    BindingContext = viewModelFactory(typeof(CreationListViewModel), parameters);
		}
	}
}