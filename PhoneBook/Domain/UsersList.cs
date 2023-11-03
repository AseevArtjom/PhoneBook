using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain
{
    public class UsersList : INotifyPropertyChanged
    {
        public List<User>? users = null;
        public User selectedUser;

        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("User");
            }
        }

        public UsersList()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users?.Add(user);
        }
        public void RemoveUser(User user)
        {
            users?.Remove(user);
        }
        public void RemoveAllUsers()
        {
            users?.Clear();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }
}
