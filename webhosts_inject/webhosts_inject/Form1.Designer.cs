namespace webhosts_inject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skeetGroupBox1 = new SkeetUI.skeetGroupBox();
            this.Hosts_Box = new System.Windows.Forms.RichTextBox();
            this.Pull_Button = new SkeetUI.skeetButton();
            this.Insert_Button = new SkeetUI.skeetButton();
            this.Exit_Button = new SkeetUI.skeetButton();
            this.output_box = new System.Windows.Forms.RichTextBox();
            this.url_box = new Siticone.UI.WinForms.SiticoneTextBox();
            this.Autodesk_btn = new SkeetUI.skeetButton();
            this.Adobe_btn = new SkeetUI.skeetButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skeetGroupBox2 = new SkeetUI.skeetGroupBox();
            this.skeetGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skeetGroupBox1
            // 
            this.skeetGroupBox1.BackColor = System.Drawing.Color.Black;
            this.skeetGroupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skeetGroupBox1.BackgroundImage")));
            this.skeetGroupBox1.ButtonText = "Hosts list";
            this.skeetGroupBox1.Controls.Add(this.Hosts_Box);
            this.skeetGroupBox1.Location = new System.Drawing.Point(12, 25);
            this.skeetGroupBox1.Name = "skeetGroupBox1";
            this.skeetGroupBox1.Size = new System.Drawing.Size(396, 324);
            this.skeetGroupBox1.TabIndex = 0;
            // 
            // Hosts_Box
            // 
            this.Hosts_Box.BackColor = System.Drawing.Color.Black;
            this.Hosts_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Hosts_Box.ForeColor = System.Drawing.Color.White;
            this.Hosts_Box.Location = new System.Drawing.Point(3, 14);
            this.Hosts_Box.Name = "Hosts_Box";
            this.Hosts_Box.Size = new System.Drawing.Size(390, 307);
            this.Hosts_Box.TabIndex = 0;
            this.Hosts_Box.Text = "";
            // 
            // Pull_Button
            // 
            this.Pull_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pull_Button.BackgroundImage")));
            this.Pull_Button.ButtonEnabled = true;
            this.Pull_Button.ButtonText = "Pull";
            this.Pull_Button.Location = new System.Drawing.Point(411, 67);
            this.Pull_Button.Name = "Pull_Button";
            this.Pull_Button.Size = new System.Drawing.Size(146, 40);
            this.Pull_Button.TabIndex = 1;
            this.Pull_Button.Click += new System.EventHandler(this.Pull_Button_Click);
            // 
            // Insert_Button
            // 
            this.Insert_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Insert_Button.BackgroundImage")));
            this.Insert_Button.ButtonEnabled = true;
            this.Insert_Button.ButtonText = "Insert";
            this.Insert_Button.Location = new System.Drawing.Point(411, 113);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(146, 40);
            this.Insert_Button.TabIndex = 2;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_Button.BackgroundImage")));
            this.Exit_Button.ButtonEnabled = true;
            this.Exit_Button.ButtonText = "Exit";
            this.Exit_Button.Location = new System.Drawing.Point(411, 370);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(146, 40);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // output_box
            // 
            this.output_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.output_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_box.ForeColor = System.Drawing.Color.YellowGreen;
            this.output_box.Location = new System.Drawing.Point(12, 355);
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.Size = new System.Drawing.Size(393, 55);
            this.output_box.TabIndex = 4;
            this.output_box.Text = "Тут мог быть Exception, но видимо не сейчас...";
            // 
            // url_box
            // 
            this.url_box.BackColor = System.Drawing.Color.Transparent;
            this.url_box.BorderColor = System.Drawing.Color.Transparent;
            this.url_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url_box.DefaultText = "";
            this.url_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.url_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.url_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url_box.DisabledState.Parent = this.url_box;
            this.url_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url_box.FillColor = System.Drawing.Color.Transparent;
            this.url_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url_box.FocusedState.Parent = this.url_box;
            this.url_box.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url_box.HoveredState.Parent = this.url_box;
            this.url_box.Location = new System.Drawing.Point(411, 25);
            this.url_box.Name = "url_box";
            this.url_box.PasswordChar = '\0';
            this.url_box.PlaceholderText = "Own pull URL";
            this.url_box.SelectedText = "";
            this.url_box.ShadowDecoration.Parent = this.url_box;
            this.url_box.Size = new System.Drawing.Size(146, 36);
            this.url_box.TabIndex = 5;
            // 
            // Autodesk_btn
            // 
            this.Autodesk_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Autodesk_btn.BackgroundImage")));
            this.Autodesk_btn.ButtonEnabled = true;
            this.Autodesk_btn.ButtonText = "Autodesk";
            this.Autodesk_btn.Location = new System.Drawing.Point(3, 30);
            this.Autodesk_btn.Name = "Autodesk_btn";
            this.Autodesk_btn.Size = new System.Drawing.Size(133, 21);
            this.Autodesk_btn.TabIndex = 8;
            this.Autodesk_btn.Click += new System.EventHandler(this.Autodesk_btn_clcik);
            // 
            // Adobe_btn
            // 
            this.Adobe_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Adobe_btn.BackgroundImage")));
            this.Adobe_btn.ButtonEnabled = true;
            this.Adobe_btn.ButtonText = "Adobe";
            this.Adobe_btn.Location = new System.Drawing.Point(3, 3);
            this.Adobe_btn.Name = "Adobe_btn";
            this.Adobe_btn.Size = new System.Drawing.Size(133, 21);
            this.Adobe_btn.TabIndex = 7;
            this.Adobe_btn.Click += new System.EventHandler(this.Adobe_btn_clcik);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Autodesk_btn);
            this.panel1.Controls.Add(this.Adobe_btn);
            this.panel1.Location = new System.Drawing.Point(414, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 173);
            this.panel1.TabIndex = 1;
            // 
            // skeetGroupBox2
            // 
            this.skeetGroupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skeetGroupBox2.BackgroundImage")));
            this.skeetGroupBox2.ButtonText = "Application\'s";
            this.skeetGroupBox2.Location = new System.Drawing.Point(411, 159);
            this.skeetGroupBox2.Name = "skeetGroupBox2";
            this.skeetGroupBox2.Size = new System.Drawing.Size(146, 190);
            this.skeetGroupBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.url_box);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Insert_Button);
            this.Controls.Add(this.Pull_Button);
            this.Controls.Add(this.skeetGroupBox1);
            this.Controls.Add(this.skeetGroupBox2);
            this.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(91)))), ((int)(((byte)(184)))));
            this.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(177)))), ((int)(((byte)(218)))));
            this.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hosts Injector";
            this.skeetGroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SkeetUI.skeetGroupBox skeetGroupBox1;
        private System.Windows.Forms.RichTextBox Hosts_Box;
        private SkeetUI.skeetButton Pull_Button;
        private SkeetUI.skeetButton Insert_Button;
        private SkeetUI.skeetButton Exit_Button;
        private System.Windows.Forms.RichTextBox output_box;
        private Siticone.UI.WinForms.SiticoneTextBox url_box;
        private SkeetUI.skeetButton Adobe_btn;
        private SkeetUI.skeetButton Autodesk_btn;
        private System.Windows.Forms.Panel panel1;
        private SkeetUI.skeetGroupBox skeetGroupBox2;
    }
}

