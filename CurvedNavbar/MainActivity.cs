using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using CurvedNavbar.Logic;
using Com.Sdsmdg.Harjot.Vectormaster;
using Com.Sdsmdg.Harjot.Vectormaster.Models;
using Android.Animation;
using static Android.Support.Design.Widget.BottomNavigationView;
using Android.Views;
using System;
using Android.Graphics;
using static Android.Views.ViewGroup;
using Android.Views.Animations;
using System.Threading;

namespace CurvedNavbar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnNavigationItemSelectedListener
    {
        private CurvedBottomNavigationView bottom_nav;
        private VectorMasterView fab, fab1, fab2;
        private RelativeLayout lin_id;

        //public override bool OnCreateOptionsMenu(IMenu menu)
        //{
        //    //MenuInflater.Inflate(Resource.Menu.main_menu, menu);
        //    //if (menu != null)
        //    //{
        //    //    var itemsCount = menu.Size();
        //    //    for(var i = 0; i < itemsCount; i++)
        //    //    {
        //    //        var item = menu.GetItem(i);
        //    //    }
        //    //}
        //    return base.OnCreateOptionsMenu(menu);
        //}
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.action_cart:
                    Draw(6);
                    lin_id.SetX(bottom_nav.mFirstCurveControlPoint1.X);
                    fab.Visibility = ViewStates.Visible;
                    fab1.Visibility = ViewStates.Gone;
                    fab2.Visibility = ViewStates.Gone;
                    SelectAnimation(lin_id);
                    break;
                case Resource.Id.action_list:
                    Draw(2);
                    lin_id.SetX(bottom_nav.mFirstCurveControlPoint1.X);
                    fab.Visibility = ViewStates.Gone;
                    fab1.Visibility = ViewStates.Visible;
                    fab2.Visibility = ViewStates.Gone;
                    SelectAnimation(lin_id);
                    break;
                case Resource.Id.action_customer:
                    Draw();
                    lin_id.SetX(bottom_nav.mFirstCurveControlPoint1.X);
                    fab.Visibility = ViewStates.Gone;
                    fab1.Visibility = ViewStates.Gone;
                    fab2.Visibility = ViewStates.Visible;
                    SelectAnimation(lin_id);
                    break;
            }
            return true;
        }

        private void Draw()
        {
            bottom_nav.mFirstCurveStartPoint.Set(bottom_nav.mNavigationWidth * 10 / 12
                - bottom_nav.CURVE_CIRCLE_RADIUS * 2 - bottom_nav.CURVE_CIRCLE_RADIUS / 3, 0);
            bottom_nav.mFirstCurveEndPoint.Set(bottom_nav.mNavigationWidth * 10 / 12,
                bottom_nav.CURVE_CIRCLE_RADIUS + bottom_nav.CURVE_CIRCLE_RADIUS / 4);

            //samething for second curve
            bottom_nav.mSecondCurveStartPoint = bottom_nav.mFirstCurveEndPoint;
            bottom_nav.mSecondCurveEndPoint.Set(bottom_nav.mNavigationWidth * 10 / 12
                + bottom_nav.CURVE_CIRCLE_RADIUS * 2
                + bottom_nav.CURVE_CIRCLE_RADIUS / 3, 0);

            //The coordinates of 1st control point on a cubic curve
            bottom_nav.mFirstCurveControlPoint1.Set(bottom_nav.mFirstCurveStartPoint.X
                + bottom_nav.CURVE_CIRCLE_RADIUS
                + bottom_nav.CURVE_CIRCLE_RADIUS / 4,
                bottom_nav.mFirstCurveStartPoint.Y);
            bottom_nav.mFirstCurveControlPoint2.Set(bottom_nav.mFirstCurveEndPoint.X
                - bottom_nav.CURVE_CIRCLE_RADIUS * 2 + bottom_nav.CURVE_CIRCLE_RADIUS,
                bottom_nav.mFirstCurveEndPoint.Y);

            //Same with second
            bottom_nav.mSecondCurveControlPoint1.Set(bottom_nav.mSecondCurveStartPoint.X
                + bottom_nav.CURVE_CIRCLE_RADIUS * 2 - bottom_nav.CURVE_CIRCLE_RADIUS,
                bottom_nav.mSecondCurveStartPoint.Y);
            bottom_nav.mSecondCurveControlPoint2.Set(bottom_nav.mSecondCurveEndPoint.X
                - bottom_nav.CURVE_CIRCLE_RADIUS + bottom_nav.CURVE_CIRCLE_RADIUS / 4,
                bottom_nav.mSecondCurveEndPoint.Y);
        }
        

        private void SelectAnimation(RelativeLayout icon)
        {
            TranslateAnimation tAnim = new TranslateAnimation(0, 0, 150, 0);
            tAnim.Duration = 200;
            tAnim.Interpolator = new LinearInterpolator();
            icon.StartAnimation(tAnim);
        }

        private void Draw(int i)
        {
            #region 1
            
            //دکمه تب (دایره)
            bottom_nav.mFirstCurveStartPoint.Set(bottom_nav.mNavigationWidth / i
                - bottom_nav.CURVE_CIRCLE_RADIUS * 2 - bottom_nav.CURVE_CIRCLE_RADIUS / 45, 0);
            //منحنی تب بار وقتی انتخاب میشه
            bottom_nav.mFirstCurveEndPoint.Set(bottom_nav.mNavigationWidth / i + 10,
                bottom_nav.CURVE_CIRCLE_RADIUS + bottom_nav.CURVE_CIRCLE_RADIUS / 4);
            #endregion

            //samething for second curve
            bottom_nav.mSecondCurveStartPoint = bottom_nav.mFirstCurveEndPoint;
            bottom_nav.mSecondCurveEndPoint.Set(bottom_nav.mNavigationWidth / i
                + bottom_nav.CURVE_CIRCLE_RADIUS * 2
                + bottom_nav.CURVE_CIRCLE_RADIUS / 3, 0);

            //The coordinates of 1st control point on a cubic curve
            bottom_nav.mFirstCurveControlPoint1.Set(bottom_nav.mFirstCurveStartPoint.X
                + bottom_nav.CURVE_CIRCLE_RADIUS
                + bottom_nav.CURVE_CIRCLE_RADIUS / 4,
                bottom_nav.mFirstCurveStartPoint.Y);
            bottom_nav.mFirstCurveControlPoint2.Set(bottom_nav.mFirstCurveEndPoint.X
                - bottom_nav.CURVE_CIRCLE_RADIUS * 2 + bottom_nav.CURVE_CIRCLE_RADIUS,
                bottom_nav.mFirstCurveEndPoint.Y);

            //Same with second
            bottom_nav.mSecondCurveControlPoint1.Set(bottom_nav.mSecondCurveStartPoint.X
                + bottom_nav.CURVE_CIRCLE_RADIUS * 2 - bottom_nav.CURVE_CIRCLE_RADIUS,
                bottom_nav.mSecondCurveStartPoint.Y);
            bottom_nav.mSecondCurveControlPoint2.Set(bottom_nav.mSecondCurveEndPoint.X
                - bottom_nav.CURVE_CIRCLE_RADIUS + bottom_nav.CURVE_CIRCLE_RADIUS / 4,
                bottom_nav.mSecondCurveEndPoint.Y);
            

        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            bottom_nav = FindViewById<CurvedBottomNavigationView>(Resource.Id.bottom_navigation_bar);


            fab = FindViewById<VectorMasterView>(Resource.Id.fab);
            fab1 = FindViewById<VectorMasterView>(Resource.Id.fab1);
            fab2 = FindViewById<VectorMasterView>(Resource.Id.fab2);

            lin_id = FindViewById<RelativeLayout>(Resource.Id.line_id);

            bottom_nav.InflateMenu(Resource.Menu.main_menu);
            bottom_nav.SelectedItemId = Resource.Id.action_list;

            bottom_nav.SetOnNavigationItemSelectedListener(this);
            
        }
        
    }
}