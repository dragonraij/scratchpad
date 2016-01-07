using MockAPP.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MockAPP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("http://mockapi123.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("custom/mycustomers/");
                if (response.IsSuccessStatusCode) {
                    // Customer customer = await response.Content.ReadAsAsync<Customer>();
                    // resultBlock.Text = customer.ToString();
                    string output = "";
                    var results = await response.Content.ReadAsAsync<List<Customer>>();
                    //foreach (var customer in results)
                    //{
                    //    output += "\nCustomer : "+customer.CustomerName+" Joined : "+customer.Joined;
                    //}

                    //resultBlock.Text = output;

                    gridView.dataSource = results;
                }
              
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            resultBlock.Text = "Hello Linda";
        }
    }
}
