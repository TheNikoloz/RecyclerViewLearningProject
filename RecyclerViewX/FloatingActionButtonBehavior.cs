//using Android.Runtime;
//using Android.Support.Design.Widget;
//using Android.Support.V4.View;
//using Android.Util;
//using Android.Views;
//using System.Runtime.Remoting.Contexts;

//public class ScrollAwareFABBehavior : CoordinatorLayout.Behavior
//{
//    public ScrollAwareFABBehavior(Context context, IAttributeSet attrs) : base()
//    {
//    }

//    public override bool OnStartNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child,
//        Android.Views.View directTargetChild, Android.Views.View target, int nestedScrollAxes)
//    {
//        return nestedScrollAxes == ViewCompat.ScrollAxisVertical ||
//            base.OnStartNestedScroll(coordinatorLayout, child, directTargetChild, target,
//                nestedScrollAxes);
//    }

//    public override void OnNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child,
//        Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
//    {
//        base.OnNestedScroll(coordinatorLayout, child, target, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed);

//        var fab = child.JavaCast<FloatingActionButton>();

//        if (dyUnconsumed > 0 && fab.Visibility == ViewStates.Visible)
//        {
//            fab.Hide();
//        }
//        else if (dyUnconsumed < 0 && fab.Visibility != ViewStates.Visible)
//        {
//            fab.Show();
//        }
//    }
//}