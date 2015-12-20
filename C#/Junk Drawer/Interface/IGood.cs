using JunkDrawerModel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Junk_Drawer.Interface
{
    interface IGood
    {

        ICollectionView GoodIdeas
        {
            get;
        }

        IGoodIdea CurrentIdea
        {
            get;
            set;
        }

        ICommand VoteUpCommand
        {
            get;
        }

        ICommand VoteDownCommand
        {
            get;
        }
    }
}
