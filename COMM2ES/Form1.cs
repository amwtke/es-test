using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace COMM2ES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (urlTxt.Text.Length != 0)
            {
                
                try
                {
                    //string s = HTTPHelper.SendWebHttpRequest(urlTxt.Text.Trim(), comboBox1.Text, jasonInput.Text);
                    //jasonOutput.Text = s;
                    
                    
                    //for (int i = 0; i < 100; i++)
                    //{
                    //    HTTPHelper.SendWebHttpRequestAsync(urlTxt.Text.Trim(), comboBox1.Text, jasonInput.Text, (wr) =>
                    //        {
                    //            //MessageBox.Show("now threadID:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
                    //            Console.WriteLine("now threadID:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
                    //            //System.Threading.Thread.Sleep(100);
                    //            if (wr != null)
                    //            {
                    //                if (wr != null)
                    //                {
                    //                    using (var httpResp = (HttpWebResponse)wr.GetResponse())
                    //                    {
                    //                        if (httpResp.StatusCode == HttpStatusCode.BadRequest)
                    //                        {
                    //                            var buff = new byte[httpResp.ContentLength];
                    //                            using (var response = httpResp.GetResponseStream())
                    //                            {
                    //                                if (response != null)
                    //                                {
                    //                                    response.Read(buff, 0, (int)httpResp.ContentLength);
                    //                                }
                    //                            }

                    //                            throw new InvalidOperationException(
                    //                                string.Format("Some error occurred while sending request to Elasticsearch.{0}{1}",
                    //                                    Environment.NewLine, Encoding.UTF8.GetString(buff)));
                    //                        }
                    //                        else
                    //                        {
                    //                            using (var sr = new StreamReader(httpResp.GetResponseStream(), Encoding.UTF8))
                    //                            {
                    //                                string s = sr.ReadToEnd();
                    //                                //Console.WriteLine(s);
                    //                                jasonOutput.Text = s;
                    //                            }
                    //                        }

                    //                    }
                    //                }
                    //            }
                    //        });
                       
                    //}


                    for (int i = 0; i < 10000; i++)
                    {
                        HTTPHelper.SendWebHttpRequestFullAsync(urlTxt.Text.Trim(), comboBox1.Text, jasonInput.Text, delegate(IAsyncResult ar)
                        {
                            Console.WriteLine("CallBack threadID:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
                            if (ar == null)
                                return;


                            CallBacks.WebRequestCallBacks(ar, new MyProcess());

                            AsyncResult arr = ar as AsyncResult;
                            SendHandler handler = arr.AsyncDelegate as SendHandler;
                            handler.EndInvoke(ar);
                        });

                        Console.WriteLine("III threadID:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
                    }
                }
                catch (Exception ex)
                {
                    jasonOutput.Text = ex.ToString();
                }
                finally
                { 
                }
                
            }
        }

        private delegate void SetRichTextBox(String s);
        public void SetText(string txt)
        {
            if (this.jasonOutput.InvokeRequired)
            {
                SetRichTextBox s = new SetRichTextBox(SetRt);
                this.Invoke(s, new object[] { txt });
            }
            else
            {
                jasonOutput.Text = txt;
            }
        }

        private void SetRt(string text)
        {
            jasonOutput.Text = text;
        }
    }
}
