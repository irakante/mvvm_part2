using mvvm_part2.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace mvvm_part2.ViewModels
{
    public class RoomsViewModel : INotifyPropertyChanged
    {
        public ICommand CreateRoomCommand { set; get; }

        private int _number;
        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        private int _freePlace;
        public int FreePlace
        {
            get => _freePlace;
            set
            {
                _freePlace = value;
                OnPropertyChanged(nameof(FreePlace));
            }
        }

        private ObservableCollection<Room> _rooms;
        public ObservableCollection<Room> Rooms
        {
            get => _rooms;
            set
            {
                _rooms = value;
                OnPropertyChanged(nameof(Rooms));
            }
        }

        public RoomsViewModel()
        {
            Rooms = new ObservableCollection<Room>();
            CreateRoomCommand = new Command(CreateRoom);            
        }

        private void CreateRoom()
        {
            var room = new Room
            {
                Number = this.Number,
                FreePlace = this.FreePlace
            };

            Rooms.Add(room);
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        #endregion
    }
}
