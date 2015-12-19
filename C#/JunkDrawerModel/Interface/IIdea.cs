using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkDrawerModel.Interface
{
    public interface IIdea
    {
        string IdeaName
        {
            get;
            set;
        }

        DateTime Expiration
        {
            get;
            set;
        }

        int ID
        {
            get;
            set;
        }

        string Category
        {
            get;
            set;
        }

        string Author
        {
            get;
            set;
        }

        int VoteCount
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        int IsPermanent
        {
            get;
            set;
        }
    }
}
