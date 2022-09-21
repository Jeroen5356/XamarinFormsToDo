using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using ToDo.Models;
using Xamarin.Forms;

namespace ToDo.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        string newToDo;
        private List<string> toDoItems = new List<string>
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

        public List<string> ToDoItems
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
            //werkt nog niet helemaal.
            var newList = ToDoItems;
            newList.Add(newToDo);
            ToDoItems = newList;
            NewToDo = null;
        }

    }
}
