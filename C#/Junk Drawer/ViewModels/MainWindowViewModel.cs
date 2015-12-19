using Junk_Drawer.Commands;
using Junk_Drawer.Interface;
using Junk_Drawer.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Junk_Drawer.ViewModels
{
    public class MainWindowViewModel : Notifiable, IMainWindowViewModel
    {
        private bool _isLoggedIn = false;
        private bool _isAnonymous;
        private string _email = "";
        private Command _loginCommand;

        private Command _createCommand;

        public MainWindowViewModel() 
        {

            _loginCommand = new Command(ExecuteLoginCommand, CanExecuteLoginCommand);
            _createCommand = new Command(ExecuteCreateCommand, CanExecuteCreateCommand);
            
        }

        private void ExecuteCreateCommand(object obj)
        {
            SubmitIdea submit = new SubmitIdea();
            submit.Initialize(_email);
            submit.ShowDialog();
        }

        private bool CanExecuteCreateCommand(object obj)
        {
            return _isLoggedIn;
        }

        private void ExecuteLoginCommand(object obj)
        {
             IsLoggedIn = true;
             if(_isAnonymous){
                 _email = "Anonymous";
             }
             _createCommand.OnCanExecuteChanged();

        }
        private bool CanExecuteLoginCommand(object obj)
        {
            if (_isAnonymous)
            {
                return true;
            }
            else
            {
                return _email.Length > 0;
            }
        }


        public bool IsAnonymous
        {
            get { return _isAnonymous; }
            set { 
                _isAnonymous = value;
                NotifyPropertyChanged("IsAnonymous");
                _loginCommand.OnCanExecuteChanged();
            }
        }

        public string EmailAddress
        {
            get { return _email; }
            set { 
                _email = value;
                NotifyPropertyChanged("EmailAddress");
                _loginCommand.OnCanExecuteChanged();
            }
        }

        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set 
            { 
                _isLoggedIn = value;
                NotifyPropertyChanged("IsLoggedIn");
            }
        }

        public ICommand LogInCommand
        {
            get { return _loginCommand; }
        }

        public ICommand CreateCommand
        {
            get { return _createCommand; }
        }

    }
}
