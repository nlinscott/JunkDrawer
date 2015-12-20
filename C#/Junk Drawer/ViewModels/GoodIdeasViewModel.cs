using Junk_Drawer.Commands;
using Junk_Drawer.Interface;
using JunkDrawerModel.Database;
using JunkDrawerModel.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using System.Linq;

namespace Junk_Drawer.ViewModels
{
    public class GoodIdeasViewModel : Notifiable, IGood
    {
        private ObservableCollection<IGoodIdea> _ideaList = new ObservableCollection<IGoodIdea>();
        private ICollectionView _goodIdeas;
        private IGoodIdea _currentIdea;
        private Command _voteUpCommand;
        private Command _voteDownCommand;
        private readonly APIHandler _handler = new APIHandler();
        private int _votes;

        private ICollectionView _linkedCollection;
        private ObservableCollection<IGoodIdea> _linkedIdeaList = new ObservableCollection<IGoodIdea>();


        public GoodIdeasViewModel()
        {
            ActionService service = ActionService.GetInstance();
            service.RegisterAction(() =>
            {

                Initialize();

            }, this.GetType());

            _voteUpCommand = new Command(ExecuteVoteUpCommand);
            _voteDownCommand = new Command(ExecuteVoteDownCommand);

            Initialize();
        }


        private void Initialize()
        {
            _ideaList.Clear();

            IEnumerable<IGoodIdea> ideas = _handler.GetGoodIdeaList();
            foreach (IGoodIdea idea in ideas)
            {
                _ideaList.Add(idea);
            }
            _ideaList.RemoveAt(1);
            GoodIdeas = CollectionViewSource.GetDefaultView(_ideaList);
        }

        private void ExecuteVoteUpCommand(object obj)
        {
            _handler.CastVote(CurrentIdea.ID, 1);

            Votes = Votes + 1;
            _currentIdea.VoteCount = Votes;

        }

        private void InitializeLinks(string links)
        {
            _linkedIdeaList.Clear();

            string[] strs = links.Split(' ');
            foreach (string str in strs)
            {
                int num = Convert.ToInt32(str);
                if (num != 0)
                {
                    _linkedIdeaList.Add( _handler.GetIdeaByID(num).First() );
                }
            }
            
            LinkedIdeas = CollectionViewSource.GetDefaultView(_linkedIdeaList);
        }


        private void ExecuteVoteDownCommand(object obj)
        {
            _handler.CastVote(CurrentIdea.ID, -1);

            Votes = Votes - 1;
            _currentIdea.VoteCount = Votes;
        }

        public int Votes
        {
            get { return _votes; }
            set 
            { 
                _votes = value;
                NotifyPropertyChanged("Votes");
            }
        }

        public ICollectionView LinkedIdeas
        {
            get { return _linkedCollection; }
            set 
            { 
                _linkedCollection = value;
                NotifyPropertyChanged("LinkedIdeas");
                
            }

        }


        public ICollectionView GoodIdeas
        {
            get { return _goodIdeas; }
            set 
            {
                _goodIdeas = value;
                NotifyPropertyChanged("GoodIdeas");
            }
        }

        public IGoodIdea CurrentIdea
        {
            get
            {
                return _currentIdea;
            }
            set
            {
                _currentIdea = value;
                if (_currentIdea != null)
                {
                    Votes = _currentIdea.VoteCount;
                    InitializeLinks(_currentIdea.Links);
                }
                NotifyPropertyChanged("CurrentItem");
            }
        }

        public ICommand VoteUpCommand
        {
            get { return _voteUpCommand; }

        }

        public ICommand VoteDownCommand
        {
            get { return _voteDownCommand; }
        }
    }
}
