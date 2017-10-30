using System;
using System.Collections.Generic;
using System.Globalization;

using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Content;
using Android.Views;
using Android.Graphics.Drawables;
using Android.Widget;

namespace RecyclerViewX
{
    [Activity(Label = "RecyclerViewX", MainLauncher = true, Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        public List<Person> _personsList { get; set; } = new List<Person>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var actionBar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.mainActionBar);
            actionBar.Title = "დიქტატორები";
            SetSupportActionBar(actionBar);
            GetData();

            var rc = FindViewById<RecyclerView>(Resource.Id.PersonsRecyclerView);
            var lm = new LinearLayoutManager(this);
            var pa = new PersonAdapter(_personsList);

            pa.ProfilePictureClick += Pa_ProfilePictureClick;
            pa.ProfilePictureLongClick += Pa_ProfilePictureLongClick;
            pa.FullNameClick += Pa_FullNameClick;
            pa.AgeClick += Pa_AgeClick;
            pa.EmailLongClick += Pa_EmailLongClick;
            pa.ButtonSendClick += Pa_ButtonSendClick;
            pa.ButtonCallClick += Pa_ButtonCallClick;

            rc.SetLayoutManager(lm);
            rc.SetAdapter(pa);
        }     

        private void Pa_ButtonCallClick(object sender, PersonAdapter.PersonClickEventArgs e)
        {
            Intent intent = new Intent(Intent.ActionCall, Android.Net.Uri.FromParts("tel", e.Person.PhoneNumber, null));
            StartActivity(intent);
        }

        private void Pa_ButtonSendClick(object sender, PersonAdapter.PersonClickEventArgs e)
        {
            Intent it = new Intent(Intent.ActionSendto, Android.Net.Uri.FromParts("smsto", e.Person.PhoneNumber, null));
            it.PutExtra("sms_body", $"Hi, {e.Person.FirstName} {e.Person.LastName}");
            StartActivity(it);
        }

        private void Pa_EmailLongClick(object sender, PersonAdapter.PersonClickEventArgs e)
        {
            Toast.MakeText(this, $"Long Click on {e.Person.FirstName} {e.Person.LastName} Email", ToastLength.Long).Show();
        }

        private void Pa_AgeClick(object sender, PersonAdapter.PersonClickEventArgs e)
        {
            Toast.MakeText(this, $"Clicked {e.Person.FirstName} {e.Person.LastName} Age", ToastLength.Long).Show();
        }

        private void Pa_FullNameClick(object sender, PersonAdapter.PersonClickEventArgs e)
        {
            Toast.MakeText(this, $"Clicked {e.Person.FirstName} {e.Person.LastName} Name", ToastLength.Long).Show();
        }

        private void Pa_ProfilePictureLongClick(object sender, PersonAdapter.PersonClickEventArgs e)
        {
            Dialog profilePictureDialog = new Dialog(this);
            profilePictureDialog.Window.RequestFeature(WindowFeatures.NoTitle);

            var profilePictureDialogLayout = LayoutInflater.From(this).Inflate(Resource.Layout.ProfilePicture, null);
            profilePictureDialogLayout.FindViewById<ImageView>(Resource.Id.imgvDialogProfilePicture).SetImageResource(e.Person.ImageResourceId);
            profilePictureDialog.SetContentView(profilePictureDialogLayout);
            profilePictureDialog.Show();
        }

        private void Pa_ProfilePictureClick(object sender, PersonAdapter.PersonClickEventArgs e)
        {
            Toast.MakeText(this, $"Clicked {e.Person.FirstName} {e.Person.LastName} Profile Picture", ToastLength.Long).Show();
        }

        public void GetData()
        {
            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("0999/12/31", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.vader,
                FirstName = "Darth",
                LastName = "Vader",
                Gender = Genders.Male,
                Email = "Darth-Vader@gmail.com",
                PhoneNumber = "+995111111111"
            });         

            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("1971/10/13", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.baron,
                FirstName = "Sacha",
                LastName = "Baron",
                Gender = Genders.Female,
                Email = "Cohen@gmail.com",
                PhoneNumber = "+995222222222"
            });

            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("1926/08/13", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.castro,
                FirstName = "Fidel",
                LastName = "Castro",
                Gender = Genders.Male,
                Email = "Cuba@gmail.com",
                PhoneNumber = "+995333333333"
            });

            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("1878/12/18", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.stalin,
                FirstName = "Joseph",
                LastName = "Stalin",
                Gender = Genders.Male,
                Email = "CCCP@gmail.com",
                PhoneNumber = "++995444444444"
            });

            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("1967/12/25", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.saakashvili,
                FirstName = "Mikheil",
                LastName = "Saakashvili",
                Gender = Genders.Male,
                Email = "Nacionali555@gmail.com",
                PhoneNumber = "+995555555555"
            });

            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("1912/04/15", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.kim,
                FirstName = "Kim",
                LastName = "Il-sung",
                Gender = Genders.Male,
                Email = "Korea@gmail.com",
                PhoneNumber = "+995666666666"
            });

            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("1952/10/07", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.putin,
                FirstName = "Vladimir",
                LastName = "Putin",
                Gender = Genders.Male,
                Email = "Russia@gmail.com",
                PhoneNumber = "+995777777777"
            });

            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("1889/04/20", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.hitler,
                FirstName = "Adolf",
                LastName = "Hitler",
                Gender = Genders.Male,
                Email = "Fuhrer@gmail.com",
                PhoneNumber = "+995888888888"
            });

            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("1883/07/29", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.mussolini,
                FirstName = "Benito",
                LastName = "Mussolini",
                Gender = Genders.Male,
                Email = "Italy@gmail.com",
                PhoneNumber = "+995999999999"
            });

            _personsList.Add(new Person()
            {
                BD = DateTime.ParseExact("1937/04/28", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                ImageResourceId = Resource.Drawable.hussein,
                FirstName = "Saddam",
                LastName = "Hussein",
                Gender = Genders.Male,
                Email = "Iraq@gmail.com",
                PhoneNumber = "+995121212121"
            });
        }
    }
}

