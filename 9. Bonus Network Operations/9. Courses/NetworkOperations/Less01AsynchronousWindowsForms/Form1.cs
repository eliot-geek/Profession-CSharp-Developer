using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Less01AsynchronousWindowsForms
{
    public partial class Form1 : Form
    {
        //#region WebClient

        //string url;
        //WebClient client;
        //public Form1()
        //{
        //    InitializeComponent();
        //    url = "https://filesamples.com/samples/document/txt/sample3.txt";
        //    client = new WebClient();
        //}

        //private void btnDownload_Click(object sender, EventArgs e)
        //{
        //    DownloadFile();
        //}

        //void DownloadFile()
        //{
        //    client.DownloadFile(url, "sample3.txt");
        //}

        //private void btnDownloadAsync_Click(object sender, EventArgs e)
        //{
        //    DownloadFileAsync();
        //}

        //async void DownloadFileAsync()
        //{
        //    await client.DownloadFileTaskAsync(new Uri(url), "sample3Async.txt");
        //}

        //#endregion


        #region HttpClient

        string url;
        HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            url = "https://filesamples.com/samples/document/txt/sample3.txt";
            httpClient = new HttpClient();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            await DownloadFileAsync();
        }

        private async Task DownloadFileAsync()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                    System.IO.File.WriteAllBytes("sample3.txt", fileBytes);
                }
                else
                {
                    MessageBox.Show("Failed to download the file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void btnDownloadAsync_Click(object sender, EventArgs e)
        {
            await DownloadFileAsyncAsync();
        }

        private async Task DownloadFileAsyncAsync()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                    System.IO.File.WriteAllBytes("sample3Async.txt", fileBytes);
                }
                else
                {
                    MessageBox.Show("Failed to download the file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        #endregion
    }
}
