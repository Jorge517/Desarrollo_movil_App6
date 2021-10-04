using App_6.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_6.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _userName;
        private string _password;
        private Command _loginCommand;
        private bool isErrorLogin;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
            Navigation = navigation ?? App.Navigation;
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public Command LoginCommand
        {
            get => _loginCommand ?? (_loginCommand = new Command(GoToLoginAction));}
        public bool IsErrorLogin 
        {
            get => isErrorLogin;
            set
            {
                isErrorLogin = value;
                OnPropertyChanged();
            }
        }
        private void GoToLoginAction()
        {
            IsErrorLogin = !(UserName == "Jorge" && Password == "123");
            if(!IsErrorLogin)
            {
                UserName = String.Empty;
                Password = String.Empty;
                Navigation.PushAsync(new PageTwo());
            }
        }
    }
}
