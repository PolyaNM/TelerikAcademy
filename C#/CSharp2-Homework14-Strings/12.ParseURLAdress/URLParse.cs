/* 
Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
[protocol] = "http"
[server] = "www.devbg.org"
[resource] = "/forum/index.php"
 */

using System;

class URLParse
{
    static void Main()
    {
        Console.WriteLine("Please, enter the URL address.");
        string url = Console.ReadLine(); //http://www.devbg.org/forum/index.php

        int protocolIndex = url.IndexOf(':');
        string protocol = url.Substring(0, protocolIndex);

        int serverIndex = url.IndexOf('/', protocolIndex + 3);
        string server = url.Substring(protocolIndex + 3, serverIndex - protocolIndex - 3);

        string resource = url.Substring(serverIndex + 1);

        Console.WriteLine("[protocol]= \"{0}\"", protocol);
        Console.WriteLine("[server]= \"{0}\"", server);
        Console.WriteLine("[resource]= \"{0}\"", resource);
    }
}