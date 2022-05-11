namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.mtrackEstatus = new XComponent.SliderBar.MACTrackBar();
            this.mtrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lblCancion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.Location = new System.Drawing.Point(12, 195);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(551, 121);
            this.lstCanciones.TabIndex = 1;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // mtrackEstatus
            // 
            this.mtrackEstatus.BackColor = System.Drawing.Color.Transparent;
            this.mtrackEstatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackEstatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackEstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackEstatus.IndentHeight = 6;
            this.mtrackEstatus.Location = new System.Drawing.Point(12, 36);
            this.mtrackEstatus.Maximum = 10;
            this.mtrackEstatus.Minimum = 0;
            this.mtrackEstatus.Name = "mtrackEstatus";
            this.mtrackEstatus.Size = new System.Drawing.Size(156, 22);
            this.mtrackEstatus.TabIndex = 3;
            this.mtrackEstatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackEstatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtrackEstatus.TickHeight = 4;
            this.mtrackEstatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackEstatus.TrackerColor = System.Drawing.Color.Red;
            this.mtrackEstatus.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtrackEstatus.TrackLineColor = System.Drawing.Color.Red;
            this.mtrackEstatus.TrackLineHeight = 3;
            this.mtrackEstatus.TrackLineSelectedColor = System.Drawing.Color.Red;
            this.mtrackEstatus.Value = 0;
            this.mtrackEstatus.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1_ValueChanged);
            // 
            // mtrackVolumen
            // 
            this.mtrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mtrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackVolumen.IndentHeight = 6;
            this.mtrackVolumen.Location = new System.Drawing.Point(68, 133);
            this.mtrackVolumen.Maximum = 150;
            this.mtrackVolumen.Minimum = 0;
            this.mtrackVolumen.Name = "mtrackVolumen";
            this.mtrackVolumen.Size = new System.Drawing.Size(148, 22);
            this.mtrackVolumen.TabIndex = 4;
            this.mtrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TickColor = System.Drawing.Color.Red;
            this.mtrackVolumen.TickHeight = 4;
            this.mtrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TrackerColor = System.Drawing.Color.Red;
            this.mtrackVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtrackVolumen.TrackLineColor = System.Drawing.Color.Gray;
            this.mtrackVolumen.TrackLineHeight = 3;
            this.mtrackVolumen.TrackLineSelectedColor = System.Drawing.Color.Red;
            this.mtrackVolumen.Value = 0;
            this.mtrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtrackVolumen_ValueChanged);
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Location = new System.Drawing.Point(9, 9);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(13, 13);
            this.lblCancion.TabIndex = 9;
            this.lblCancion.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(222, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 69);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Prueba.Properties.Resources.encendido__1_;
            this.pictureBox2.Location = new System.Drawing.Point(506, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::Prueba.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(124, 64);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 50);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStop.TabIndex = 8;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::Prueba.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(68, 64);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPlay.TabIndex = 6;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prueba.Properties.Resources.volume_up_4_xxl;
            this.pictureBox1.Location = new System.Drawing.Point(12, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Image = global::Prueba.Properties.Resources.add;
            this.btnAdjuntar.Location = new System.Drawing.Point(12, 64);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(50, 50);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAdjuntar.TabIndex = 2;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(222, 36);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(341, 153);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 321);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtrackVolumen);
            this.Controls.Add(this.mtrackEstatus);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.Reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox btnAdjuntar;
        private XComponent.SliderBar.MACTrackBar mtrackEstatus;
        private XComponent.SliderBar.MACTrackBar mtrackVolumen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

