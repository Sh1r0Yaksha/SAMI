using System.ComponentModel;
using System.Net;
using System.Diagnostics;

namespace SAMI
{
    public partial class IntroductionForm : Form
    {
        public static string SAFolder = "";
        public Button cancelButton = new Button();
        WebClient webClient = new WebClient();
        String originalSpecifyText;

        public IntroductionForm()
        {
            InitializeComponent();
        }

        private void haveSALTButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(SAFolder) && File.Exists(SAFolder + "\\Smol Ame.exe"))
            {
                if (File.Exists(SAFolder + "\\Smol Ame_Data\\Managed\\SALT.dll"))
                {
                    HaveSALTForm haveSALTForm = new HaveSALTForm();
                    haveSALTForm.StartPosition = FormStartPosition.Manual;
                    haveSALTForm.Location = this.Location;
                    haveSALTForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("It seems like SALT is not installed in this folder! Please install SALT and try again");
                }
                
            }
            else
            {
                MessageBox.Show("Selected folder does not contain Smol Ame! Try again");
            }

        }

        private void notSALTButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(SAFolder) && File.Exists(SAFolder + "\\Smol Ame.exe"))
            {
                Uri SALTuri = new Uri("https://github.com/MegaPiggy/SALT/releases/download/1.3/SALTInstaller.exe");
                webClient.DownloadFileAsync(SALTuri, SAFolder + "\\SALTInstaller.exe");
                webClient.DownloadFileCompleted += DownloadSALTComplete;

                originalSpecifyText = specifySALTLabel.Text;

                haveSALTButton.Visible = false;

                cancelButton.Location = notSALTButton.Location;
                cancelButton.Size = notSALTButton.Size;

                notSALTButton.Enabled = false;
                notSALTButton.Visible = false;



                cancelButton.Text = "Cancel";
                cancelButton.Click += cancelButton_Click;
                cancelButton.Enabled = true;
                cancelButton.Visible = true;
                this.Controls.Add(cancelButton);
                specifySALTLabel.Text = "Please wait while SALT is being downloaded and installed";
            }
            else
            {
                MessageBox.Show("Selected folder does not contain Smol Ame! Try again");
            }
        }

        private void DownloadSALTComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Download Cancelled");
                File.Delete(SAFolder + "\\SALTInstaller.exe");
                cancelButton.Enabled = false;
                cancelButton.Visible = false;
                haveSALTButton.Visible = true;
                notSALTButton.Enabled = true;
                notSALTButton.Visible = true;
                specifySALTLabel.Text = originalSpecifyText;
            }
            else
            {
                var ps = new ProcessStartInfo(SAFolder + "\\SALTInstaller.exe")
                {
                    UseShellExecute = true,
                    Verb = "open",
                    WorkingDirectory = SAFolder
                };
                Process.Start(ps);

                HaveSALTForm haveSALTForm = new HaveSALTForm();
                haveSALTForm.StartPosition = FormStartPosition.Manual;
                haveSALTForm.Location = this.Location;
                haveSALTForm.Show();
                this.Hide();
            }
        }

        void ShowBrowseDialog()
        {
            SAFolderBrowserDialog.ShowDialog();
            SAFolder = SAFolderBrowserDialog.SelectedPath;
            browseTextBox.Text = SAFolder;
        }

        private void browseTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            ShowBrowseDialog();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            ShowBrowseDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            webClient.CancelAsync();
        }
    }
}