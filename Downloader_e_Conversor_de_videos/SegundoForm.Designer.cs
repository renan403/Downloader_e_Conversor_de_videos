namespace Downloader_e_Conversor_de_videos
{
    partial class SegundoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
         private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegundoForm));
            this.btnBaixar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeVideo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.comboBoxAudio = new System.Windows.Forms.ComboBox();
            this.lblDonwloadAudio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaixar
            // 
            this.btnBaixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixar.Location = new System.Drawing.Point(428, 83);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(116, 41);
            this.btnBaixar.TabIndex = 2;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.bntBaixar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo do video:";
            // 
            // lblNomeVideo
            // 
            this.lblNomeVideo.AutoSize = true;
            this.lblNomeVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVideo.Location = new System.Drawing.Point(138, 9);
            this.lblNomeVideo.Name = "lblNomeVideo";
            this.lblNomeVideo.Size = new System.Drawing.Size(51, 20);
            this.lblNomeVideo.TabIndex = 5;
            this.lblNomeVideo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Canal:";
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanal.Location = new System.Drawing.Point(68, 38);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(51, 20);
            this.lblCanal.TabIndex = 7;
            this.lblCanal.Text = "label3";
            // 
            // comboBoxAudio
            // 
            this.comboBoxAudio.FormattingEnabled = true;
            this.comboBoxAudio.Location = new System.Drawing.Point(12, 103);
            this.comboBoxAudio.Name = "comboBoxAudio";
            this.comboBoxAudio.Size = new System.Drawing.Size(189, 21);
            this.comboBoxAudio.TabIndex = 8;
            this.comboBoxAudio.Text = "Escolha o formato e a qualidade";
            this.comboBoxAudio.Visible = false;
            // 
            // lblDonwloadAudio
            // 
            this.lblDonwloadAudio.AutoSize = true;
            this.lblDonwloadAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonwloadAudio.ForeColor = System.Drawing.Color.Coral;
            this.lblDonwloadAudio.Location = new System.Drawing.Point(231, 107);
            this.lblDonwloadAudio.Name = "lblDonwloadAudio";
            this.lblDonwloadAudio.Size = new System.Drawing.Size(52, 17);
            this.lblDonwloadAudio.TabIndex = 11;
            this.lblDonwloadAudio.Text = "label4";
            this.lblDonwloadAudio.Visible = false;
            // 
            // SegundoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 252);
            this.Controls.Add(this.lblDonwloadAudio);
            this.Controls.Add(this.comboBoxAudio);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomeVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBaixar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SegundoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SegundoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.ComboBox comboBoxAudio;
        private System.Windows.Forms.Label lblDonwloadAudio;
    }
}