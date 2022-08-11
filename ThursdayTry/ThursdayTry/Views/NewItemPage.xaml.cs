using System;
using System.Collections.Generic;
using System.ComponentModel;
using ThursdayTry.Models;
using ThursdayTry.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThursdayTry.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}