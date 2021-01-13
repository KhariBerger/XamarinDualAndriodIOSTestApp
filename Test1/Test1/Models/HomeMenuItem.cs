using System;
using System.Collections.Generic;
using System.Text;

namespace Test1.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Blog,
        CreatePost
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
