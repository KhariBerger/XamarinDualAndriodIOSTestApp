using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test1.Models;
using Test1.ViewModels;
using SQLite;

namespace Test1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePostPage : ContentPage
    {
        internal int count = 0;
        public CreatePostPage()
        {
            InitializeComponent();
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                Post newPost = new Post(
                    ++count,
                    titleEntry.Text,
                    contentEntry.Text,
                    onClickEntry.Text,
                    webLinkEntry.Text
                    );

                //Connection is automatically disposed once out of the using statement
                using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                {
                    conn.CreateTable<Post>();
                    conn.Insert(newPost);
                    int rowsAdded = conn.Insert(newPost);
                }
                
            }
            catch(Exception ex)
            {

            }
        }
    }
}