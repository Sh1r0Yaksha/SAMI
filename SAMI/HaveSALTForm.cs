using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.IO.Compression;
using Newtonsoft.Json;
using SAMI.Data;
using Octokit;

namespace SAMI
{
    public partial class HaveSALTForm : Form
    {
        List<Mod> mods;
        string SALTModsFolder = IntroductionForm.SAFolder + "\\SALT\\Mods";

        public HaveSALTForm()
        {           
            InitializeComponent();
        }

        private void HaveSALTForm_Load(object sender, EventArgs e)
        {
            mods = new List<Mod>();
            List<Mod> convertedJSON = new();
            using (WebClient webClient = new WebClient())
            {
                string modsJson = webClient.DownloadString("https://raw.githubusercontent.com/MegaPiggy/smol-ame-mod-database/source/mods.json");
                convertedJSON = JsonConvert.DeserializeObject<List<Mod>>(modsJson);
            }

            foreach (Mod mod in convertedJSON)
            {
                mods.Add(mod);
            }

            modsDataGridView.DataSource = mods;
            modsDataGridView.Columns["id"].Visible = false;
            modsDataGridView.Columns["nexusId"].Visible = false;
            modsDataGridView.Columns["repo"].Visible = false;
        }

        private async void installModButton_Click(object sender, EventArgs e)
        {
            string[] repoText = modsDataGridView.SelectedRows[0].Cells[3].Value.ToString().Split('/');

            string author = repoText[0];
            string repoName = repoText[1];
            string modName = modsDataGridView.SelectedRows[0].Cells[2].Value.ToString();

            GitHubClient githubClient = new GitHubClient(new ProductHeaderValue("SAMI"));
            var latestRepo = githubClient.Repository.Release.GetLatest(author, repoName);
            string urlOfLatestRelease = latestRepo.Result.Assets[0].BrowserDownloadUrl;
            string nameOfMod = latestRepo.Result.Assets[0].Name;
            string folderWithMod = SALTModsFolder + "\\" + nameOfMod;


            if ((int)modsDataGridView.SelectedRows[0].Cells[1].Value == 11) // For discordRPC
            {
                if (File.Exists(SALTModsFolder + "\\RichPresence.dll"))
                {
                    DialogResult dialogResult = MessageBox.Show(modName + " is already installed! Do you want to remove it?", null, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(SALTModsFolder + "\\RichPresence.dll");
                        Directory.Delete(IntroductionForm.SAFolder + "\\Smol Ame_Data\\Plugins", true);
                        MessageBox.Show(modName + " has been removed");
                    }
                }
                else
                {
                    try
                    {
                        using (WebClient webClient = new WebClient())
                        {
                            webClient.DownloadFile(new Uri(urlOfLatestRelease), folderWithMod);
                        }

                        string extractionFolder = IntroductionForm.SAFolder + "\\DiscordRPC";


                        ZipFile.ExtractToDirectory(folderWithMod, extractionFolder);
                        File.Delete(folderWithMod);
                        File.Move(extractionFolder + "\\RichPresence.dll", SALTModsFolder + "\\RichPresence.dll");
                        Directory.Move(extractionFolder + "\\Plugins", IntroductionForm.SAFolder + "\\Smol Ame_Data\\Plugins");
                        Directory.Delete(extractionFolder, true);

                        

                        MessageBox.Show(modName + " has been downloaded and installed");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nPlease wait and try again and if the problem persists, contact the author");

                    }
                }
            }
            else
            {
                if (!File.Exists(folderWithMod))
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(new Uri(urlOfLatestRelease), folderWithMod);
                    }
                    MessageBox.Show(modName + " has been downloaded and installed");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(modName + " is already installed! Do you want to remove it?", null, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(folderWithMod);
                        MessageBox.Show(modName + " has been removed");
                    }
                }
            }


        }

        private void modsWebsiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://smolamemods.netlify.app/")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void launchGameButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo smolAme = new ProcessStartInfo(IntroductionForm.SAFolder + "\\Smol Ame.exe")
            {
                UseShellExecute = true,
                Verb = "open",
                WorkingDirectory = IntroductionForm.SAFolder
            };
            Process.Start(smolAme);
        }
    }
}
