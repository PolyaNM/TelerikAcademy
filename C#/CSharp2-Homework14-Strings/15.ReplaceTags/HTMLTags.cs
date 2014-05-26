// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
// example : <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
// result : <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;
using System.Text.RegularExpressions;

class HTMLTags
{
    static void Main()
    {
        Console.WriteLine("Please enter the text.");
        // string text = Console.ReadLine(); 
        string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        string newtext = Regex.Replace(text, @"<a href=""", "[URL=");
        newtext = Regex.Replace(newtext, @""">", "]");
        newtext = Regex.Replace(newtext, "</a>", "[/URL]");
        Console.WriteLine("The text after raplacing the tags is:");
        Console.WriteLine(newtext);
    }
}
