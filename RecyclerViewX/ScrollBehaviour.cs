using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;
using Android.Views.Animations;
using Android.Animation;
using Android.Support.V4.View;
using Android.Util;

namespace RecyclerViewX
{
    [Register("Cavea.FabHideScrollBehavior")]
    public class FabHideScrollBehavior : CoordinatorLayout.Behavior
    {

        const int Threshold = 30;
        float _prevScroll = default(float);
        bool _isFabVisible = false;
        float _scrollDistance = 0;
        bool _isSnackbar = false;
        public FabHideScrollBehavior(Context context, IAttributeSet attrSet) : base()
        {

        }
        public override bool OnStartNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, Android.Views.View directTargetChild,
                                                 Android.Views.View target, int nestedScrollAxes)
        {
            bool result = nestedScrollAxes == ViewCompat.ScrollAxisVertical;
            return result;
            ;//tu scroll aris vertikaluri
        }
        public override bool LayoutDependsOn(CoordinatorLayout parent, Java.Lang.Object child, View dependency)
        {
            if (dependency is RelativeLayout)
            {
                return true;
            }
            else if (dependency is Snackbar.SnackbarLayout)
            {
                _isSnackbar = true;
                return true;
            }
            _isSnackbar = false;
            return false;
        }
        private float getFabTranslationYForSnackbar(CoordinatorLayout parent,
                    FloatingActionButton fab)
        {
            float minOffset = 0;
            IList<View> dependencies = parent.GetDependencies(fab);
            for (int i = 0, z = dependencies.Count; i < z; i++)
            {
                View view = dependencies[i];
                if (view is Snackbar.SnackbarLayout && parent.DoViewsOverlap(fab, view))
                {
                    minOffset = Math.Min(minOffset,
                                         ViewCompat.GetTranslationY(view) - view.Height);
                }
            }
            return minOffset;
        }
        bool isSnackBarVisible(CoordinatorLayout parent, FloatingActionButton fab)
        {
            var dependencies = parent.GetDependencies(fab);
            for (int i = 0; i < dependencies.Count; i++)
            {
                View currView = dependencies[i];
                if (currView is Snackbar.SnackbarLayout)
                    return true;
            }
            return false;
        }
        public override bool OnDependentViewChanged(CoordinatorLayout parent, Java.Lang.Object child, View dependency)
        {
            var currFab = child.JavaCast<FloatingActionButton>();
            if (dependency is Snackbar.SnackbarLayout)
            {

                currFab.TranslationY = getFabTranslationYForSnackbar(parent, currFab);

                return false;
            }
            //scrolldistance deltebis jamia da vnaxulobt threshold (romelic aris konkretuli distanciis gavlis ricxvi)
            //ze metia mashin an chavides fab an avides - chasvla an asvlas akonrolebs _isFabVisible
            if (isSnackBarVisible(parent, currFab))
                return false;
            if (_scrollDistance > Threshold && !_isFabVisible)
            {
                toggleFab(currFab, false);
                _isFabVisible = true;
                _scrollDistance = 0;
            }
            else if (_scrollDistance < -Threshold && _isFabVisible)
            {
                toggleFab(currFab, true);
                _scrollDistance = 0;
                _isFabVisible = false;
            }
            //amat shoris sxvaoba yoveltvis 1 ia amitom vamatebt ertmanets
            float dy = dependency.GetY() - _prevScroll;
            //tu qvemot scrollavs delta yoveltvis iqneba uaryofiti
            //tu zemot scrollavs dadebiti
            if ((!_isFabVisible && dy > 0) || (_isFabVisible && dy < 0))
                _scrollDistance += dy;
            //bolo scroll is poziciis shenaxva
            _prevScroll = dependency.GetY();
            return base.OnDependentViewChanged(parent, child, dependency);
        }
        public override void OnDependentViewRemoved(CoordinatorLayout parent, Java.Lang.Object child, View dependency)
        {
            base.OnDependentViewRemoved(parent, child, dependency);
            if (dependency is Snackbar.SnackbarLayout)
            {
                var currFab = child.JavaCast<FloatingActionButton>();
                float translationY = Math.Min(0, parent.Bottom - currFab.Bottom);
                currFab.TranslationY = translationY;
            }
        }
        //bool _isFabVisibleSec = true;
        public override void OnNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, Android.Views.View target,
                                            int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
        {
            base.OnNestedScroll(coordinatorLayout, child, target, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed);
            if (_isSnackbar)
                return;
            var currFab = child.JavaCast<FloatingActionButton>();
            if (_scrollDistance > Threshold && !_isFabVisible)
            {
                toggleFab(currFab, false);
                _isFabVisible = true;
                _scrollDistance = 0;
            }
            else if (_scrollDistance < -Threshold && _isFabVisible)
            {
                toggleFab(currFab, true);
                _scrollDistance = 0;
                _isFabVisible = false;
            }
            //amat shoris sxvaoba yoveltvis 1 ia amitom vamatebt ertmanets
            float dy = -dyConsumed;
            //tu qvemot scrollavs delta yoveltvis iqneba uaryofiti
            //tu zemot scrollavs dadebiti
            if ((!_isFabVisible && dy > 0) || (_isFabVisible && dy < 0))
                _scrollDistance += dy;
            //bolo scroll is poziciis shenaxva
        }
        private class FabAnimationListener : Java.Lang.Object, Android.Animation.Animator.IAnimatorListener
        {
            FloatingActionButton _fab;
            bool _shouldHideInEnd = false;
            public FabAnimationListener(FloatingActionButton fab, bool shouldHide)
            {
                _fab = fab;
                _shouldHideInEnd = shouldHide;
            }
            public void OnAnimationCancel(Animator animation)
            {

            }
            public void OnAnimationEnd(Animator animation)
            {
                if (_shouldHideInEnd)
                {
                    if (_fab == null)
                        return;
                    if (_fab.Visibility == ViewStates.Visible)
                        _fab.Visibility = ViewStates.Invisible;
                }
            }
            public void OnAnimationRepeat(Animator animation)
            {

            }
            public void OnAnimationStart(Animator animation)
            {
                if (_fab == null)
                    return;
                if (_fab.Visibility == ViewStates.Invisible)
                    _fab.Visibility = ViewStates.Visible;
            }
        }
        void toggleFab(FloatingActionButton currFab, bool shouldHide)
        {
            if (shouldHide)
            {
                CoordinatorLayout.LayoutParams layoutParams = currFab.LayoutParameters as CoordinatorLayout.LayoutParams;
                int margin = layoutParams.BottomMargin;
                var animation = currFab.Animate().TranslationY(currFab.Height + margin).SetInterpolator(new AccelerateInterpolator(1.5f)).SetDuration(300);
                animation.Start();
                animation.SetListener(new FabAnimationListener(currFab, true));
                return;
            }
            var anim = currFab.Animate().TranslationY(0).SetInterpolator(new DecelerateInterpolator(1.5f)).SetDuration(300);
            anim.Start();
            anim.SetListener(new FabAnimationListener(currFab, false));
        }
    }
}