﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using NoteKeeper.ViewModels;

namespace NoteKeeper.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }


        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            viewModel.Note.Heading = "XXXXXXX";
            DisplayAlert("Cancel option", $"Heading Value is {viewModel.Note.Heading}", "Button 2", "Button 1");
        }

        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Save option", "Save was clicked", "Button 2", "Button 1");
        }
    }
}