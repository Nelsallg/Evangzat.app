using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Evangzat
{
    public class MainPageCS : TabbedPage

    {
        public MainPageCS()
        {
            Children.Add(new HomePageCS()); 
            Children.Add(new FavoriesCS());
            Children.Add(new CathegoriesCS());
            Children.Add(new Notifications());
            Children.Add(new CompteCS());
        }
    }
   
    
}