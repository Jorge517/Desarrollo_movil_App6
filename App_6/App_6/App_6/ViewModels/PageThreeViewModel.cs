using App_6.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_6.ViewModels
{
    public class PageThreeViewModel : BaseViewModel
    {
        Command _pagtwo;

        public PageThreeViewModel(INavigation navigation = null) : base(navigation)
        {
        }
        public Command GoToTwoCommand { get => _pagtwo ?? (_pagtwo = new Command(GoToTwo)); }

        private void GoToTwo()
        {
            Navigation.PushAsync(new PageTwo());
        }
    }
}
