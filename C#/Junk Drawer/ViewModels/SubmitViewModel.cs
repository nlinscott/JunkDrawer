using Junk_Drawer.Commands;
using Junk_Drawer.Interface;
using JunkDrawerModel.Database;
using JunkDrawerModel.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Junk_Drawer.ViewModels
{
    public class SubmitViewModel : Notifiable, ISubmit
    {
        private Command _submitCommand;
        private string _ideaName;
        private string _description;
        private string _who;
        private ICategory _category;

        private IEnumerable<ICategory> _categories;

        public SubmitViewModel(string who)
        {
            _who = who;

            GetCategories();
        }

        private void GetCategories()
        {
            APIHandler handler = new APIHandler();
            _categories = handler.GetAllCategories();
        }

        public void TrySubmit(Action<bool> action)
        {
            APIHandler handler = new APIHandler();

            if (IsStringValid(_who) && IsStringValid(_ideaName) && IsStringValid(_description))
            {

                bool result = handler.CreateItem(_who, _ideaName, _description, _category.CategoryID);

                action(true);
                return;
            }

            action(false);


        }

        private bool IsStringValid(string str)
        {
            if(str == null){
                return false;   
            }
            return !str.Equals(string.Empty);
        }

        public string Who
        {
            get
            {
                return _who;
            }
        }

        public ICategory Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                NotifyPropertyChanged("Category");
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                NotifyPropertyChanged("Description");
            }
        }

        public IEnumerable<ICategory> Categories
        {
            get { return _categories; }
        }

        public string IdeaName
        {
            get
            {
                return _ideaName;
            }
            set
            {
                _ideaName = value;
                NotifyPropertyChanged("IdeaName");
            }
        }
    }
}
