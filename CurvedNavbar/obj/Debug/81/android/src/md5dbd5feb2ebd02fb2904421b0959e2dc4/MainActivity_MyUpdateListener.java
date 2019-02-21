package md5dbd5feb2ebd02fb2904421b0959e2dc4;


public class MainActivity_MyUpdateListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.animation.ValueAnimator.AnimatorUpdateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnimationUpdate:(Landroid/animation/ValueAnimator;)V:GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler:Android.Animation.ValueAnimator/IAnimatorUpdateListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("CurvedNavbar.MainActivity+MyUpdateListener, CurvedNavbar", MainActivity_MyUpdateListener.class, __md_methods);
	}


	public MainActivity_MyUpdateListener ()
	{
		super ();
		if (getClass () == MainActivity_MyUpdateListener.class)
			mono.android.TypeManager.Activate ("CurvedNavbar.MainActivity+MyUpdateListener, CurvedNavbar", "", this, new java.lang.Object[] {  });
	}

	public MainActivity_MyUpdateListener (md5dbd5feb2ebd02fb2904421b0959e2dc4.MainActivity p0, com.sdsmdg.harjot.vectormaster.VectorMasterView p1)
	{
		super ();
		if (getClass () == MainActivity_MyUpdateListener.class)
			mono.android.TypeManager.Activate ("CurvedNavbar.MainActivity+MyUpdateListener, CurvedNavbar", "CurvedNavbar.MainActivity, CurvedNavbar:Com.Sdsmdg.Harjot.Vectormaster.VectorMasterView, XamarinVectorMaster", this, new java.lang.Object[] { p0, p1 });
	}


	public void onAnimationUpdate (android.animation.ValueAnimator p0)
	{
		n_onAnimationUpdate (p0);
	}

	private native void n_onAnimationUpdate (android.animation.ValueAnimator p0);

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
