using JunkDrawerModel.Interface;
using System.Collections.Generic;
using System.Windows.Input;

namespace Junk_Drawer.Interface
{
    interface ISubmit
    {

        string Who
        {
            get;
        }


        ICategory Category
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        string IdeaName
        {
            get;
            set;
        }

        IEnumerable<ICategory> Categories
        {
            get;
        }
    }
}
