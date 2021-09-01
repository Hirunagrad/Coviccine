
namespace project_c_sharp
{
    partial class loadingscreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.getvaccine = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(631, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 83);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coviccine";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.Common.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.Common.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.Common.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.Common.StateCommon.Border.Rounding = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(571, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hello,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.label3.Location = new System.Drawing.Point(571, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "health is first....";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.BorderRadius = 10;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(541, 574);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(458, 21);
            this.guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.guna2ProgressBar1.TabIndex = 4;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.ValueChanged += new System.EventHandler(this.guna2ProgressBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(759, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // getvaccine
            // 
            this.getvaccine.BackColor = System.Drawing.Color.White;
            this.getvaccine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getvaccine.BorderColor = System.Drawing.Color.LightGray;
            this.getvaccine.BorderRadius = 19;
            this.getvaccine.BorderThickness = 3;
            this.getvaccine.CheckedState.Parent = this.getvaccine;
            this.getvaccine.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.getvaccine.CustomImages.Parent = this.getvaccine;
            this.getvaccine.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.getvaccine.DisabledState.BorderColor = System.Drawing.Color.White;
            this.getvaccine.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.getvaccine.DisabledState.FillColor = System.Drawing.Color.White;
            this.getvaccine.DisabledState.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getvaccine.DisabledState.ForeColor = System.Drawing.Color.White;
            this.getvaccine.DisabledState.Parent = this.getvaccine;
            this.getvaccine.FillColor = System.Drawing.Color.White;
            this.getvaccine.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getvaccine.ForeColor = System.Drawing.Color.Black;
            this.getvaccine.HoverState.BorderColor = System.Drawing.Color.White;
            this.getvaccine.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.getvaccine.HoverState.FillColor = System.Drawing.Color.White;
            this.getvaccine.HoverState.Parent = this.getvaccine;
            this.getvaccine.Image = global::project_c_sharp.Properties.Resources.Group_99;
            this.getvaccine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.getvaccine.ImageSize = new System.Drawing.Size(40, 40);
            this.getvaccine.IndicateFocus = true;
            this.getvaccine.Location = new System.Drawing.Point(628, 431);
            this.getvaccine.Name = "getvaccine";
            this.getvaccine.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.getvaccine.PressedDepth = 10;
            this.getvaccine.ShadowDecoration.BorderRadius = 10;
            this.getvaccine.ShadowDecoration.Parent = this.getvaccine;
            this.getvaccine.Size = new System.Drawing.Size(279, 57);
            this.getvaccine.TabIndex = 3;
            this.getvaccine.Text = "Get Vaccine";
            this.getvaccine.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.getvaccine.Click += new System.EventHandler(this.getvaccine_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project_c_sharp.Properties.Resources.first_01_1_1_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 860);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadingscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.getvaccine;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.getvaccine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loadingscreen";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadingscreen";
            this.Load += new System.EventHandler(this.loadingscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button getvaccine;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Label label4;
    }
}