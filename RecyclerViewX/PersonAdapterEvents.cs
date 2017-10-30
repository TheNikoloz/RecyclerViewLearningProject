using System;
using Android.Views;

namespace RecyclerViewX
{
    public partial class PersonAdapter
    {
        public class PersonClickEventArgs : PersonAdapterViewHolder.ClickEventArgs
        {
            public Person Person { get; set; }
        }

        public event EventHandler<PersonClickEventArgs> ProfilePictureClick;
        public event EventHandler<PersonClickEventArgs> ProfilePictureLongClick;
        public event EventHandler<PersonClickEventArgs> FullNameClick;
        public event EventHandler<PersonClickEventArgs> AgeClick;
        public event EventHandler<PersonClickEventArgs> EmailLongClick;
        public event EventHandler<PersonClickEventArgs> ButtonSendClick;
        public event EventHandler<PersonClickEventArgs> ButtonCallClick;

        protected virtual void OnProfilePictureClick(Object sender, PersonClickEventArgs e) => ProfilePictureClick?.Invoke(sender, e);
        protected virtual void OnProfilePictureLongClick(Object sender, PersonClickEventArgs e) => ProfilePictureLongClick?.Invoke(sender, e);
        protected virtual void OnFullNameClick(Object sender, PersonClickEventArgs e) => FullNameClick?.Invoke(sender, e);
        protected virtual void OnAgeClick(Object sender, PersonClickEventArgs e) => AgeClick?.Invoke(sender, e);
        protected virtual void OnEmailLongClick(Object sender, PersonClickEventArgs e) => EmailLongClick?.Invoke(sender, e);
        protected virtual void OnButtonSendClick(Object sender, PersonClickEventArgs e) => ButtonSendClick?.Invoke(sender, e);
        protected virtual void OnButtonCallClick(Object sender, PersonClickEventArgs e) => ButtonCallClick?.Invoke(sender, e);
    }
}