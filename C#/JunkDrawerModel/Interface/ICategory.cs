using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkDrawerModel.Interface
{
    public interface ICategory
    {
        string CategoryName
        {
            get;
            set;
        }

        int CategoryID
        {
            get;
            set;
        }

    }
}
