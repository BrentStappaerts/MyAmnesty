
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
			var editTextAdres = FindViewById<EditText> (Resource.Id.editTextAdres);
			var editTextGemeente = FindViewById<EditText> (Resource.Id.editTextGemeente);
			var editTextNummer = FindViewById<EditText> (Resource.Id.editTextNummer);

			buttonDoneer.Click += delegate {
				if(editTextVoornaam.Text.Length >= 1 & editTextAchternaam.Text.Length >= 1){

					if(editTextAdres.Text.Length >= 1 & editTextGemeente.Text.Length >= 1){

						string email = editTextEmail.Text;
						if(email.IndexOf("@") == -1){
							editTextValidatie.Text = "Er ontbreekt een @ in uw email.";
								}
							else{
							
									if(editTextNummer.Text.Length >=9 ){
								
										string rekening = editTextRekening.Text;
										if(editTextRekening.Text.Length == 16){
												if ( rekening.IndexOf("BE") == -1){
													editTextValidatie.Text = "Rekeningnummer moet beginnen met BE.";
												}
											else{
											buttonDoneer.Click += delegate {
											var OverzichtActivity = new Intent (this, typeof(OverzichtActivity));
											OverzichtActivity.PutExtra ("Naam", editTextVoornaam.Text + " " + editTextAchternaam.Text);
											OverzichtActivity.PutExtra ("Email", editTextEmail.Text);
											StartActivity (OverzichtActivity); 

													
										};
								};
								}
							
								else{
									editTextValidatie.Text = "Rekeningnummer te kort (16 tekens).";
								}
							}
							else{
								editTextValidatie.Text = "Nummer niet correct.";
							}
							}
					}
					else{
						editTextValidatie.Text = "Adres niet volledig ingevuld.";
					}
				}
				else{
					editTextValidatie.Text = "Naam niet volledig ingevuld.";
				}
			
			};

		
		
		}
	}
}


