using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Downloader_e_Conversor_de_videos
{
    public partial class SegundoForm : Form
    {
        private IEnumerable<IVideoStreamInfo> _Video;
        IEnumerable<IAudioStreamInfo> _Music;
        private string _Dir, _nomeVideo;
        private bool _checkAudio, _checkVideo;

        public SegundoForm(IEnumerable<IVideoStreamInfo> video, IEnumerable<IAudioStreamInfo> music, string nomeVideo, string canal, string dir, bool checkAudio, bool checkVideo)
        {
            this._Video = video;
            this._Music = music;
            this._Dir = dir;

            InitializeComponent();
            _nomeVideo = lblNomeVideo.Text = nomeVideo;
            lblCanal.Text = canal;
            _checkVideo = checkVideo;
            _checkAudio = checkAudio;

            foreach (var i in video)
            {
                comboBoxVideo.Items.Add($"{i} | {String.Format("{0:00}", i.Size.MegaBytes)} Mbs ");
            }
            foreach (var j in music)
            {
                comboBoxAudio.Items.Add($"{j} | {String.Format("{0:00}", j.Size.MegaBytes)} Mbs |{j.Size.Bytes}");
            }
            comboBoxAudio.Visible = checkAudio;
            comboBoxVideo.Visible = checkVideo;
        }



        private async void bntBaixar_Click(object sender, EventArgs e)
        {


            var yt = new YoutubeClient();
            if (_checkAudio)
            {
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
            if (_checkVideo)
            {
                if (lblDownloadVideo.Text != "Sucesso!")
                {
                    if (!string.IsNullOrEmpty((string)comboBoxVideo.SelectedItem))
                    {
                        var test = lblDownloadVideo.Text;
                        lblDownloadVideo.Visible = true;
                        lblDownloadVideo.Text = "Aguarde ...";

                        string opcao = comboBoxVideo.SelectedItem.ToString();
                        var index = (opcao.Substring(opcao.IndexOf('(') + 1)).Split('|');
                        var quality = index[0].Trim();
                        var conteiner = (index[1].Split(')'))[0].Trim();
                        var vid = (_Video.Where(m => m.VideoQuality.Label == quality)).First(m => m.Container.Name == conteiner);
                        string rename = Regex.Replace(_nomeVideo, @"[^0-9a-zA-Z ]+", " ");
                        await yt.Videos.Streams.DownloadAsync(vid, _Dir + "\\" + rename + $".{conteiner}");

                        lblDownloadVideo.ForeColor = Color.Green;
                        lblDownloadVideo.Text = "Sucesso!";
                    }
                    else
                    {
                        lblDownloadVideo.Visible = true;
                        lblDownloadVideo.ForeColor = Color.Red;
                        lblDownloadVideo.Text = "Escolha a Resolução";

                    }
                }
            }
        }
    }
}