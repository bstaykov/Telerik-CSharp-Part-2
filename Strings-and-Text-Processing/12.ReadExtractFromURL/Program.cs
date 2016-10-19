namespace _12.ReadExtractFromURL
{
    using System;

    class Program
    {
        // 12 Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts
        // from it the [protocol], [server] and [resource] elements. For example from the 
        // URL http://www.devbg.org/forum/index.php the following information should be extracted:

        // [protocol] = "http"
        // [server] = "www.devbg.org"
        // [resource] = "/forum/index.php"

        static void Main(string[] args)
        {
            string url = @"http://www.devbg.org/forum/index.php";

            ParseUrl(url);
        }

        private static void ParseUrl(string url)
        {
            int indexOfProtocol = url.IndexOf(':');
            string protocol = url.Substring(0, indexOfProtocol);
            Console.WriteLine(protocol);

            int indexOfServer = url.IndexOf('/') + 2;
            int lastIndexOfserver = url.IndexOf('/', indexOfServer);

            string server = url.Substring(indexOfServer, lastIndexOfserver - indexOfServer);
            Console.WriteLine(server);

            int indexOfResource = url.IndexOf('/', lastIndexOfserver);

            string resource = url.Substring(indexOfResource);
            Console.WriteLine(resource);
        }
    }
}
