using SkeetUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webhosts_inject.etc;

namespace webhosts_inject
{
    public partial class Form1 : skeetForm
    {
        private string list;

        public Form1()
        {
            InitializeComponent();
            output_box.Text = stuff.Shit_Post();
        }

        private void Get_Content(string url)
        {
            Hosts_Box.Text = "";

            try
            {
                
                if (string.IsNullOrEmpty(url))
                {
                    url = "https://gist.githubusercontent.com/KayleMine/680c27c9e6f1fe01f19db4f0d123d0e9/raw/hosts_pull";
                    output_box.Text = "Url not found, default: Autodesk, used...";
                }

                list = stuff.get_data(url);
                Hosts_Box.Text = list;
            }
            catch (Exception ex)
            {
                output_box.Text = ex.ToString();
                MessageBox.Show("Oi error!" + "\n" + ex.ToString());
            }
        }

        private void Pull_Button_Click(object sender, EventArgs e)
        {
            var url = url_box.Text;
            Get_Content(url);
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string hostsFilePath = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\System32\drivers\etc\hosts");
                stuff.AppendLines(hostsFilePath, Hosts_Box.Text);
                output_box.Text = "List imported to hosts file...";
            }
            catch (Exception ex)
            {
                output_box.Text = ex.ToString();
            }

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adobe_btn_clcik(object sender, EventArgs e) //adobe
        {
            Get_Content("https://gist.githubusercontent.com/KayleMine/63fc7e712d2014a65754e26680e41c77/raw/Adobe");
        }

        private void Autodesk_btn_clcik(object sender, EventArgs e) //autodesk
        {
            Get_Content("https://gist.githubusercontent.com/KayleMine/680c27c9e6f1fe01f19db4f0d123d0e9/raw/hosts_pull");
        }

    }
}
