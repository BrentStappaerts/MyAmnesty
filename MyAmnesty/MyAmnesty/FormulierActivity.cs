
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
	[Activity (Label = "FormulierActivity")]			
	public class FormulierActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Formulier);

			// Create your application here


			Button buttonDoneer = FindViewById<Button> (Resource.Id.buttonDoneer);
			var editTextVoornaam = FindViewById<EditText> (Resource.Id.editTextVoornaam);
			var editTextAchternaam = FindViewById<EditText> (Resource.Id.editTextAchternaam);
			var editTextRekening = FindViewById<EditText> (Resource.Id.editTextRekening);
			var editTextValidatie = FindViewById<EditText> (Resource.Id.editTextValidatie);
			var editTextEmail = FindViewById<EditText> (Resource.Id.editTextEmail);

			buttonDoneer.Click += delegate {
				if(editTextVoornaam.Text.Length >= 1 & editTextAchternaam.Text.Length >= 1){


					if(editTextRekening.Text.Length == 16){
						if(editTextEmail.Text ==  "@"){
							StartActivity(typeof(MainActivity));
						}
						else{
							editTextValidatie.Text = "Email niet correct.";
						}
					}
					else{
						editTextValidatie.Text = "Rekeningnummer niet correct (14 cijfers).";
					}
				}
				else{
					editTextValidatie.Text = "Naam niet volledig ingevuld.";
				}
			
			};
		
		}
	}
}


