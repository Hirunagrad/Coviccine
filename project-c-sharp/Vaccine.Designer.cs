
namespace project_c_sharp
{
    partial class Vaccine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.register = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.nic = new Guna.UI2.WinForms.Guna2TextBox();
            this.age = new Guna.UI2.WinForms.Guna2TextBox();
            this.batch = new Guna.UI2.WinForms.Guna2TextBox();
            this.std_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.errorOne = new System.Windows.Forms.Label();
            this.errorTwo = new System.Windows.Forms.Label();
            this.errorThree = new System.Windows.Forms.Label();
            this.levelFour = new System.Windows.Forms.Label();
            this.levelFive = new System.Windows.Forms.Label();
            this.levelSix = new System.Windows.Forms.Label();
            this.levelSeven = new System.Windows.Forms.Label();
            this.vaccinesType = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(127, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(128, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(128, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vaccine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(128, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(128, 521);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Batch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(248)))));
            this.label6.Location = new System.Drawing.Point(250, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(717, 83);
            this.label6.TabIndex = 5;
            this.label6.Text = "Register for Vaccination";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.White;
            this.register.BorderRadius = 20;
            this.register.CheckedState.Parent = this.register;
            this.register.CustomImages.Parent = this.register;
            this.register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.register.DisabledState.Parent = this.register;
            this.register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(248)))));
            this.register.Font = new System.Drawing.Font("Nunito ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.HoverState.Parent = this.register;
            this.register.Location = new System.Drawing.Point(264, 663);
            this.register.Margin = new System.Windows.Forms.Padding(4);
            this.register.Name = "register";
            this.register.ShadowDecoration.Parent = this.register;
            this.register.Size = new System.Drawing.Size(240, 51);
            this.register.TabIndex = 11;
            this.register.Text = "Register";
            this.register.Click += new System.EventHandler(this.gunabutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project_c_sharp.Properties.Resources.MicrosoftTeams_image__2_;
            this.pictureBox1.Location = new System.Drawing.Point(829, 433);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.BorderRadius = 20;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.DefaultText = "";
            this.name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.DisabledState.Parent = this.name;
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.FocusedState.Parent = this.name;
            this.name.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(252, 203);
            this.name.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "";
            this.name.SelectedText = "";
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(509, 46);
            this.name.TabIndex = 18;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // nic
            // 
            this.nic.BackColor = System.Drawing.Color.White;
            this.nic.BorderRadius = 20;
            this.nic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nic.DefaultText = "";
            this.nic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nic.DisabledState.Parent = this.nic;
            this.nic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.nic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nic.FocusedState.Parent = this.nic;
            this.nic.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nic.ForeColor = System.Drawing.Color.Black;
            this.nic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nic.HoverState.Parent = this.nic;
            this.nic.Location = new System.Drawing.Point(252, 278);
            this.nic.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.nic.Name = "nic";
            this.nic.PasswordChar = '\0';
            this.nic.PlaceholderText = "";
            this.nic.SelectedText = "";
            this.nic.ShadowDecoration.Parent = this.nic;
            this.nic.Size = new System.Drawing.Size(509, 46);
            this.nic.TabIndex = 19;
            this.nic.TextChanged += new System.EventHandler(this.nic_TextChanged);
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.White;
            this.age.BorderRadius = 20;
            this.age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age.DefaultText = "";
            this.age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.DisabledState.Parent = this.age;
            this.age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age.FocusedState.Parent = this.age;
            this.age.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.Black;
            this.age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age.HoverState.Parent = this.age;
            this.age.Location = new System.Drawing.Point(253, 437);
            this.age.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.PlaceholderText = "";
            this.age.SelectedText = "";
            this.age.ShadowDecoration.Parent = this.age;
            this.age.Size = new System.Drawing.Size(509, 46);
            this.age.TabIndex = 21;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // batch
            // 
            this.batch.BackColor = System.Drawing.Color.White;
            this.batch.BorderRadius = 20;
            this.batch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.batch.DefaultText = "";
            this.batch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.batch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.batch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.batch.DisabledState.Parent = this.batch;
            this.batch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.batch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.batch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.batch.FocusedState.Parent = this.batch;
            this.batch.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch.ForeColor = System.Drawing.Color.Black;
            this.batch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.batch.HoverState.Parent = this.batch;
            this.batch.Location = new System.Drawing.Point(252, 514);
            this.batch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.batch.Name = "batch";
            this.batch.PasswordChar = '\0';
            this.batch.PlaceholderText = "";
            this.batch.SelectedText = "";
            this.batch.ShadowDecoration.Parent = this.batch;
            this.batch.Size = new System.Drawing.Size(509, 46);
            this.batch.TabIndex = 22;
            this.batch.TextChanged += new System.EventHandler(this.batch_TextChanged);
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
            this.std_id.Location = new System.Drawing.Point(254, 126);
            this.std_id.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.std_id.Name = "std_id";
            this.std_id.PasswordChar = '\0';
            this.std_id.PlaceholderText = "";
            this.std_id.SelectedText = "";
            this.std_id.ShadowDecoration.Parent = this.std_id;
            this.std_id.Size = new System.Drawing.Size(509, 46);
            this.std_id.TabIndex = 23;
            this.std_id.TextChanged += new System.EventHandler(this.std_id_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(128, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 37);
            this.label7.TabIndex = 24;
            this.label7.Text = "std id";
            // 
            // date
            // 
            this.date.BorderRadius = 19;
            this.date.CheckedState.Parent = this.date;
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.date.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.date.HoverState.ForeColor = System.Drawing.Color.Black;
            this.date.HoverState.Parent = this.date;
            this.date.Location = new System.Drawing.Point(254, 588);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.ShadowDecoration.Parent = this.date;
            this.date.Size = new System.Drawing.Size(287, 46);
            this.date.TabIndex = 28;
            this.date.Value = new System.DateTime(2021, 8, 26, 19, 24, 30, 395);
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(137, 597);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 37);
            this.label9.TabIndex = 29;
            this.label9.Text = "Date";
            // 
            // errorOne
            // 
            this.errorOne.AutoSize = true;
            this.errorOne.BackColor = System.Drawing.SystemColors.Window;
            this.errorOne.ForeColor = System.Drawing.Color.Red;
            this.errorOne.Location = new System.Drawing.Point(270, 181);
            this.errorOne.Name = "errorOne";
            this.errorOne.Size = new System.Drawing.Size(0, 17);
            this.errorOne.TabIndex = 30;
            this.errorOne.Click += new System.EventHandler(this.errorOne_Click);
            // 
            // errorTwo
            // 
            this.errorTwo.AutoSize = true;
            this.errorTwo.ForeColor = System.Drawing.Color.Red;
            this.errorTwo.Location = new System.Drawing.Point(270, 256);
            this.errorTwo.Name = "errorTwo";
            this.errorTwo.Size = new System.Drawing.Size(0, 17);
            this.errorTwo.TabIndex = 31;
            this.errorTwo.Click += new System.EventHandler(this.errorTwo_Click);
            // 
            // errorThree
            // 
            this.errorThree.AutoSize = true;
            this.errorThree.ForeColor = System.Drawing.Color.Red;
            this.errorThree.Location = new System.Drawing.Point(270, 333);
            this.errorThree.Name = "errorThree";
            this.errorThree.Size = new System.Drawing.Size(0, 17);
            this.errorThree.TabIndex = 32;
            this.errorThree.Click += new System.EventHandler(this.errorThree_Click);
            // 
            // levelFour
            // 
            this.levelFour.AutoSize = true;
            this.levelFour.ForeColor = System.Drawing.Color.Red;
            this.levelFour.Location = new System.Drawing.Point(270, 411);
            this.levelFour.Name = "levelFour";
            this.levelFour.Size = new System.Drawing.Size(0, 17);
            this.levelFour.TabIndex = 33;
            this.levelFour.Click += new System.EventHandler(this.levelFour_Click);
            // 
            // levelFive
            // 
            this.levelFive.AutoSize = true;
            this.levelFive.ForeColor = System.Drawing.Color.Red;
            this.levelFive.Location = new System.Drawing.Point(270, 492);
            this.levelFive.Name = "levelFive";
            this.levelFive.Size = new System.Drawing.Size(0, 17);
            this.levelFive.TabIndex = 34;
            this.levelFive.Click += new System.EventHandler(this.levelFive_Click);
            // 
            // levelSix
            // 
            this.levelSix.AutoSize = true;
            this.levelSix.ForeColor = System.Drawing.Color.Red;
            this.levelSix.Location = new System.Drawing.Point(270, 568);
            this.levelSix.Name = "levelSix";
            this.levelSix.Size = new System.Drawing.Size(0, 17);
            this.levelSix.TabIndex = 35;
            this.levelSix.Click += new System.EventHandler(this.levelSix_Click);
            // 
            // levelSeven
            // 
            this.levelSeven.AutoSize = true;
            this.levelSeven.ForeColor = System.Drawing.Color.Red;
            this.levelSeven.Location = new System.Drawing.Point(270, 642);
            this.levelSeven.Name = "levelSeven";
            this.levelSeven.Size = new System.Drawing.Size(0, 17);
            this.levelSeven.TabIndex = 36;
            this.levelSeven.Click += new System.EventHandler(this.levelSeven_Click);
            // 
            // vaccinesType
            // 
            this.vaccinesType.BackColor = System.Drawing.Color.Transparent;
            this.vaccinesType.BorderRadius = 19;
            this.vaccinesType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.vaccinesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vaccinesType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.vaccinesType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vaccinesType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vaccinesType.FocusedState.Parent = this.vaccinesType;
            this.vaccinesType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.vaccinesType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.vaccinesType.HoverState.Parent = this.vaccinesType;
            this.vaccinesType.ItemHeight = 30;
            this.vaccinesType.Items.AddRange(new object[] {
            "sinopharm",
            "pfizer",
            "astrazeneca"});
            this.vaccinesType.ItemsAppearance.Parent = this.vaccinesType;
            this.vaccinesType.Location = new System.Drawing.Point(254, 363);
            this.vaccinesType.Name = "vaccinesType";
            this.vaccinesType.ShadowDecoration.Parent = this.vaccinesType;
            this.vaccinesType.Size = new System.Drawing.Size(509, 36);
            this.vaccinesType.TabIndex = 37;
            // 
            // Vaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.vaccinesType);
            this.Controls.Add(this.levelSeven);
            this.Controls.Add(this.levelSix);
            this.Controls.Add(this.levelFive);
            this.Controls.Add(this.levelFour);
            this.Controls.Add(this.errorThree);
            this.Controls.Add(this.errorTwo);
            this.Controls.Add(this.errorOne);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.age);
            this.Controls.Add(this.nic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vaccine";
            this.Size = new System.Drawing.Size(1189, 753);
            this.Load += new System.EventHandler(this.Vaccine_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private Guna.UI2.WinForms.Guna2TextBox nic;
        private Guna.UI2.WinForms.Guna2TextBox age;
        private Guna.UI2.WinForms.Guna2TextBox batch;
        private Guna.UI2.WinForms.Guna2TextBox std_id;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label errorOne;
        private System.Windows.Forms.Label errorTwo;
        private System.Windows.Forms.Label errorThree;
        private System.Windows.Forms.Label levelFour;
        private System.Windows.Forms.Label levelFive;
        private System.Windows.Forms.Label levelSix;
        private System.Windows.Forms.Label levelSeven;
        private Guna.UI2.WinForms.Guna2ComboBox vaccinesType;
    }
}
