using ERP.Api;
using ERP.Models;
using ERP.Models.ApiRequests;
using ERP.Utils;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ERP.ViewModels
{
    class LoginViewModel : ViewModelBase
    {

        private CommandBase _loginCommand;

        public ICommand LoginCommand => _loginCommand;

        private string _username;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                NotifyPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                NotifyPropertyChanged();
            }
        }

        private bool _isLogging = false;
        public bool IsLogging
        {
            get => _isLogging;
            set
            {
                _isLogging = value;
                NotifyPropertyChanged();
            }
        }

        private bool _error = false;
        public bool Error
        {
            get => _error;
            set
            {
                _error = value;
                NotifyPropertyChanged();
            }
        }

        public delegate void NavigateToMainPage();

        public NavigateToMainPage Nav { get; set; }

        private ERPApi _api = new ERPApi();

        public LoginViewModel()
        {
            _loginCommand = new CommandBase((param) => !string.IsNullOrEmpty(_username) && !string.IsNullOrEmpty(_password) && !_isLogging, Login);
        }

        private async void Login(object param)
        {
            IsLogging = true;
            var userpass = new UsernameAndPasswordRequest(_username, _password);
            try
            {
                var resp = await _api.Login(userpass);
                if(resp == null || !resp.IsLogged)
                {
                    Error = true;
                    return;
                }

                Nav();
            }
            catch(Exception e)
            {
                Error = true;
            }
            finally
            {
                IsLogging = false;
            }
        }
    }
}
