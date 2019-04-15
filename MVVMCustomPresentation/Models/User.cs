using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCustomPresentation.Models
{
    class User : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private Guid id;
        private string firstname;
        private string lastname;
        private string username;
        private List<Board> boards;

        public Guid Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                OnPropertyChanged("Firstname");
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                OnPropertyChanged("Lastname");
            }
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        } 

        public List<Board> Boards
        {
            get { return boards; }
            set
            {
                boards = value;
                OnPropertyChanged("Boards");
            }
        }


        private void OnPropertyChanged(string propertyChanged)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
        }

    }
}
