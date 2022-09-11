using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)//get called when we create an object of this class
        {
            //book1.title = "Harry Potter";
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
