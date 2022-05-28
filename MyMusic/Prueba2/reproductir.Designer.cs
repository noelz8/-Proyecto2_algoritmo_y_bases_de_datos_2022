namespace Prueba2
{
    partial class reproductir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reproductir));
            this.lblCancion = new System.Windows.Forms.Label();
            this.mtrackEstatus = new System.Windows.Forms.TrackBar();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mtrackVolumen = new System.Windows.Forms.TrackBar();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mtrackEstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtrackVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.BackColor = System.Drawing.Color.White;
            this.lblCancion.Location = new System.Drawing.Point(11, 9);
            this.lblCancion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(13, 13);
            this.lblCancion.TabIndex = 9;
            this.lblCancion.Text = "--";
            // 
            // mtrackEstatus
            // 
            this.mtrackEstatus.BackColor = System.Drawing.Color.IndianRed;
            this.mtrackEstatus.Location = new System.Drawing.Point(2, 44);
            this.mtrackEstatus.Margin = new System.Windows.Forms.Padding(2);
            this.mtrackEstatus.Name = "mtrackEstatus";
            this.mtrackEstatus.Size = new System.Drawing.Size(696, 45);
            this.mtrackEstatus.TabIndex = 1;
            this.mtrackEstatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackEstatus.Scroll += new System.EventHandler(this.mtrackEstatus_Scroll);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(12, 238);
            this.Reproductor.Margin = new System.Windows.Forms.Padding(2);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(545, 136);
            this.Reproductor.TabIndex = 2;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            this.Reproductor.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Image = global::Prueba2.Properties.Resources.add;
            this.btnAdjuntar.Location = new System.Drawing.Point(11, 110);
            this.btnAdjuntar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(50, 50);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAdjuntar.TabIndex = 3;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::Prueba2.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(70, 110);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPlay.TabIndex = 4;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::Prueba2.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(127, 110);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 50);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStop.TabIndex = 5;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Prueba2.Properties.Resources.volume_up_4_xxl;
            this.pictureBox4.Location = new System.Drawing.Point(11, 174);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // mtrackVolumen
            // 
            this.mtrackVolumen.LargeChange = 2;
            this.mtrackVolumen.Location = new System.Drawing.Point(70, 189);
            this.mtrackVolumen.Margin = new System.Windows.Forms.Padding(2);
            this.mtrackVolumen.Maximum = 150;
            this.mtrackVolumen.Name = "mtrackVolumen";
            this.mtrackVolumen.Size = new System.Drawing.Size(160, 45);
            this.mtrackVolumen.TabIndex = 4;
            this.mtrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.Location = new System.Drawing.Point(12, 324);
            this.lstCanciones.Margin = new System.Windows.Forms.Padding(2);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(545, 134);
            this.lstCanciones.TabIndex = 9;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Prueba2.Properties.Resources.encendido__1_;
            this.pictureBox5.Location = new System.Drawing.Point(655, 408);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // reproductir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(709, 469);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.mtrackVolumen);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.mtrackEstatus);
            this.Controls.Add(this.lblCancion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "reproductir";
            this.Text = "reproductir";
            this.Load += new System.EventHandler(this.reproductir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mtrackEstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtrackVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.TrackBar mtrackEstatus;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.PictureBox btnAdjuntar;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar mtrackVolumen;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
    }
}