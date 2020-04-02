using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TodoApp.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        
        private List<Todo> _todos;

        public List<Todo> Todos
        {
            get { return _todos; }
            set
            {
                _todos = value;
                OnPropertyChanged();


            }
        }
        public MainViewModel()
        {
            GetTodos();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));
        }

        private void GetTodos()
        {
            var todo = new List<Todo>
            {
                new Todo{Id = 1 , Title = "core app" , IsDone = false , UpdatedAt = DateTime.UtcNow},
                 new Todo{Id = 2 , Title = "xamarin app" , IsDone = false , UpdatedAt = DateTime.UtcNow},
                  new Todo{Id = 3 , Title = "upload to git" , IsDone = false , UpdatedAt = DateTime.UtcNow}
            };
            Todos = todo;
        }
    }
}
