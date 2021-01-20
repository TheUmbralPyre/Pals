using Android.Content;
using Android.Widget;
using Pals.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SearchBar), typeof(CustomSearchBarRenderer))]
namespace Pals.Droid
{
    class CustomSearchBarRenderer : SearchBarRenderer
    {
        public CustomSearchBarRenderer(Context context)
            : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            // Initialize a variable and assign Control to it as a SearchView
            var searchView = base.Control as SearchView;

            // Initialize a variable to store the Id recieved using the component name
            var magIconId = searchView.Context.Resources.GetIdentifier("android:id/search_mag_icon", null, null);

            // Initialize a variable and assign the view with the previousley recieved id as an ImageView
            var magIcon = (ImageView)searchView.FindViewById(magIconId);

            // Change the Icon
            // magIcon.SetImageResource(Resource.Drawable.ic_pets);

            // Set the view's color filter
            magIcon.SetColorFilter(Android.Graphics.Color.Rgb(102, 166, 255));

            // Initialize a variable to store the Id recieved using the component name
            var plateId = searchView.Context.Resources.GetIdentifier("android:id/search_plate", null, null);

            // Initialize a variable and assign the view with the previousley recieved id
            var plate = searchView.FindViewById(plateId);

            // Set the plate's background color to transparent
            plate.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}