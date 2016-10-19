namespace _04.DownloadFile
{
    using System;
    using System.Net;

    class Program
    {
        // Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
        // and stores it the current directory. Find in Google how to download files in C#. 
        // Be sure to catch all exceptions and to free any used resources in the finally block.

        static void Main()
        {
            Console.WriteLine("URL: ");
            string remoteUri = Console.ReadLine();
            //string remoteUri = "http://codeweekeu.s3.amazonaws.com/event_picture/555828_416908648323089_1194617417_n.jpg";
            Console.WriteLine("File name: ");
            string fileName = Console.ReadLine();
            //string fileName = "ninja.jpg";

            WebClient myWebClient = new WebClient();

            try
            {
                Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, remoteUri);

                myWebClient.DownloadFile(remoteUri, "../../" + fileName + ".jpg");

                Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, remoteUri);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }    
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myWebClient.Dispose();
            }


            //using (WebClient webClient = new WebClient())
            //{
            //    try
            //    {
            //        Console.Write("URL: ");
            //        string url = Console.ReadLine();
            //        Console.Write("File name: ");
            //        string fileName = Console.ReadLine();
            //        webClient.DownloadFile(url, "../../" + fileName + ".jpg");
            //        webClient.DownloadFile("http://d24w6bsrhbeh9d.cloudfront.net/photo/ay53v9y_700b.jpg", "../../logo.jpg");
            //    }

            //    catch (WebException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    catch (NotSupportedException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
        }
    }
}
