using Android.App;
using Android.Widget;
using Android.OS;

namespace MyAmnesty
{
	[Activity ()]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it

			Button buttonVerder = FindViewById<Button> (Resource.Id.buttonVerder);
			var editTextBedrag = FindViewById<EditText> (Resource.Id.editTextBedrag);
			var editTextValidatieBedrag = FindViewById<EditText> (Resource.Id.editTextValidatieBedrag);


			buttonVerder.Click += delegate {
				if(editTextBedrag.Text.Length >= 1 ){

				StartActivity(typeof(FormulierActivity));
				}
				else{
					editTextValidatieBedrag.Text = "U moet een bedrag ingeven";
				}
			};


			}
	}
}


