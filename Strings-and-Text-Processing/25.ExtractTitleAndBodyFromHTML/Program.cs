namespace _25.ExtractTitleAndBodyFromHTML
{
    using System;
    using System.Text;

    class Program
    {
        // 25. Write a program that extracts from given HTML file its title (if available), 
        //     and its body text without the HTML tags. Example:

        static void Main(string[] args)
        {
            string html = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p><b>BOLD<i>BOLD AND ITALIC</i>BOLD AGAIN</b></body></html>";

            StringBuilder sb = new StringBuilder();

            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < html.Length; i++)
            {
                if (html[i] == '>')
                {
                    startIndex = i;
                }
                else if (html[i] == '<')
                {
                    endIndex = i;

                    if (endIndex - startIndex > 1)
                    {
                        sb.Append(html.Substring(startIndex + 1, endIndex - startIndex - 1) + " ");
                    }
                }
            }

            Console.WriteLine(sb);

            //StringBuilder result = new StringBuilder();
            //int indexOfTitle = html.IndexOf("<title>");
            //int indexOfEndOfTitle = indexOfTitle + 6;

            //// check for content in title
            //for (int i = indexOfEndOfTitle + 1; i < html.Length; i++)
            //{
            //    if (html[i] != '<')
            //    {
            //        result.Append(html[i]);
            //    }

            //    else
            //    {
            //        break;
            //    }

            //}
            //result.AppendLine();

            //// chack for content in body
            //int indexOfBody = html.IndexOf("<body>");
            //bool afterTag = false;

            //for (int i = indexOfBody + 6; i < html.Length; i++)
            //{
            //    if (afterTag)
            //    {
            //        if (html[i] == '<')
            //        {
            //            afterTag = false;
            //        }

            //        else
            //        {
            //            result.Append(html[i]);
            //            if (html[i + 1] == '<')
            //            {
            //                result.AppendLine();
            //            }

            //        }

            //    }
            //    if (html[i] == '>' && i + 1 < html.Length)
            //    {
            //        afterTag = true;
            //        continue;
            //    }

            //}

            //Console.WriteLine(result.ToString());





            ////StreamReader reader = new StreamReader(@"..\..\..\text.html");
            ////using (reader)
            ////{
            ////    string line = string.Empty;
            ////    MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
            ////    while ((line = reader.ReadLine()) != null)
            ////    {
            ////        matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

            ////        foreach (var word in matchProtocolAndSiteName)
            ////        {
            ////            Console.WriteLine(word);
            ////        }
            ////    }
            ////}
        }
    }
}
