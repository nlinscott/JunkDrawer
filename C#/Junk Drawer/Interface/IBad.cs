using JunkDrawerModel.Interface;
using System.ComponentModel;
using System.Windows.Input;

namespace Junk_Drawer.Interface
{
    interface IBad
    {
        ICollectionView BadIdeas
        {
            get;
        }

        IBadIdea CurrentIdea
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
