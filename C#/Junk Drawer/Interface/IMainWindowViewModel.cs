using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Junk_Drawer.Interface
{
    interface IMainWindowViewModel
    {
        bool IsLoggedIn
        {
            get;
            set;
        }

        bool IsAnonymous
        {
            get;
            set;
        }

        string EmailAddress
        {
            get;
            set;
        }

        ICommand LogInCommand
        {
            get;
        }
    }
}
