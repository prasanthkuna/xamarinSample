using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TodoApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    var todo = new List<Todo>
        //    {
        //        new Todo{Id = 1 , Title = "core app" , IsDone = false , UpdatedAt = DateTime.UtcNow},
        //         new Todo{Id = 2 , Title = "xamarin app" , IsDone = false , UpdatedAt = DateTime.UtcNow},
        //          new Todo{Id = 3 , Title = "upload to git" , IsDone = false , UpdatedAt = DateTime.UtcNow}
        //    };
        //    TodoesListView.ItemsSource = todo;
        //}
    }
}
