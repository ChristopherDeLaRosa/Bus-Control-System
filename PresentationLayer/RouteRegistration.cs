using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Entities;


namespace PresentationLayer
{
    public partial class RouteRegistration : Form
    {
        RouteBL routeBL = new RouteBL();
        public RouteRegistration()
        {
            InitializeComponent();
            InitializeWebView();

        }
        private async void InitializeWebView()
        {
            webView = new WebView2();
            webView.Size = new Size(800, 400);  // width: 600, height: 400
            webView.Location = new Point(75, 250);  // X: 75, Y: 350
            this.Controls.Add(webView);

            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate("https://www.google.com/maps");
        }

        private void btnSaveRoute_Click(object sender, EventArgs e)
        {
            Route route = new Route
            {
                RouteName = txtRouteName.Text,
            };
            routeBL.AddRoute(route);

            MessageBox.Show("Route added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            string route = txtRouteName.Text;
            string query = HttpUtility.UrlEncode($"{city} {route}".Trim());

            webView.CoreWebView2.Navigate($"https://www.google.com/maps/search/{query}");

        }

        
    }
}
