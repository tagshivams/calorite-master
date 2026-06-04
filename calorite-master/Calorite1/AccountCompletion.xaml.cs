using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Calorite1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AccountCompletion : Page
    {
        public AccountCompletion()
        {
            this.InitializeComponent();
            textBlock3.Text = Parameter.c.ToString();
            creator();
            
        }
        public async void creator()
        {
            User u = new User {
                WeightGoal = UserStatic.WeightGoalRate,
                WeightGoalRate = UserStatic.WeightGoalRate,
                ActivityType = UserStatic.ActivityType,
                height = UserStatic.height,
                cweight = UserStatic.cweight,
                gweight = UserStatic.gweight,
                age = UserStatic.age
            };
            int cweight = UserStatic.cweight;
            int gweight = UserStatic.gweight;

            String diff;
            //await App.MobileService.GetTable<User>().InsertAsync(u);

            if (cweight > gweight)
            { 
            diff= (cweight - gweight).ToString();

            } else
            {
                diff = (gweight - cweight).ToString();
            }

            //textBlock5.Text = diff + " kg ";
            String grate=null;

            if ((UserStatic.WeightGoalRate).Equals("Lose 0.25 kg per week"))
            {
                grate = ((cweight - gweight) / .25).ToString();
            }
            else if ((UserStatic.WeightGoalRate).Equals("Lose 0.5 kg per week"))
            {
                grate = ((cweight - gweight) / .5).ToString();
            }
            else if ((UserStatic.WeightGoalRate).Equals("Lose 0.75 kg per week"))
            {
                grate = ((cweight - gweight) / .75).ToString();
            }
            else if((UserStatic.WeightGoalRate).Equals("Lose 0.75 kg per week"))
            {
                grate = (cweight - gweight).ToString();
            }

            //textBlock6.Text =grate  + " weeks. ";



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }
        
    }
}
