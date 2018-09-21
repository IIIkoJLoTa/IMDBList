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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace TabMenu
{
    /// <summary>
    /// Interaction logic for FilmsPage.xaml
    /// </summary>
    public partial class FilmsPage : Page
    {
        HtmlAgilityPack.HtmlNodeCollection kinopoisk;
        public FilmsPage()
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
        protected internal void Complete()
        {
            try
            {
                if (kinopoisk != null)
                {
                    var GetKey = new WebClient().DownloadString("http://www.omdbapi.com/?apikey=b4a15168&t=" + kinopoisk[0].InnerText);
                    Person temp = JsonConvert.DeserializeObject<Person>(GetKey);
                    Image1.Source = new BitmapImage(new Uri(temp.Poster, UriKind.RelativeOrAbsolute));
                    //(Labe1l.Content = kinopoisk[0].InnerText).ToString();
                    TextBox1.Text = NormalOutput(GetKey);
                    for (int b = 0; b < 1; b++)
                    {
                        kinopoisk.RemoveAt(b);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                for (int b = 0; b < 1; b++)
                {
                    kinopoisk.RemoveAt(b);
                }
            }
        }

        protected internal void SaveToFile()
        {
            string PathForWriting = @"C:\\Users\artem\OneDrive\Рабочий стол\TabMenu-master\TabMenu\bin\Debug\FilmInfo.txt";
            using (StreamWriter sw = new StreamWriter(PathForWriting, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(TextBox1.Text);
            }
        }

        private string NormalOutput(string item)
        {
            return item.Split('{')[1].Split('&')[0];
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Complete();
        }

        private void Image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            for(int i = 0; i < kinopoisk.Count; i++)
            {
                Process.Start("http://hdrezka.ag/engine/ajax/search.php?q=" + kinopoisk[i].InnerText.ToString());
                break;
            }
        }
    }
}
