using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Plugin.Toast;
using System.Collections.ObjectModel;
using Test1.Models;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace Test1.ViewModels
{
    public class PostViewModel : ObservableCollection<Post>
    {
        public ObservableCollection<Post> Posts { get; set; }
        int count = 0;

        public PostViewModel()
        {
            Title = "Whats New!";
            this.IsRefreshing = false;
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
            Kaboom = new Command(async () => await KaboomTask());
            RefreshCommand = new Command(async () => await refreshPost());
            Posts = new ObservableCollection<Post>();
            //Add a test post
            //Posts.Add(GeneratePost());
            //Posts.Add(GeneratePost());
            //Posts.Add(GeneratePost());
            //Posts.Add(GeneratePost());
            //Posts.Add(GeneratePost());
            //Posts.Add(GeneratePost());
            //Posts.Add(GeneratePost());
        }

        public string Title { get; }
        public ICommand OpenWebCommand { get; }
        public bool IsRefreshing { get; set;  }
        public ICommand RefreshCommand { get; }

        public ICommand Kaboom { get; }

        //Used to create a test post
        public Post GeneratePost()
        {
            Post p = new Post(++count, "Test Title", "Testing the content of the this content test which is a test that I am testing which is also content for this tested message", "Kaboom", "0");

            return p;
        }


        private async Task refreshPost()
        {
            IsRefreshing = true;
        }

        private async Task KaboomTask()
        {
            CrossToastPopUp.Current.ShowToastMessage("Kaboom!");
        }
    }
}