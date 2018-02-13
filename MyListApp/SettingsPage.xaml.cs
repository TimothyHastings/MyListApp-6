﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyListApp
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage()
		{
			InitializeComponent();
		}

		void firstNameEntryCompleted(object sender, EventArgs args)
		{
			var entry = (Entry)sender;
			// TODO Validate
		}

		void surnameEntryCompleted(object sender, EventArgs args)
		{
			var entry = (Entry)sender;
			// TODO Validate
		}

		void UserNameEntryCompleted(object sender, EventArgs args)
		{
			var entry = (Entry)sender;
			// TODO Validate
		}

		void PasswordEntryCompleted(object sender, EventArgs args)
		{
			var entry = (Entry)sender;
			// TODO Validate
		}

		void ServerURLEntryCompleted(object sender, EventArgs args)
		{
			var entry = (Entry)sender;
			// TODO Validate
		}

		void OnSaveButtonClicked(object sender, EventArgs args)
		{
			// TODO Validate
			User user = new User();
			user.FirstName = firstNameEntry.Text;
			user.Surname = surnameNameEntry.Text;
			user.UserName = userNameEntry.Text;
			user.Password = passwordEntry.Text;
			user.ServerURL = serverURLEntry.Text;
			Model.Users.Clear();
			Model.Users.Add(user);
			Database.SaveModel();
		}

		//	Use to load saved user
		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (Model.Users.Count > 0)
			{
				firstNameEntry.Text = Model.Users[0].FirstName;
				surnameNameEntry.Text = Model.Users[0].Surname;
				userNameEntry.Text = Model.Users[0].UserName;
				passwordEntry.Text = Model.Users[0].Password;
				serverURLEntry.Text = Model.Users[0].ServerURL;
			}

		}
	}
}
