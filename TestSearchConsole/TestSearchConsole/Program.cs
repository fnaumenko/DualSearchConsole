using System;

namespace TestSearchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string query = string.Empty;
            while (true)
            {
                Console.Write("type query or 'q' to quit: ");
                if ((query = Console.ReadLine()) == "q") break;
                //SaveResponse(query);
                Search(query);
            }
        }

        /// <summary>Output searsh results in 2 different pages.</summary>
        /// <param name="query">search query</param>
        private static void Search(string query)
        {
            if (query == string.Empty) return;
            System.Diagnostics.Process.Start("http://google.com/search?q=" + query);
            System.Diagnostics.Process.Start("http://bing.com/search?q=" + query);
        }

        //private static void SaveResponse(string query)
        //{
        //    using (System.Net.WebClient client = new System.Net.WebClient())
        //    {
        //        string url = "http://google.com/search?q=" + query;
        //        string content = client.DownloadString(url);
        //        System.IO.File.WriteAllText("C:\\Users\\Fedor\\Downloads\\GOOGLE.html", content);
        //    }
        //}
    }
}
