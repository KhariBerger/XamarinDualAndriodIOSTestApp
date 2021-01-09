using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Plugin.Toast;
using System.Collections.ObjectModel;
using Test1.Models;
using System.Collections.Specialized;

namespace Test1.ViewModels
{
    public class PostViewModel : ObservableCollection<Post>
    {
        public ObservableCollection<Post> Posts { get; set; }
        int count = 0;

        public PostViewModel()
        {
            Title = "Whats New!";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
            Kaboom = new Command(async () => CrossToastPopUp.Current.ShowToastMessage("Kaboom!"));
            Posts = new ObservableCollection<Post>();
            //Add a test post
            Posts.Add(GeneratePost());
            Posts.Add(GeneratePost());
            Posts.Add(GeneratePost());
            Posts.Add(GeneratePost());
            Posts.Add(GeneratePost());
            Posts.Add(GeneratePost());
            Posts.Add(GeneratePost());
        }

        public string Title { get; }
        public ICommand OpenWebCommand { get; }

        public ICommand Kaboom { get; }

        //Used to create a test post
        public Post GeneratePost()
        {
            Post p = new Post(++count, "Test Title", "Testing the content of the this content test which is a test that I am testing which is also content for this tested message", "Kaboom", "0");

            return p;
        }
    }
}