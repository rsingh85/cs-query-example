using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsQueryExample
{
    /// <summary>
    /// Demonstration of CSQuery library.
    /// Ravi Singh.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var html = new StringBuilder();
            html.Append("<html><body>");
            html.Append("<h1>Hello, world!</h1>");
            html.Append("<p class='intro'>This program is using CsQuery.</p>");
            html.Append("<p id='author'>CsQuery is a library written by James Treworgy.</p>");
            html.Append("</body></html>");

            var dom = CsQuery.CQ.Create(html.ToString());

            // Get the inner text of an element by element name selector
            Console.WriteLine(dom["h1"].Text());

            // Get the inner text of an element by class name selector
            Console.WriteLine(dom[".intro"].Text());

            // Get the inner text of an element by id selector
            Console.WriteLine(dom["#author"].Text());

            // Add a class to an element
            dom["h1"].AddClass("title");
            
            // Update the title text using new class in selector
            dom[".title"].Text("CSQuery - a JQuery port for .NET");

            // Now retrieve the new title by a class selector
            Console.WriteLine(dom[".title"].Text());

            // Pause console
            Console.ReadLine();
        }
    }
}
