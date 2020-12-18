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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Hario.Shared.UserControls
{
    public sealed partial class HairStoryCard : UserControl
    {
        public HairStoryCard()
        {
            this.InitializeComponent();
        }

        public string StoreName     
        {
            get { return (string)GetValue(StoreNameProperty); }
            set { SetValue(StoreNameProperty, value); }
        }

        public static readonly DependencyProperty StoreNameProperty =
            DependencyProperty.Register("StoreName", typeof(string), typeof(HairStoryCard), null);


        public string StoreLogoUrl
        {
            get { return (string)GetValue(StoreLogoUrlProperty); }
            set { SetValue(StoreLogoUrlProperty, value); }
        }

        public static readonly DependencyProperty StoreLogoUrlProperty =
            DependencyProperty.Register("StoreLogoUrl", typeof(string), typeof(HairStoryCard), null);



        public string StoryUrl
        {
            get { return (string)GetValue(StoryUrlProperty); }
            set { SetValue(StoryUrlProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StoryUrl.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StoryUrlProperty =
            DependencyProperty.Register("StoryUrl", typeof(string), typeof(HairStoryCard), null);



        public string Service
        {
            get { return (string)GetValue(ServiceProperty); }
            set { SetValue(ServiceProperty, value); }
        }

        public static readonly DependencyProperty ServiceProperty =
            DependencyProperty.Register("Service", typeof(string), typeof(HairStoryCard), null);



        //public decimal ServicePrice
        //{
        //    get { return (decimal)GetValue(ServicePriceProperty); }
        //    set { SetValue(ServicePriceProperty, value); }
        //}

        //public static readonly DependencyProperty ServicePriceProperty =
        //    DependencyProperty.Register("ServicePrice", typeof(decimal), typeof(HairStoryCard), null);




    }
}
