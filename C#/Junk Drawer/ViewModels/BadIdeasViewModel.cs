using Junk_Drawer.Commands;
using Junk_Drawer.Interface;
using JunkDrawerModel.Database;
using JunkDrawerModel.Interface;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;


namespace Junk_Drawer.ViewModels
{
    public class BadIdeasViewModel : Notifiable, IBad
    {
        private readonly ObservableCollection<IBadIdea> _ideaList = new ObservableCollection<IBadIdea>();

        private IBadIdea _currentIdea;
        private Command _voteUpCommand;
        private Command _voteDownCommand;
        private readonly APIHandler _handler = new APIHandler();
        private ICollectionView _collectionView;

        private int _votes;

        public BadIdeasViewModel()
        {
            ActionService service = ActionService.GetInstance();
            service.RegisterAction(() => {

                Initialize();

            }, this.GetType());

            _voteUpCommand = new Command(ExecuteVoteUpCommand);
            _voteDownCommand = new Command(ExecuteVoteDownCommand);

            Initialize();
        }

        private void Initialize()
        {
            _ideaList.Clear();

            IEnumerable<IBadIdea> ideas = _handler.GetBadIdeaList();
            foreach (IBadIdea idea in ideas)
            {
                _ideaList.Add(idea);
            }
            BadIdeas = CollectionViewSource.GetDefaultView(_ideaList);
        }

        private void ExecuteVoteUpCommand(object obj)
        {
            _handler.CastVote(CurrentIdea.ID, 1);

            Votes = Votes + 1;
            _currentIdea.VoteCount = Votes;

        }

        private void ExecuteVoteDownCommand(object obj)
        {
            _handler.CastVote(CurrentIdea.ID, -1);

            Votes = Votes - 1;
            _currentIdea.VoteCount = Votes;
        }

        public ICollectionView BadIdeas
        {
            get { return _collectionView; }
            set 
            {
                _collectionView = value;
                NotifyPropertyChanged("BadIdeas");
            }
        }

        public IBadIdea CurrentIdea
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
                }
            }
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
