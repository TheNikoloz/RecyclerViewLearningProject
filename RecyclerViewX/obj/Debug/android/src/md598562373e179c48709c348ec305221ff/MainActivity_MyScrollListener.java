package md598562373e179c48709c348ec305221ff;


public class MainActivity_MyScrollListener
	extends android.support.v7.widget.RecyclerView.OnScrollListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScrolled:(Landroid/support/v7/widget/RecyclerView;II)V:GetOnScrolled_Landroid_support_v7_widget_RecyclerView_IIHandler\n" +
			"";
		mono.android.Runtime.register ("RecyclerViewX.MainActivity+MyScrollListener, RecyclerViewX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_MyScrollListener.class, __md_methods);
	}


	public MainActivity_MyScrollListener ()
	{
		super ();
		if (getClass () == MainActivity_MyScrollListener.class)
			mono.android.TypeManager.Activate ("RecyclerViewX.MainActivity+MyScrollListener, RecyclerViewX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MainActivity_MyScrollListener (android.support.design.widget.FloatingActionButton p0)
	{
		super ();
		if (getClass () == MainActivity_MyScrollListener.class)
			mono.android.TypeManager.Activate ("RecyclerViewX.MainActivity+MyScrollListener, RecyclerViewX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Support.Design.Widget.FloatingActionButton, Xamarin.Android.Support.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onScrolled (android.support.v7.widget.RecyclerView p0, int p1, int p2)
	{
		n_onScrolled (p0, p1, p2);
	}

	private native void n_onScrolled (android.support.v7.widget.RecyclerView p0, int p1, int p2);

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
