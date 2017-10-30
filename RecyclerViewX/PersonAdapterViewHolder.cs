using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using ImageViews.Rounded;

namespace RecyclerViewX
{
    public partial class PersonAdapterViewHolder : RecyclerView.ViewHolder
    {
        public View PersonItemView { get; set; }
        public RoundedImageView imgvProfilePicture { get; set; }
        public TextView txtvFullName { get; set; }
        public TextView txtvAge { get; set; }
        public TextView txtvEmail { get; set; }
        public ImageButton imgbtnvSend { get; set; }
        public ImageButton imgbtnvCall { get; set; }

        public PersonAdapterViewHolder(View itemView) : base(itemView)
        {
            this.PersonItemView = itemView;

            this.imgvProfilePicture = PersonItemView.FindViewById<RoundedImageView>(Resource.Id.imgvProfilePicture);
            this.txtvFullName = PersonItemView.FindViewById<TextView>(Resource.Id.txtvFullName);
            this.txtvAge = PersonItemView.FindViewById<TextView>(Resource.Id.txtvAge);
            this.txtvEmail = PersonItemView.FindViewById<TextView>(Resource.Id.txtvEmail);
            this.imgbtnvSend = PersonItemView.FindViewById<ImageButton>(Resource.Id.imgbtnvSend);
            this.imgbtnvCall = PersonItemView.FindViewById<ImageButton>(Resource.Id.imgbtnvCall);

            imgvProfilePicture.Click += (s, e) => OnProfilePictureClick(s, new ClickEventArgs() { View = this.PersonItemView, Position = this.AdapterPosition });
            imgvProfilePicture.LongClick += (s, e) => OnProfilePictureLongClick(s, new ClickEventArgs() { View = this.PersonItemView, Position = this.AdapterPosition });
            txtvFullName.Click += (s, e) => OnFullNameClick(s, new ClickEventArgs() { View = this.PersonItemView, Position = this.AdapterPosition });
            txtvAge.Click += (s, e) => OnAgeClick(s, new ClickEventArgs() { View = this.PersonItemView, Position = this.AdapterPosition });
            txtvEmail.LongClick += (s, e) => OnEmailLongClick(s, new ClickEventArgs() { View = this.PersonItemView, Position = this.AdapterPosition });
            imgbtnvSend.Click += (s, e) => OnButtonSendClick(s, new ClickEventArgs() { View = this.PersonItemView, Position = this.AdapterPosition });
            imgbtnvCall.Click += (s, e) => OnButtonCallClick(s, new ClickEventArgs() { View = this.PersonItemView, Position = this.AdapterPosition });
        }
    }
}