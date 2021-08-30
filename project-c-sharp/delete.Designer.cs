
namespace project_c_sharp
{
    partial class delete
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.deletebutton = new Guna.UI2.WinForms.Guna2Button();
            this.std_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.Common.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.Common.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 19;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.White;
            this.deletebutton.BorderRadius = 15;
            this.deletebutton.CheckedState.Parent = this.deletebutton;
            this.deletebutton.CustomImages.Parent = this.deletebutton;
            this.deletebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deletebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deletebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deletebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deletebutton.DisabledState.Parent = this.deletebutton;
            this.deletebutton.FillColor = System.Drawing.Color.Red;
            this.deletebutton.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.White;
            this.deletebutton.HoverState.Parent = this.deletebutton;
            this.deletebutton.Location = new System.Drawing.Point(491, 440);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(4);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.ShadowDecoration.Parent = this.deletebutton;
            this.deletebutton.Size = new System.Drawing.Size(171, 45);
            this.deletebutton.TabIndex = 46;
            this.deletebutton.Text = "delete";
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // std_id
            // 
            this.std_id.BackColor = System.Drawing.Color.White;
            this.std_id.BorderRadius = 20;
            this.std_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.std_id.DefaultText = "";
            this.std_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.std_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.std_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.std_id.DisabledState.Parent = this.std_id;
            this.std_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.std_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.std_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.std_id.FocusedState.Parent = this.std_id;
            this.std_id.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_id.ForeColor = System.Drawing.Color.Black;
            this.std_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.std_id.HoverState.Parent = this.std_id;
            this.std_id.Location = new System.Drawing.Point(489, 364);
            this.std_id.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.std_id.Name = "std_id";
            this.std_id.PasswordChar = '\0';
            this.std_id.PlaceholderText = "";
            this.std_id.SelectedText = "";
            this.std_id.ShadowDecoration.Parent = this.std_id;
            this.std_id.Size = new System.Drawing.Size(409, 47);
            this.std_id.TabIndex = 45;
            this.std_id.TextChanged += new System.EventHandler(this.std_id_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(374, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 37);
            this.label5.TabIndex = 44;
            this.label5.Text = "std_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(448, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 55);
            this.label1.TabIndex = 47;
            this.label1.Text = "Delete Your Reservation";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.BorderRadius = 15;
            this.back.CheckedState.Parent = this.back;
            this.back.CustomImages.Parent = this.back;
            this.back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back.DisabledState.Parent = this.back;
            this.back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.back.Font = new System.Drawing.Font("Nunito", 13F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.HoverState.Parent = this.back;
            this.back.Image = global::project_c_sharp.Properties.Resources.Group_98;
            this.back.ImageSize = new System.Drawing.Size(30, 30);
            this.back.Location = new System.Drawing.Point(1047, 87);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.ShadowDecoration.Parent = this.back;
            this.back.Size = new System.Drawing.Size(177, 51);
            this.back.TabIndex = 48;
            this.back.Text = "  back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.label5);
            this.Name = "delete";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI2.WinForms.Guna2Button deletebutton;
        private Guna.UI2.WinForms.Guna2TextBox std_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button back;
    }
}