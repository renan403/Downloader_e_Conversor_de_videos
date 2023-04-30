using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;

namespace Downloader_e_Conversor_de_videos
{
    public partial class SegundoForm : Form
    {
        
        private IEnumerable<IVideoStreamInfo> _Video;
        IEnumerable<IAudioStreamInfo> _Music;
        private string _Dir, _nomeVideo;
        private bool _checkAudio, _checkVideo;

        public SegundoForm(IEnumerable<IVideoStreamInfo> video, IEnumerable<IAudioStreamInfo> music, string nomeVideo, string canal, string dir , IReadOnlyList<Thumbnail> thumb)
        {
            InitializeComponent();
            this._Video = video;
            this._Music = music;
            this._Dir = dir;
            Resolution resolution;
            int MaiorQualidade = 0;
            Image img;
            try
            {
                foreach (var item in thumb)
                {
                    if (MaiorQualidade < item.Resolution.Width)
                    {
                        MaiorQualidade = item.Resolution.Width;
                        resolution = item.Resolution;
                    }
                }
                var url = (thumb.Where(e => e.Resolution.Width == MaiorQualidade)).FirstOrDefault().Url;
                var request = WebRequest.Create(url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    img = Bitmap.FromStream(stream);
                }
                PBox.BackgroundImage = img;
            }
            catch (Exception)
            {
                var request = WebRequest.Create("https://cdn1.iconfinder.com/data/icons/business-company-1/500/image-512.png");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    img = Bitmap.FromStream(stream);
                }
                PBox.BackgroundImage = img;
            }
            

            _nomeVideo = lblNomeVideo.Text = nomeVideo;
            lblCanal.Text = canal;

            foreach (var j in music)
            {
                comboBoxAudio.Items.Add($"{j} | {String.Format("{0:00}", j.Size.MegaBytes)} Mbs |{j.Size.Bytes}");
            }
            comboBoxAudio.Visible = true;
          
        }



        private async void bntBaixar_Click(object sender, EventArgs e)
        {


            var yt = new YoutubeClient();
         
                if (lblDonwloadAudio.Text != "Sucesso!")
                {

                    if (!string.IsNullOrEmpty((string)comboBoxAudio.SelectedItem))
                    {
                        var test = lblDonwloadAudio.Text;
                        lblDonwloadAudio.Visible = true;
                        lblDonwloadAudio.Text = "Aguarde ...";
                        IAudioStreamInfo vid;
                        string conteiner;
                        string opcao = comboBoxAudio.SelectedItem.ToString();

                        var index = (opcao.Substring(opcao.IndexOf('(') + 1)).Split('|');

                        var quality = index[0].Trim();

                        if (index.Length == 3)
                        {
                            conteiner = (index[0].Split(')'))[0].Trim();
                            vid = (_Music.Where(m => m.Size.Bytes.ToString() == index[2].Trim())).First(m => m.Container.Name == conteiner);
                        }
                        else
                        {
                            conteiner = (index[1].Split(')'))[0].Trim();
                            vid = (_Music.Where(m => m.Size.Bytes.ToString() == index[3].Trim())).First(m => m.Container.Name == conteiner);
                        }


                        string rename = Regex.Replace(_nomeVideo, @"[^0-9a-zA-Z ]+", " ");
                        if (opcao.Contains("Muxed"))
                            await yt.Videos.Streams.DownloadAsync(vid, _Dir + "\\" + rename + $".{conteiner}");
                        else
                            await yt.Videos.Streams.DownloadAsync(vid, _Dir + "\\" + rename + $".mp3");
                        lblDonwloadAudio.ForeColor = Color.Green;
                        lblDonwloadAudio.Text = "Sucesso!";
                    }
                    else
                    {
                        lblDonwloadAudio.Visible = true;
                        lblDonwloadAudio.ForeColor = Color.Red;
                        lblDonwloadAudio.Text = "Escolha a Resolução";

                    }
                }
        }
        
    }
}