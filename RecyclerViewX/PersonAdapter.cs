using System;

using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using ImageViews.Rounded;

namespace RecyclerViewX
{
    public partial class PersonAdapter : RecyclerView.Adapter
    {
        public List<Person> _persons { get; set; } = new List<Person>();
        public PersonAdapter(List<Person> persons) => _persons = persons;
        public override int ItemCount => _persons.Count;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var vh = new PersonAdapterViewHolder(LayoutInflater.From(parent.Context)
                .Inflate(Resource.Layout.PersonalAdapterItem, parent, false));

            vh.ProfilePictureClick += (s, e) => OnProfilePictureClick(s, new PersonClickEventArgs() { View = e.View, Position = e.Position, Person = _persons[e.Position] });
            vh.ProfilePictureLongClick += (s, e) => OnProfilePictureLongClick(s, new PersonClickEventArgs() { View = e.View, Position = e.Position, Person = _persons[e.Position] });
            vh.FullNameClick += (s, e) => OnFullNameClick(s, new PersonClickEventArgs() { View = e.View, Position = e.Position, Person = _persons[e.Position] });
            vh.AgeClick += (s, e) => OnAgeClick(s, new PersonClickEventArgs() { View = e.View, Position = e.Position, Person = _persons[e.Position] });
            vh.EmailLongClick += (s, e) => OnEmailLongClick(s, new PersonClickEventArgs() { View = e.View, Position = e.Position, Person = _persons[e.Position] });
            vh.ButtonSendClick += (s, e) => OnButtonSendClick(s, new PersonClickEventArgs() { View = e.View, Position = e.Position, Person = _persons[e.Position] });
            vh.ButtonCallClick += (s, e) => OnButtonCallClick(s, new PersonClickEventArgs() { View = e.View, Position = e.Position, Person = _persons[e.Position] });

            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var vh = viewHolder as PersonAdapterViewHolder;

            vh.imgvProfilePicture?.SetImageResource(_persons[position].ImageResourceId);
            vh.txtvFullName.Text = _persons[position].FirstName + " " + _persons[position].LastName;
            vh.txtvAge.Text = (DateTime.Now.Year - _persons[position].BD.Year).ToString();
            vh.txtvEmail.Text = _persons[position].Email;

            switch (_persons[position].Gender)
            {
                case Genders.Male: vh.imgvProfilePicture.BorderColor = -9331542; break;
                case Genders.Female: vh.imgvProfilePicture.BorderColor = -60269; break; 
            }
        }      
    }
}