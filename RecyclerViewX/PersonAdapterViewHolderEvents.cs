using System;
using Android.Views;

namespace RecyclerViewX
{
    public partial class PersonAdapterViewHolder
    {
        public class ClickEventArgs : EventArgs
        {
            public View View { get; set; }
            public int Position { get; set; }
        }

        public event EventHandler<ClickEventArgs> ProfilePictureClick;
        public event EventHandler<ClickEventArgs> ProfilePictureLongClick;
        public event EventHandler<ClickEventArgs> FullNameClick;
        public event EventHandler<ClickEventArgs> AgeClick;
        public event EventHandler<ClickEventArgs> EmailLongClick;
        public event EventHandler<ClickEventArgs> ButtonSendClick;
        public event EventHandler<ClickEventArgs> ButtonCallClick;

        protected virtual void OnProfilePictureClick(Object sender, ClickEventArgs e) => ProfilePictureClick?.Invoke(sender, e);
        protected virtual void OnProfilePictureLongClick(Object sender, ClickEventArgs e) => ProfilePictureLongClick?.Invoke(sender, e);
        protected virtual void OnFullNameClick(Object sender, ClickEventArgs e) => FullNameClick?.Invoke(sender, e);
        protected virtual void OnAgeClick(Object sender, ClickEventArgs e) => AgeClick?.Invoke(sender, e);
        protected virtual void OnEmailLongClick(Object sender, ClickEventArgs e) => EmailLongClick?.Invoke(sender, e);
        protected virtual void OnButtonSendClick(Object sender, ClickEventArgs e) => ButtonSendClick?.Invoke(sender, e);
        protected virtual void OnButtonCallClick(Object sender, ClickEventArgs e) => ButtonCallClick?.Invoke(sender, e);
    }
}