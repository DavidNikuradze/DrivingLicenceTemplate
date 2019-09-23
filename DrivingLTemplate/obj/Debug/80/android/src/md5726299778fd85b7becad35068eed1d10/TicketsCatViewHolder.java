package md5726299778fd85b7becad35068eed1d10;


public class TicketsCatViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DrivingLTemplate.ViewHolder.TicketsCatViewHolder, DrivingLTemplate", TicketsCatViewHolder.class, __md_methods);
	}


	public TicketsCatViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == TicketsCatViewHolder.class)
			mono.android.TypeManager.Activate ("DrivingLTemplate.ViewHolder.TicketsCatViewHolder, DrivingLTemplate", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
