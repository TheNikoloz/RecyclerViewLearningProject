using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Com.Xenione.Libs.Swipemaker;


namespace RecyclerViewX
{
    public class HalfLeftCoordinatorLayout : AbsCoordinatorLayout
    {
        private View _backView { get; set; }
        private SwipeLayout _frontView { get; set; }

        public HalfLeftCoordinatorLayout(Context context) : base(context) {}
        public HalfLeftCoordinatorLayout(Context context, IAttributeSet attrs) : base(context, attrs) { }
        public HalfLeftCoordinatorLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr) { }
        public HalfLeftCoordinatorLayout(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes) { }

        public override void DoInitialViewsLocation()
        {
            _backView = FindViewById<View>(Resource.Id.backgroundView);
            _frontView = FindViewById<SwipeLayout>(Resource.Id.foregroundView);
            _frontView.Anchor(Java.Lang.Integer.ValueOf(-_backView.Width), Java.Lang.Integer.ValueOf(0));
        }

        public override void OnTranslateChange(float p0, int p1, float p2) { }
    }
}

