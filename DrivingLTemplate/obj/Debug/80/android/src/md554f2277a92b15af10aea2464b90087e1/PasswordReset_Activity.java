package md554f2277a92b15af10aea2464b90087e1;


public class PasswordReset_Activity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("DrivingLTemplate.Activities.PasswordReset_Activity, DrivingLTemplate", PasswordReset_Activity.class, __md_methods);
	}


	public PasswordReset_Activity ()
	{
		super ();
		if (getClass () == PasswordReset_Activity.class)
			mono.android.TypeManager.Activate ("DrivingLTemplate.Activities.PasswordReset_Activity, DrivingLTemplate", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
