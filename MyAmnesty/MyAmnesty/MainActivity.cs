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

			Button button10euro = FindViewById<Button> (Resource.Id.button10euro);

			button10euro.Click += delegate {
				StartActivity(typeof(FormulierActivity));
			};


			}
	}
}


