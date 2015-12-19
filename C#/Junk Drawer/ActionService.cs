using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk_Drawer
{
    public class ActionService
    {
        private static ActionService _instance = null;

        private static readonly Dictionary<Type, Action> _actions = new Dictionary<Type, Action>();

        private ActionService()
        {
            
        }

        public static ActionService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ActionService();
            }
            return _instance;
        }

        public void RegisterAction(Action a, Type t)
        {
            _actions.Add(t, a);
        }

        public void PerformAction(Type type)
        {
            if(_actions.ContainsKey(type)){
                _actions[type]();
            }
        }

    }
}
