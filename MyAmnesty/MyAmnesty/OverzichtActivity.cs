
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyAmnesty
{
	[Activity ()]			
	public class OverzichtActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Overzicht);

			// Create your application here
			var editTextVoornaam = FindViewById<EditText> (Resource.Id.editTextVoornaam);
			var editTextBedanktWie = FindViewById<EditText> (Resource.Id.editTextBedanktWie);
			var editTextOutputEmail = FindViewById<EditText> (Resource.Id.editTextOutputEmail);
	
			editTextBedanktWie.Text = Intent.GetStringExtra ("Naam") ?? "Data not available";
			editTextOutputEmail.Text = Intent.GetStringExtra ("Email") ?? "Data not available";
			Button buttonDonatie = FindViewById<Button> (Resource.Id.buttonDonatie);

			Button buttonVerder = FindViewById<Button> (Resource.Id.buttonVerder);

			buttonDonatie.Click += delegate {

				StartActivity(typeof(MainActivity));
			};
		}
	}
}

