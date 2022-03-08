﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    [Activity(Label = "Splashscreen",MainLauncher =true,Theme ="@style/MyTheme.Splash", NoHistory = true  )]
    public class Splashscreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        protected override async void OnResume()
        {
            base.OnResume();
            await SimulateStartup();
                    
        }
       
        
async Task SimulateStartup()

            {
            await Task.Delay(TimeSpan.FromSeconds(2));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    
    }

}