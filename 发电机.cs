using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
namespace ResellerPanelAuthGG
{
    public partial class 发电机 : Form
    {
        public 发电机()
        {
            InitializeComponent();
        }
        int n1, n2, x1, x2;

        private void 发电机_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            value.Text = User.UserVariable;
            using (DcWebHook dcWeb = new DcWebHook())
            {

                    dcWeb.ProfilePicture = "https://www.pngfind.com/pngs/m/10-109569_shield-logo-png-logo-agent-of-shield-transparent.png";
                    dcWeb.UserName = "Agent Log";
                    dcWeb.WebHook = "YOURWEBHOOK HERE";
                    dcWeb.SendMessage("```css" +  Environment.NewLine + $"Agent : {User.Username}" + Environment.NewLine +  $"Agent Balance : {User.UserVariable}"  + Environment.NewLine + $"Agent Current time : {DateTime.Now}"  + Environment.NewLine + "```");
            }
        }

        private void day_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void week_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            #region [Check Balance]
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    string smile = value.Text;
                    if (smile.Contains("-"))
                    {
                        value.Text = "0";
                        MessageBox.Show("You don't have enough balance please recharge", "对话:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        WebClient smiley = new WebClient();
                        smiley.DownloadString($"https://developers.auth.gg/USERS/?type=editvar&authorization=IAFIOKDDRHWR&user={User.Username}&value={value.Text = Convert.ToString(n1)}");
                        value.Text = "0";
                    }
                }
                catch
                {

                }
            }
            #endregion
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        public static string authgg = "https://developers.auth.gg";
        public static string API = "APIKEY";
        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            int check = int.Parse(value.Text);
            try
            {
                #region [ Calca ]
                backgroundWorker1.RunWorkerAsync();
                if (day.Checked == true)
                {
                    if (check < 10)
                    {
                        MessageBox.Show("You don't have enough balance please recharge your balance must be 10 or higher", "对话:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (check >= 10)
                    {

                        n1 = int.Parse(value.Text);
                        n2 = int.Parse("10");
                        x1 = n1;
                        x2 = n2;
                        while (n2 != 0)
                        {
                            int brw = (~n1) & n2;
                            n1 = n1 ^ n2;
                            n2 = brw << 1;

                        }
                        WebClient smiley = new WebClient();
                        smiley.DownloadString($"https://developers.auth.gg/USERS/?type=editvar&authorization=IAFIOKDDRHWR&user={User.Username}&value={value.Text = Convert.ToString(n1)}");
                        output.Text = smiley.DownloadString(authgg + "/LICENSES/?type=generate&days=1&amount=1&level=2&format=3&length=10&prefix=SMILE-PANEL&authorization=" + API);
                        using (DcWebHook dcWeb = new DcWebHook())
                        {

                            dcWeb.ProfilePicture = "https://www.pngfind.com/pngs/m/10-109569_shield-logo-png-logo-agent-of-shield-transparent.png";
                            dcWeb.UserName = "Agent Log";
                            dcWeb.WebHook = "YOURWEBHOOK HERE"";
                            dcWeb.SendMessage("```css" + Environment.NewLine + $"Agent : {User.Username}" + Environment.NewLine + $"Agent Balance : {User.UserVariable}" + Environment.NewLine + $"Agent Current time : {DateTime.Now}" + Environment.NewLine +  $"Generated Key : {output.Text}" + Environment.NewLine + "```");
                        }
                    }
                    #endregion
                    #region [Check Balance]
                    try
                    {
                        string smile = value.Text;
                        if (smile.Contains("-"))
                        {
                            value.Text = "0";
                            MessageBox.Show("You don't have enough balance please recharge", "对话:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            WebClient smileyY = new WebClient();
                            smileyY.DownloadString($"https://developers.auth.gg/USERS/?type=editvar&authorization=IAFIOKDDRHWR&user={User.Username}&value={value.Text = Convert.ToString(n1)}");
                            value.Text = "0";
                        }
                    }
                    catch
                    {

                    }
                    #endregion
                }

                if (month.Checked == true)
                {
                    if (check < 20)
                    {
                        MessageBox.Show("You don't have enough balance please recharge your balance must be 20 or higher", "对话:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (check >= 20)
                    {

                        n1 = int.Parse(value.Text);
                        n2 = int.Parse("20");
                        x1 = n1;
                        x2 = n2;
                        while (n2 != 0)
                        {
                            int brw = (~n1) & n2;
                            n1 = n1 ^ n2;
                            n2 = brw << 1;

                        }
                        WebClient smiley = new WebClient();
                        smiley.DownloadString($"https://developers.auth.gg/USERS/?type=editvar&authorization=IAFIOKDDRHWR&user={User.Username}&value={value.Text = Convert.ToString(n1)}");
                        output.Text = smiley.DownloadString(authgg + "/LICENSES/?type=generate&days=30&amount=1&level=2&format=3&length=10&prefix=SMILE-PANEL&authorization=" + API);
                        using (DcWebHook dcWeb = new DcWebHook())
                        {

                            dcWeb.ProfilePicture = "https://www.pngfind.com/pngs/m/10-109569_shield-logo-png-logo-agent-of-shield-transparent.png";
                            dcWeb.UserName = "Agent Log";
                            dcWeb.WebHook = "YOUR WEB HOOK HERE";
                            dcWeb.SendMessage("```css" + Environment.NewLine + $"Agent : {User.Username}" + Environment.NewLine + $"Agent Balance : {User.UserVariable}" + Environment.NewLine + $"Agent Current time : {DateTime.Now}" + Environment.NewLine + $"Generated Key : {output.Text}" + Environment.NewLine + "```");
                        }
                    }
                    #region [ Check Balance]
                    try
                    {
                        string smile = value.Text;
                        if (smile.Contains("-"))
                        {
                            value.Text = "0";
                            MessageBox.Show("You don't have enough balance please recharge", "对话:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            WebClient smileyY = new WebClient();
                            smileyY.DownloadString($"https://developers.auth.gg/USERS/?type=editvar&authorization=IAFIOKDDRHWR&user={User.Username}&value={value.Text = Convert.ToString(n1)}");
                            value.Text = "0";
                        }
                    }

                    catch
                    {

                    }
                }
                    #endregion
                    if (week.Checked == true)
                    {
                    if (check < 15)
                    {
                        MessageBox.Show("You don't have enough balance please recharge your balance must be 15 or higher", "对话:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (check >= 15)
                    {

                        n1 = int.Parse(value.Text);
                        n2 = int.Parse("15");
                        x1 = n1;
                        x2 = n2;
                        while (n2 != 0)
                        {
                            int brw = (~n1) & n2;
                            n1 = n1 ^ n2;
                            n2 = brw << 1;

                        }
                        WebClient smiley = new WebClient();
                        smiley.DownloadString($"https://developers.auth.gg/USERS/?type=editvar&authorization=IAFIOKDDRHWR&user={User.Username}&value={value.Text = Convert.ToString(n1)}");
                        output.Text = smiley.DownloadString(authgg + "/LICENSES/?type=generate&days=30&amount=1&level=2&format=3&length=10&prefix=SMILE-PANEL&authorization=" + API);
                        using (DcWebHook dcWeb = new DcWebHook())
                        {

                            dcWeb.ProfilePicture = "https://www.pngfind.com/pngs/m/10-109569_shield-logo-png-logo-agent-of-shield-transparent.png";
                            dcWeb.UserName = "Agent Log";
                            dcWeb.WebHook = "YOUR WEBHOOK HERE";
                            dcWeb.SendMessage("```css" + Environment.NewLine + $"Agent : {User.Username}" + Environment.NewLine + $"Agent Balance : {User.UserVariable}" + Environment.NewLine + $"Agent Current time : {DateTime.Now}" + Environment.NewLine + $"Generated Key : {output.Text}" + Environment.NewLine + "```");
                        }
                    }
                    #region [ Check Balance]
                    try
                    {
                        string smile = value.Text;
                        if (smile.Contains("-"))
                        {
                            value.Text = "0";
                            MessageBox.Show("You don't have enough balance please recharge", "对话:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            WebClient smileyY = new WebClient();
                            smileyY.DownloadString($"https://developers.auth.gg/USERS/?type=editvar&authorization=IAFIOKDDRHWR&user={User.Username}&value={value.Text = Convert.ToString(n1)}");
                            value.Text = "0";
                        }
                    }

                    catch
                    {

                    }
                    #endregion
                }
            }
            catch
            {

            }

        }

    }
}
