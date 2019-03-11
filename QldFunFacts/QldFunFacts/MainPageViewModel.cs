using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MLToolkit.Forms.SwipeCardView.Core;
using System.Diagnostics;
using Xamarin.Forms;

namespace QldFunFacts
{
    public class MainPageViewModel : BaseViewModel
    {

        private ObservableCollection<string> _cardItems;
        public ObservableCollection<string> CardItems
        {
            get  => _cardItems;
            set
            {
                _cardItems = value;
                RaisePropertyChanged();
            }
        }

        public ICommand AddItemsCommand { get; set; }
        public ICommand SwipedCommand { get; set; }
        public ICommand ClearItemsCommand { get; }

        public MainPageViewModel()
        {
            _cardItems = new ObservableCollection<string>();
                for (var i = 1; i <= 5; i++)
            {
                _cardItems.Add($"Card {i}");
            }

          SwipedCommand = new Command<SwipedCardEventArgs>(OnSwipedCommand);
          AddItemsCommand = new Command(OnAddItemsCommand);
         // this.ClearItemsCommand = new Command(this.OnClearItemsCommand);

        }

        
        private void OnSwipedCommand(SwipedCardEventArgs eventArgs)
        {
            var item = eventArgs.Item as string;
        }


        private void OnAddItemsCommand()
        {
            for (var i = 1; i <= 5; i++)
            {
                CardItems.Add($"Card {i}");
            }
        }

       //private void OnClearItemsCommand()
       //{
       //}
    }
}
