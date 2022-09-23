using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using ToDo.Models;
using Xamarin.Forms;

namespace ToDo.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        string newToDo;
        private ObservableCollection<string> toDoItems = new ObservableCollection<string>
        {
            "Item 1",
            "Item 2"
        };

        public event PropertyChangedEventHandler PropertyChanged;
        public string NewToDo
        {
            get
            {
                return newToDo;
            }
            set
            {
                newToDo = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(NewToDo)));
            }
        }

        public string NewToDoPlaceHolder
        {
            get
            {
                return "Insert new item...";
            }
        }

        public ObservableCollection<string> ToDoItems
        {
            get
            {
                return toDoItems;
            }
            set
            {
                toDoItems = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ToDoItems)));
            }
        }

        public ICommand CreateNewItemCommand => new Command(CreateNewItem);
        private void CreateNewItem(object a)
        {
            ToDoItems.Add(newToDo);
            //PropertyChanged(this, new PropertyChangedEventArgs(nameof(ToDoItems)));
            NewToDo = null;
        }

    }
}
