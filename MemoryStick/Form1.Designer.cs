namespace MemoryStick
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            panelListWord = new Panel();
            panelButtonSortWord = new Panel();
            labelSortWord = new Label();
            panelButtonAddWord = new Panel();
            labelAddWord = new Label();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            tabControl = new TabControl();
            imageList1 = new ImageList(components);
            panelSideMenu.SuspendLayout();
            panelButtonSortWord.SuspendLayout();
            panelButtonAddWord.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = SystemColors.MenuHighlight;
            panelSideMenu.Controls.Add(panelListWord);
            panelSideMenu.Controls.Add(panelButtonSortWord);
            panelSideMenu.Controls.Add(panelButtonAddWord);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(152, 401);
            panelSideMenu.TabIndex = 0;
            // 
            // panelListWord
            // 
            panelListWord.BackColor = Color.Transparent;
            panelListWord.Dock = DockStyle.Top;
            panelListWord.Location = new Point(0, 300);
            panelListWord.Name = "panelListWord";
            panelListWord.Size = new Size(152, 100);
            panelListWord.TabIndex = 3;
            // 
            // panelButtonSortWord
            // 
            panelButtonSortWord.BackColor = Color.Transparent;
            panelButtonSortWord.Controls.Add(labelSortWord);
            panelButtonSortWord.Dock = DockStyle.Top;
            panelButtonSortWord.Location = new Point(0, 200);
            panelButtonSortWord.Name = "panelButtonSortWord";
            panelButtonSortWord.Size = new Size(152, 100);
            panelButtonSortWord.TabIndex = 2;
            panelButtonSortWord.MouseClick += panelButtonSortWord_MouseClick;
            panelButtonSortWord.MouseLeave += panelButtonSortWord_MouseLeave;
            panelButtonSortWord.MouseHover += panelButtonSortWord_MouseHover;
            // 
            // labelSortWord
            // 
            labelSortWord.AutoSize = true;
            labelSortWord.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSortWord.ForeColor = SystemColors.ControlLightLight;
            labelSortWord.Location = new Point(12, 40);
            labelSortWord.Name = "labelSortWord";
            labelSortWord.Size = new Size(86, 19);
            labelSortWord.TabIndex = 1;
            labelSortWord.Text = "Sort Word";
            // 
            // panelButtonAddWord
            // 
            panelButtonAddWord.BackColor = Color.Transparent;
            panelButtonAddWord.Controls.Add(labelAddWord);
            panelButtonAddWord.Dock = DockStyle.Top;
            panelButtonAddWord.Location = new Point(0, 100);
            panelButtonAddWord.Name = "panelButtonAddWord";
            panelButtonAddWord.Size = new Size(152, 100);
            panelButtonAddWord.TabIndex = 1;
            panelButtonAddWord.MouseClick += panelButtonAddWord_MouseClick;
            panelButtonAddWord.MouseLeave += panelButtonAddWord_MouseLeave;
            panelButtonAddWord.MouseHover += panelButtonAddWord_MouseHover;
            // 
            // labelAddWord
            // 
            labelAddWord.AutoSize = true;
            labelAddWord.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddWord.ForeColor = SystemColors.ControlLightLight;
            labelAddWord.Location = new Point(12, 45);
            labelAddWord.Name = "labelAddWord";
            labelAddWord.Size = new Size(88, 19);
            labelAddWord.TabIndex = 0;
            labelAddWord.Text = "New Word";
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.Menu;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(152, 100);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(152, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(648, 401);
            tabControl.TabIndex = 2;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "IconeTransladePNG.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 401);
            Controls.Add(tabControl);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory Stick - By FelipeF-soares";
            panelSideMenu.ResumeLayout(false);
            panelButtonSortWord.ResumeLayout(false);
            panelButtonSortWord.PerformLayout();
            panelButtonAddWord.ResumeLayout(false);
            panelButtonAddWord.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelListWord;
        private Panel panelButtonSortWord;
        private Panel panelButtonAddWord;
        private Panel panelLogo;
        private TabControl tabControl;
        private Label labelAddWord;
        private Label labelSortWord;
        private PictureBox pictureBox1;
        private ImageList imageList1;
    }
}