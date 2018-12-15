using mvvm_part2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace mvvm_part2.ViewModels
{
    public class RoomsViewModel : INotifyPropertyChanged
    {
        public ICommand CreateRoomCommand { protected set; get; }       
        public ObservableCollection<RoomsViewModel> RoomsCollection { get; set; }
        public Room CurrentRoom { get; private set; }      

        public RoomsViewModel()
        {
            RoomsCollection = new ObservableCollection<RoomsViewModel>();
            CreateRoomCommand = new Command(CreateRoom);            
            CurrentRoom = new Room();   
        }
        private void CreateRoom(object romObject)
        {
            if (romObject != null)
            {
                RoomsViewModel room = romObject as RoomsViewModel;
                if (room != null)
                {
                    RoomsCollection.Add(room);
                }                
            }
        }
        

        public int Number
        {
            get { return CurrentRoom.Number; }
            set
            {
                if (CurrentRoom.Number != value)
                {
                    CurrentRoom.Number = value;
                    OnPropertyChanged("Number");
                }
            }
        }
        public int FreePlace
        {
            get { return CurrentRoom.FreePlace; }
            set
            {
                if (CurrentRoom.FreePlace != value)
                {
                    CurrentRoom.FreePlace = value;
                    OnPropertyChanged("FreePlace");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
