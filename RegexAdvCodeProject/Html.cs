using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAdvCodeProject
{
    public static class Html
    {
        public static void html()
        {
            string filePath = @"C:\Users\Ramisettylokesh\OneDrive\Desktop\Html.html.txt";
            // Read HTML content from filetry
            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string htmlContent = sr.ReadToEnd();


                        // Extract headings
                        List<string> headings = ExtractHeadings(htmlContent);
                        Console.WriteLine("Headings:");
                        foreach (string heading in headings)
                        {
                            Console.WriteLine(heading);
                        }

                        //Extracting paragraph tags

                        List<string> paragraphs = ExtractSpecificTags(htmlContent);
                        Console.WriteLine("\nParagraphs:");
                        foreach (string paragraph in paragraphs)
                        {
                            Console.WriteLine(paragraph);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File Doesn't Exist");
            }

            

            static List<string> ExtractHeadings(string html)
            {
                List<string> headings = new List<string>();
                string pattern = @"<h\d>(.*?)</h\d>";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(html);
                foreach (Match match in matches)
                {
                    headings.Add(match.Groups[1].Value);
                }
                return headings;
            }


            static List<string> ExtractSpecificTags(string html)
            {
                List<string> elements = new List<string>();
                string tagName = "p";
                string pattern = $"<{tagName}>(.*?)</{tagName}>";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(html);
                foreach (Match match in matches)
                {
                    elements.Add(match.Groups[1].Value.Trim());
                }
                return elements;
            }
        }
    }
}
