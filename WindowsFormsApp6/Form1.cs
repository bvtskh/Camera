using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        string ip;
        int type;
        public Form1()
        {
            InitializeComponent();
            type = FormMaps.TypeCamera;
            WebCamera.ScriptErrorsSuppressed = true;
        }
        public Form1(string ip, int type)
        {
            InitializeComponent();
            this.ip = ip;
            this.type = type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var process = new Process();
            var fileEXE = @"C:\Users\u00450\source\repos\WindowsFormsApp5\WindowsFormsApp5\bin\Debug\WindowsFormsApp5.exe Form1";
            process.StartInfo.FileName = fileEXE; // Path to your demo application.
            process.StartInfo.Arguments = "Form1 U00450 umcvn";   // Your arguments
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                //HtmlDocument doc = WebCamera.Document;
                //var element = doc.GetElementById("login_user");
                //element.SetAttribute("value", "admin");
                //element = doc.GetElementById("login_psw");
                //element.SetAttribute("value", "vnumce2017");
                //foreach (HtmlElement item in doc.GetElementsByTagName("a"))
                //{
                //    if (item.InnerText == "Login")
                //    {
                //        item.InvokeMember("Click");
                //    }
                //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ip = FormMaps.url;
            WebCamera.Navigate(ip);
        }

        private void WebCamera_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (e.Url.AbsolutePath == WebCamera.Url.AbsolutePath)
            {
                //HtmlElementCollection sour = WebCamera.Document.GetElementsByTagName("input");
                //if (sour.Count <= 0) return;
                if (type == 1)
                {
                    // Access the document
                    var document = WebCamera.Document;

                    // Find the search input element
                    var element = document.GetElementById("UserName");
                    if (element != null)
                    {
                        // Set the search query
                        element.SetAttribute("value", "admin");
                    }
                    element = document.GetElementById("Password");
                    if (element != null)
                    {
                        // Set the search query
                        element.SetAttribute("value", "vnumce");
                    }
                    // Submit the search form

                    foreach (HtmlElement item in document.GetElementsByTagName("label"))
                    {
                        if (item.Name == "lalogin")
                            item.InvokeMember("click");
                    }
                }
                else if (type == 2)
                {
                    ////Access the document
                    //var document = WebCamera.Document;

                    //// Find the search input element
                    //var element = document.GetElementById("login_user");
                    //if (element != null)
                    //{
                    //    // Set the search query
                    //    element.SetAttribute("value", "admin");
                    //}
                    //element = document.GetElementById("login_psw");
                    //if (element != null)
                    //{
                    //    // Set the search query
                    //    element.SetAttribute("value", "vnumce2017");
                    //}
                    //foreach (HtmlElement item in document.GetElementsByTagName("a"))
                    //{
                    //    if (item.InnerText == "Login")
                    //    {
                    //        item.InvokeMember("click");
                    //        break;
                    //    }

                    ////}
                    HtmlElementCollection elements = WebCamera.Document.GetElementsByTagName("input");
                    if (elements.Count != 0)
                    {
                        foreach (HtmlElement element in elements)
                        {
                            //if (element.Id != "login_user" && element.Id != "login_psw") continue;
                            if (element.Id == "login_user")
                            {
                                element.SetAttribute("value", "admin"); // Replace with your admin account
                            }
                            else if (element.Id == "login_psw")
                            {
                                element.SetAttribute("value", "vnumce2017"); // Replace with your password
                            }
                        }
                        HtmlElementCollection tagA = WebCamera.Document.GetElementsByTagName("a");
                        foreach (HtmlElement item in tagA)
                        {

                            if (item.InnerText == "Login")
                            {
                                item.InvokeMember("click");
                                break;

                            }

                        }

                    }

                }
                else if (type == 3)
                {
                    // Access the document
                    var document = WebCamera.Document;

                    // Find the search input element
                    var element = document.GetElementById("login_user");
                    if (element != null)
                    {
                        // Set the search query
                        element.SetAttribute("value", "admin");
                    }
                    element = document.GetElementById("login_psw");
                    if (element != null)
                    {
                        // Set the search query
                        element.SetAttribute("value", "vnumce");
                    }

                    foreach (HtmlElement item in document.GetElementsByTagName("a"))
                    {
                        if (item.InnerText == "Login")
                            item.InvokeMember("click");
                    }

                }
                else if (type == 4)
                {
                    // Access the document
                    var document = WebCamera.Document;

                    // Find the search input element
                    var element = document.GetElementById("login_user");
                    if (element != null)
                    {
                        // Set the search query
                        element.SetAttribute("value", "admin");
                    }
                    element = document.GetElementById("login_psw");
                    if (element != null)
                    {
                        // Set the search query
                        element.SetAttribute("value", "vnumce2017");
                    }

                    foreach (HtmlElement item in document.GetElementsByTagName("a"))
                    {
                        if (item.InnerText == "Login")
                            item.InvokeMember("click");
                    }

                }
                else if (type == 5)
                {

                    MessageBox.Show("Camera này lỗi !");
                    this.Close();
                    return;
                }
                else if (type == 6)
                {
                    //Những camera không auto login được.
                    HtmlElementCollection elements = WebCamera.Document.GetElementsByTagName("input");
                    if (elements.Count != 0)
                    {
                        foreach (HtmlElement element in elements)
                        {
                            //if (element.Id != "login_user" && element.Id != "login_psw") continue;
                            if (element.Id == "login_user")
                            {
                                element.SetAttribute("value", "admin"); // Replace with your admin account
                            }
                            else if (element.Id == "login_psw")
                            {
                                element.SetAttribute("value", "vnumce2017"); // Replace with your password
                            }
                        }
                    }
                }
            }
        }
    }
}
