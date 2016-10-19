namespace _10.ExtractFormXMLfile
{
    using System;
    using System.IO;
    using System.Xml;

    class Program
    {
        // Write a program that extracts from given XML file all the text without the tags

        static void Main(string[] args)
        {
            string fileLOcation = "../../input.txt";

            XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
            xmlDoc.Load(fileLOcation); // Load the XML document from the specified file

            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                //Console.WriteLine(node.InnerXml);
                string innerText = node.InnerText; //or loop through its children as well
                Console.WriteLine(innerText);
            }

            //string text = String.Empty;
            //using (StreamReader input = new StreamReader(fileLOcation))
            //{
            //    for (int i; (i = input.Read()) != -1; ) // Read char by char
            //    {
            //        if (i == '>') // Inside text node
            //        {
            //            while ((i = input.Read()) != -1 && i != '<')
            //            {
            //                text += (char)i;
            //            }


            //        }
            //    }
            //}

            //if (!String.IsNullOrWhiteSpace(text))
            //{
            //    Console.WriteLine(text.Trim());
            //}
        }
    }
}
