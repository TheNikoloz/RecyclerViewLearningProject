package md598562373e179c48709c348ec305221ff;


public class HalfLeftCoordinatorLayout
	extends com.xenione.libs.swipemaker.AbsCoordinatorLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_doInitialViewsLocation:()V:GetDoInitialViewsLocationHandler\n" +
			"n_onTranslateChange:(FIF)V:GetOnTranslateChange_FIFHandler\n" +
			"";
		mono.android.Runtime.register ("RecyclerViewX.HalfLeftCoordinatorLayout, RecyclerViewX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HalfLeftCoordinatorLayout.class, __md_methods);
	}


	public HalfLeftCoordinatorLayout (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == HalfLeftCoordinatorLayout.class)
			mono.android.TypeManager.Activate ("RecyclerViewX.HalfLeftCoordinatorLayout, RecyclerViewX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public HalfLeftCoordinatorLayout (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == HalfLeftCoordinatorLayout.class)
			mono.android.TypeManager.Activate ("RecyclerViewX.HalfLeftCoordinatorLayout, RecyclerViewX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public HalfLeftCoordinatorLayout (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == HalfLeftCoordinatorLayout.class)
			mono.android.TypeManager.Activate ("RecyclerViewX.HalfLeftCoordinatorLayout, RecyclerViewX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public HalfLeftCoordinatorLayout (android.content.Context p0)
	{
		super (p0);
		if (getClass () == HalfLeftCoordinatorLayout.class)
			mono.android.TypeManager.Activate ("RecyclerViewX.HalfLeftCoordinatorLayout, RecyclerViewX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void doInitialViewsLocation ()
	{
		n_doInitialViewsLocation ();
	}

	private native void n_doInitialViewsLocation ();


	public void onTranslateChange (float p0, int p1, float p2)
	{
		n_onTranslateChange (p0, p1, p2);
	}

	private native void n_onTranslateChange (float p0, int p1, float p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
