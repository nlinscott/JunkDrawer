using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkDrawerModel.Interface
{
    public interface IGoodIdea
    {
        string Author
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        int ID
        {
            get;
            set;
        }

        int VoteCount
        {
            get;
            set;
        }

        string IdeaName
        {
            get;
            set;
        }

        string Links
        {
            get;
            set;
        }

        string Category
        {
            get;
            set;
        }
    }
}
