using MediaToolkit;
using MediaToolkit.Model;
using NReco.VideoConverter;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeExplode;


namespace Downloader_e_Conversor_de_videos
{
    public partial class Form1 : Form
    {
        string pathVideo, video, pathMusic, musica;

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelect.Text) && string.IsNullOrEmpty(txtSave.Text))
            {
                lblErroPrim.Visible = true;
                lblErroPrim.Text = "Os campos a esquerda não podem ser vazio";
            }
            else
            {
                progressBarNormal.Visible = true;
                progressBarNormal.Value = 0;
                progressBarNormal.Maximum = 200;
                progressBarNormal.Step = 1;
                for (int i = 0; i < 100; i++)
                {
                    progressBarNormal.PerformStep();
                }
                var convert = new FFMpegConverter();
              
                convert.ConvertMedia(txtSelect.Text.Trim(), txtSave.Text.Trim(), "mp3");
                for (int i = 100; i < 200; i++)
                {
                    progressBarNormal.PerformStep();
                }
            }



        }

        private void bntYT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (txtYtSelect.Text.Trim() == "")
                {
                    txtYtSelect.Text = "Link vazio, Tente novamente";
                }
                else
                {
                    progressBarYT.Visible = true;
                    progressBarYT.Value = 0;
                    progressBarYT.Maximum = 200;
                    progressBarYT.Step = 1;

                    var dir = fileDialog.SelectedPath + "\\";
                    YouTube youTube = new YouTube();
                    Video video = youTube.GetVideo(txtYtSelect.Text.Trim());
                    var nomeVideo = video.FullName.Substring(0, video.FullName.Length - 4);
                    File.WriteAllBytes(dir + nomeVideo, video.GetBytes());
                    var inputFile = new MediaFile { Filename = dir + nomeVideo };
                    var file = new MediaFile { Filename = $"{dir + nomeVideo}.mp3" };
                    for (int i = 0; i < 100; i++)
                    {
                        progressBarYT.PerformStep();
                    }

                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);
                        engine.Convert(inputFile, file);
                    }
                    for (int i = 100; i < 200; i++)
                    {
                        progressBarYT.PerformStep();
                    }
                    File.Delete(inputFile.Filename);

                    txtYtSelect.Clear();
                }

            }


        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {

            if (txtBaixar.Text == "")
            {
                txtBaixar.Text = "Insira o link aqui;";
            }
            else
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    progressBarBaixar.Value = 0;
                    progressBarBaixar.Visible = true;
                    progressBarBaixar.Step = 1;
                    progressBarBaixar.Maximum = 200;

                    var dir = folder.SelectedPath + "\\";
                    var yt = YouTube.Default;
                    for (int i = 0; i < 100; i++)
                    {
                        progressBarBaixar.PerformStep();
                    }

                    Video video = yt.GetVideo(txtBaixar.Text.Trim());
                    File.WriteAllBytes($"{dir + "\\" + video.FullName}", video.GetBytes());
                    for (int i = 100; i < 200; i++)
                    {
                        progressBarBaixar.PerformStep();
                    }
                }
            }


        }

        private async void btnYtExplode_Click(object sender, EventArgs e)
        {
            if (txtYtExplode.Text.Trim() != "")
            {
                var verificaUrl = txtYtExplode.Text.Trim().Substring(0, "https://www.youtube.com/".Length);
                if ("https://www.youtube.com/" == verificaUrl)
                {
                    if (checkVideo.Checked == true || checkAudio.Checked == true)
                    {
                        FolderBrowserDialog folder = new FolderBrowserDialog();
                        if (folder.ShowDialog() == DialogResult.OK)
                        {
                            var dir = folder.SelectedPath + "\\";
                            await BaixarVideo(txtYtExplode.Text.Trim(), dir, checkAudio.Checked, checkVideo.Checked);
                        }
                    }
                    else
                        lblErroOpcao.Visible = true;

                }
                else
                {
                    lblErroTxt.Visible = true;
                    lblErroTxt.Text = "Apenas url do Youtube é válido no momento";
                }

            }
            else
                lblErroTxt.Visible = true;
        }
        public async Task BaixarVideo(string url, string dir, bool checkMusica, bool checkVid)
        {
            var youtube = new YoutubeClient();

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);
            var nomeVideo = await youtube.Videos.GetAsync(url);
            var video = streamManifest.GetVideoStreams();
            var music = streamManifest.GetAudioStreams();
            txtYtExplode.Clear();
            checkAudio.Checked = false;
            checkVideo.Checked = false;
            
           SegundoForm segundoForm = new SegundoForm(video, music, nomeVideo.Title, nomeVideo.Author.ChannelTitle, dir, checkMusica, checkVid);
            segundoForm.ShowDialog();
        }


        private void BtnCopyTo_Click(object sender, EventArgs e)
        {
            if (video != null)
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    pathMusic = folder.SelectedPath;
                    musica = video.Substring(0, video.Length - 4);
                    pathMusic += ("\\" + musica + ".mp3");
                }
                txtSave.Text = pathMusic;
            }
            else
            {
                txtSelect.Text = "Escolha o arquivo primeiro";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenTo_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "MP4 File|*.mp4"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pathVideo = open.FileName;
                video = open.SafeFileName;
            }
            txtSelect.Text = pathVideo;
        }

    }
}
