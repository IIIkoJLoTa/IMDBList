using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
namespace TabMenu
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        HtmlAgilityPack.HtmlNodeCollection kinopoisk;
        public SearchPage()
        {
            InitializeComponent();
            HttpClientHandler handler = new HttpClientHandler()
            {
                AllowAutoRedirect = true,
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate

            };
            HttpClient client = new HttpClient(handler) { BaseAddress = new Uri("http://www.imdb.com/chart/top-english-movies") };
            HtmlAgilityPack.HtmlDocument GetNames = new HtmlAgilityPack.HtmlDocument();
            GetNames.LoadHtml(client.GetStringAsync("").Result);
            kinopoisk = GetNames.DocumentNode.SelectNodes("//td[@class='titleColumn']//a");
        }
        public void Search()
        {
            for (int i = 0; i < kinopoisk.Count; i++)
            {
                if (TextBox1.Text == kinopoisk[i].InnerText)
                {
                    var GetKey = new WebClient().DownloadString("http://www.omdbapi.com/?apikey=b4a15168&t=" + kinopoisk[i].InnerText);
                    Person temp = JsonConvert.DeserializeObject<Person>(GetKey);
                    Image1.Source = new BitmapImage(new Uri(temp.Poster, UriKind.RelativeOrAbsolute));
                    TextBox2.Text = NormalOutput(GetKey);
                }
            }
        }
        private string NormalOutput(string item)
        {
            return item.Split('{')[1].Split('&')[0];
        }

        protected internal void SaveToFile()
        {
            string PathForWriting = @"C:\\Users\artem\OneDrive\Рабочий стол\TabMenu-master\TabMenu\bin\Debug\FilmInfo.txt";
            using (StreamWriter sw = new StreamWriter(PathForWriting, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(TextBox1.Text);
            }
        }

        private void findFildButton_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Search();
        }
    }
}
