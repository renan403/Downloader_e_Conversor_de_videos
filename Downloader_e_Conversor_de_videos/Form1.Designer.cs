namespace Downloader_e_Conversor_de_videos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenTo = new System.Windows.Forms.Button();
            this.BtnCopyTo = new System.Windows.Forms.Button();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntYT = new System.Windows.Forms.Button();
            this.txtYtSelect = new System.Windows.Forms.TextBox();
            this.progressBarYT = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarNormal = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblErroPrim = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.progressBarBaixar = new System.Windows.Forms.ProgressBar();
            this.txtBaixar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErroTxt = new System.Windows.Forms.Label();
            this.lblErroOpcao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkVideo = new System.Windows.Forms.CheckBox();
            this.checkAudio = new System.Windows.Forms.CheckBox();
            this.btnYtExplode = new System.Windows.Forms.Button();
            this.txtYtExplode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenTo
            // 
            this.OpenTo.Location = new System.Drawing.Point(489, 47);
            this.OpenTo.Name = "OpenTo";
            this.OpenTo.Size = new System.Drawing.Size(75, 23);
            this.OpenTo.TabIndex = 0;
            this.OpenTo.Text = "Selecionar";
            this.OpenTo.UseVisualStyleBackColor = true;
            this.OpenTo.Click += new System.EventHandler(this.OpenTo_Click);
            // 
            // BtnCopyTo
            // 
            this.BtnCopyTo.Location = new System.Drawing.Point(489, 86);
            this.BtnCopyTo.Name = "BtnCopyTo";
            this.BtnCopyTo.Size = new System.Drawing.Size(75, 23);
            this.BtnCopyTo.TabIndex = 1;
            this.BtnCopyTo.Text = "Salvar onde";
            this.BtnCopyTo.UseVisualStyleBackColor = true;
            this.BtnCopyTo.Click += new System.EventHandler(this.BtnCopyTo_Click);
            // 
            // BtnConvert
            // 
            this.BtnConvert.AutoSize = true;
            this.BtnConvert.Location = new System.Drawing.Point(655, 47);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(107, 62);
            this.BtnConvert.TabIndex = 2;
            this.BtnConvert.Text = "Converter";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(9, 47);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(464, 20);
            this.txtSelect.TabIndex = 3;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(9, 86);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(464, 20);
            this.txtSave.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecionar arquivo mp4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Onde salvar";
            // 
            // bntYT
            // 
            this.bntYT.Location = new System.Drawing.Point(482, 58);
            this.bntYT.Name = "bntYT";
            this.bntYT.Size = new System.Drawing.Size(75, 39);
            this.bntYT.TabIndex = 7;
            this.bntYT.Text = "Converter e salvar";
            this.bntYT.UseVisualStyleBackColor = true;
            this.bntYT.Click += new System.EventHandler(this.bntYT_Click);
            // 
            // txtYtSelect
            // 
            this.txtYtSelect.Location = new System.Drawing.Point(11, 58);
            this.txtYtSelect.Name = "txtYtSelect";
            this.txtYtSelect.Size = new System.Drawing.Size(464, 20);
            this.txtYtSelect.TabIndex = 8;
            // 
            // progressBarYT
            // 
            this.progressBarYT.ForeColor = System.Drawing.Color.Red;
            this.progressBarYT.Location = new System.Drawing.Point(12, 84);
            this.progressBarYT.Name = "progressBarYT";
            this.progressBarYT.Size = new System.Drawing.Size(464, 10);
            this.progressBarYT.TabIndex = 12;
            this.progressBarYT.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Converter video do Youtube em MP3 ";
            // 
            // progressBarNormal
            // 
            this.progressBarNormal.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBarNormal.Location = new System.Drawing.Point(9, 112);
            this.progressBarNormal.Name = "progressBarNormal";
            this.progressBarNormal.Size = new System.Drawing.Size(464, 11);
            this.progressBarNormal.TabIndex = 14;
            this.progressBarNormal.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblErroPrim);
            this.panel1.Controls.Add(this.txtSelect);
            this.panel1.Controls.Add(this.progressBarNormal);
            this.panel1.Controls.Add(this.OpenTo);
            this.panel1.Controls.Add(this.BtnCopyTo);
            this.panel1.Controls.Add(this.BtnConvert);
            this.panel1.Controls.Add(this.txtSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 162);
            this.panel1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(366, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "NReco";
            // 
            // lblErroPrim
            // 
            this.lblErroPrim.AutoSize = true;
            this.lblErroPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroPrim.ForeColor = System.Drawing.Color.Red;
            this.lblErroPrim.Location = new System.Drawing.Point(444, 134);
            this.lblErroPrim.Name = "lblErroPrim";
            this.lblErroPrim.Size = new System.Drawing.Size(52, 17);
            this.lblErroPrim.TabIndex = 15;
            this.lblErroPrim.Text = "label7";
            this.lblErroPrim.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnBaixar);
            this.panel2.Controls.Add(this.progressBarBaixar);
            this.panel2.Controls.Add(this.txtBaixar);
            this.panel2.Controls.Add(this.txtYtSelect);
            this.panel2.Controls.Add(this.bntYT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.progressBarYT);
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 167);
            this.panel2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(344, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "VideoLibrary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Baixar MP4 do Youtube  360p";
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(482, 119);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(75, 36);
            this.btnBaixar.TabIndex = 16;
            this.btnBaixar.Text = "Baixar do Youtube";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // progressBarBaixar
            // 
            this.progressBarBaixar.ForeColor = System.Drawing.Color.Red;
            this.progressBarBaixar.Location = new System.Drawing.Point(12, 145);
            this.progressBarBaixar.Name = "progressBarBaixar";
            this.progressBarBaixar.Size = new System.Drawing.Size(464, 10);
            this.progressBarBaixar.TabIndex = 15;
            this.progressBarBaixar.Visible = false;
            // 
            // txtBaixar
            // 
            this.txtBaixar.Location = new System.Drawing.Point(11, 119);
            this.txtBaixar.Name = "txtBaixar";
            this.txtBaixar.Size = new System.Drawing.Size(463, 20);
            this.txtBaixar.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblErroTxt);
            this.panel3.Controls.Add(this.lblErroOpcao);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.checkVideo);
            this.panel3.Controls.Add(this.checkAudio);
            this.panel3.Controls.Add(this.btnYtExplode);
            this.panel3.Controls.Add(this.txtYtExplode);
            this.panel3.Location = new System.Drawing.Point(-2, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 120);
            this.panel3.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(335, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "YoutubeExplode";
            // 
            // lblErroTxt
            // 
            this.lblErroTxt.AutoSize = true;
            this.lblErroTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroTxt.ForeColor = System.Drawing.Color.Orange;
            this.lblErroTxt.Location = new System.Drawing.Point(14, 87);
            this.lblErroTxt.Name = "lblErroTxt";
            this.lblErroTxt.Size = new System.Drawing.Size(74, 17);
            this.lblErroTxt.TabIndex = 7;
            this.lblErroTxt.Text = "Link vazio!";
            this.lblErroTxt.Visible = false;
            // 
            // lblErroOpcao
            // 
            this.lblErroOpcao.AutoSize = true;
            this.lblErroOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroOpcao.ForeColor = System.Drawing.Color.Orange;
            this.lblErroOpcao.Location = new System.Drawing.Point(484, 83);
            this.lblErroOpcao.Name = "lblErroOpcao";
            this.lblErroOpcao.Size = new System.Drawing.Size(134, 17);
            this.lblErroOpcao.TabIndex = 6;
            this.lblErroOpcao.Text = "Selecione o formato";
            this.lblErroOpcao.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Escolha a opção";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Link do youtube";
            // 
            // checkVideo
            // 
            this.checkVideo.AutoSize = true;
            this.checkVideo.Location = new System.Drawing.Point(544, 63);
            this.checkVideo.Name = "checkVideo";
            this.checkVideo.Size = new System.Drawing.Size(53, 17);
            this.checkVideo.TabIndex = 3;
            this.checkVideo.Text = "Video";
            this.checkVideo.UseVisualStyleBackColor = true;
            // 
            // checkAudio
            // 
            this.checkAudio.AutoSize = true;
            this.checkAudio.BackColor = System.Drawing.Color.DimGray;
            this.checkAudio.Location = new System.Drawing.Point(487, 62);
            this.checkAudio.Name = "checkAudio";
            this.checkAudio.Size = new System.Drawing.Size(53, 17);
            this.checkAudio.TabIndex = 2;
            this.checkAudio.Text = "Audio";
            this.checkAudio.UseVisualStyleBackColor = false;
            // 
            // btnYtExplode
            // 
            this.btnYtExplode.Location = new System.Drawing.Point(657, 56);
            this.btnYtExplode.Name = "btnYtExplode";
            this.btnYtExplode.Size = new System.Drawing.Size(75, 23);
            this.btnYtExplode.TabIndex = 1;
            this.btnYtExplode.Text = "Converter";
            this.btnYtExplode.UseVisualStyleBackColor = true;
            this.btnYtExplode.Click += new System.EventHandler(this.btnYtExplode_Click);
            // 
            // txtYtExplode
            // 
            this.txtYtExplode.Location = new System.Drawing.Point(14, 60);
            this.txtYtExplode.Name = "txtYtExplode";
            this.txtYtExplode.Size = new System.Drawing.Size(462, 20);
            this.txtYtExplode.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenTo;
        private System.Windows.Forms.Button BtnCopyTo;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntYT;
        private System.Windows.Forms.TextBox txtYtSelect;
        private System.Windows.Forms.ProgressBar progressBarYT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarNormal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.ProgressBar progressBarBaixar;
        private System.Windows.Forms.TextBox txtBaixar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnYtExplode;
        private System.Windows.Forms.TextBox txtYtExplode;
        private System.Windows.Forms.CheckBox checkVideo;
        private System.Windows.Forms.CheckBox checkAudio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErroTxt;
        private System.Windows.Forms.Label lblErroOpcao;
        private System.Windows.Forms.Label lblErroPrim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}

