using M4EC.Properties;

namespace M4EC
{
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.richTextBox15 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label40 = new System.Windows.Forms.Label();
            this.richTextBox14 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown21 = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.richTextBox13 = new System.Windows.Forms.RichTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.importImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.previewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveButton,
            this.saveAsButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(819, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // openButton
            // 
            this.openButton.Image = global::M4EC.Properties.Resources.openButton;
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(56, 22);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::M4EC.Properties.Resources.saveButton;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(51, 22);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Image = global::M4EC.Properties.Resources.saveAsButton;
            this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(67, 22);
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer.Panel1MinSize = 240;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.numericUpDown6);
            this.splitContainer.Panel2.Controls.Add(this.label11);
            this.splitContainer.Panel2MinSize = 120;
            this.splitContainer.Size = new System.Drawing.Size(819, 625);
            this.splitContainer.SplitterDistance = 377;
            this.splitContainer.TabIndex = 2;
            this.splitContainer.TabStop = false;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(40, 13);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown6.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Fire";
            // 
            // previewPanel
            // 
            this.previewPanel.AutoScroll = true;
            this.previewPanel.Controls.Add(this.label41);
            this.previewPanel.Controls.Add(this.richTextBox15);
            this.previewPanel.Controls.Add(this.button1);
            this.previewPanel.Controls.Add(this.pictureBox1);
            this.previewPanel.Controls.Add(this.label40);
            this.previewPanel.Controls.Add(this.richTextBox14);
            this.previewPanel.Controls.Add(this.numericUpDown21);
            this.previewPanel.Controls.Add(this.label39);
            this.previewPanel.Controls.Add(this.numericUpDown10);
            this.previewPanel.Controls.Add(this.label38);
            this.previewPanel.Controls.Add(this.numericUpDown20);
            this.previewPanel.Controls.Add(this.label37);
            this.previewPanel.Controls.Add(this.label36);
            this.previewPanel.Controls.Add(this.richTextBox13);
            this.previewPanel.Controls.Add(this.label35);
            this.previewPanel.Controls.Add(this.richTextBox12);
            this.previewPanel.Controls.Add(this.label33);
            this.previewPanel.Controls.Add(this.richTextBox11);
            this.previewPanel.Controls.Add(this.label3);
            this.previewPanel.Controls.Add(this.label28);
            this.previewPanel.Controls.Add(this.richTextBox6);
            this.previewPanel.Controls.Add(this.label30);
            this.previewPanel.Controls.Add(this.richTextBox7);
            this.previewPanel.Controls.Add(this.label31);
            this.previewPanel.Controls.Add(this.label32);
            this.previewPanel.Controls.Add(this.richTextBox8);
            this.previewPanel.Controls.Add(this.richTextBox9);
            this.previewPanel.Controls.Add(this.label34);
            this.previewPanel.Controls.Add(this.richTextBox10);
            this.previewPanel.Controls.Add(this.numericUpDown19);
            this.previewPanel.Controls.Add(this.label29);
            this.previewPanel.Controls.Add(this.label27);
            this.previewPanel.Controls.Add(this.richTextBox5);
            this.previewPanel.Controls.Add(this.label26);
            this.previewPanel.Controls.Add(this.richTextBox4);
            this.previewPanel.Controls.Add(this.label25);
            this.previewPanel.Controls.Add(this.numericUpDown11);
            this.previewPanel.Controls.Add(this.label17);
            this.previewPanel.Controls.Add(this.numericUpDown12);
            this.previewPanel.Controls.Add(this.label18);
            this.previewPanel.Controls.Add(this.numericUpDown13);
            this.previewPanel.Controls.Add(this.label19);
            this.previewPanel.Controls.Add(this.numericUpDown14);
            this.previewPanel.Controls.Add(this.label20);
            this.previewPanel.Controls.Add(this.numericUpDown15);
            this.previewPanel.Controls.Add(this.label21);
            this.previewPanel.Controls.Add(this.numericUpDown16);
            this.previewPanel.Controls.Add(this.numericUpDown17);
            this.previewPanel.Controls.Add(this.numericUpDown18);
            this.previewPanel.Controls.Add(this.label22);
            this.previewPanel.Controls.Add(this.label23);
            this.previewPanel.Controls.Add(this.label24);
            this.previewPanel.Controls.Add(this.label16);
            this.previewPanel.Controls.Add(this.numericUpDown9);
            this.previewPanel.Controls.Add(this.label14);
            this.previewPanel.Controls.Add(this.numericUpDown8);
            this.previewPanel.Controls.Add(this.label13);
            this.previewPanel.Controls.Add(this.numericUpDown7);
            this.previewPanel.Controls.Add(this.label12);
            this.previewPanel.Controls.Add(this.numericUpDown5);
            this.previewPanel.Controls.Add(this.label10);
            this.previewPanel.Controls.Add(this.numericUpDown4);
            this.previewPanel.Controls.Add(this.label9);
            this.previewPanel.Controls.Add(this.numericUpDown3);
            this.previewPanel.Controls.Add(this.numericUpDown2);
            this.previewPanel.Controls.Add(this.numericUpDown1);
            this.previewPanel.Controls.Add(this.label8);
            this.previewPanel.Controls.Add(this.label7);
            this.previewPanel.Controls.Add(this.label6);
            this.previewPanel.Controls.Add(this.label5);
            this.previewPanel.Controls.Add(this.label4);
            this.previewPanel.Controls.Add(this.richTextBox3);
            this.previewPanel.Controls.Add(this.label2);
            this.previewPanel.Controls.Add(this.richTextBox2);
            this.previewPanel.Controls.Add(this.label1);
            this.previewPanel.Controls.Add(this.richTextBox1);
            this.previewPanel.Controls.Add(this.pictureBox2);
            this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPanel.Location = new System.Drawing.Point(0, 25);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Padding = new System.Windows.Forms.Padding(1);
            this.previewPanel.Size = new System.Drawing.Size(819, 625);
            this.previewPanel.TabIndex = 1;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label41.Location = new System.Drawing.Point(487, 217);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(138, 18);
            this.label41.TabIndex = 88;
            this.label41.Text = "Waste Action String";
            // 
            // richTextBox15
            // 
            this.richTextBox15.Location = new System.Drawing.Point(624, 217);
            this.richTextBox15.Name = "richTextBox15";
            this.richTextBox15.Size = new System.Drawing.Size(188, 25);
            this.richTextBox15.TabIndex = 87;
            this.richTextBox15.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 86;
            this.button1.Text = "Load Sprite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::M4EC.Properties.Resources.check;
            this.pictureBox1.ErrorImage = global::M4EC.Properties.Resources.check24;
            this.pictureBox1.InitialImage = global::M4EC.Properties.Resources.check24;
            this.pictureBox1.Location = new System.Drawing.Point(13, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 199);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint_1);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label40.Location = new System.Drawing.Point(487, 188);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(162, 18);
            this.label40.TabIndex = 84;
            this.label40.Text = "Overworld Sprite Name";
            // 
            // richTextBox14
            // 
            this.richTextBox14.Location = new System.Drawing.Point(653, 184);
            this.richTextBox14.Name = "richTextBox14";
            this.richTextBox14.Size = new System.Drawing.Size(158, 27);
            this.richTextBox14.TabIndex = 83;
            this.richTextBox14.Text = "";
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.Location = new System.Drawing.Point(82, 5);
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown21.TabIndex = 82;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(39, 8);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(43, 13);
            this.label39.TabIndex = 81;
            this.label39.Text = "Options";
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(273, 5);
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown10.TabIndex = 80;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(215, 8);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(56, 13);
            this.label38.TabIndex = 79;
            this.label38.Text = "Immunities";
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown20.Location = new System.Drawing.Point(303, 443);
            this.numericUpDown20.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown20.TabIndex = 77;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label37.Location = new System.Drawing.Point(255, 442);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(42, 18);
            this.label37.TabIndex = 76;
            this.label37.Text = "Level";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label36.Location = new System.Drawing.Point(481, 504);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(70, 18);
            this.label36.TabIndex = 75;
            this.label36.Text = "Thoughts";
            // 
            // richTextBox13
            // 
            this.richTextBox13.Location = new System.Drawing.Point(567, 504);
            this.richTextBox13.Name = "richTextBox13";
            this.richTextBox13.Size = new System.Drawing.Size(249, 25);
            this.richTextBox13.TabIndex = 74;
            this.richTextBox13.Text = "";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label35.Location = new System.Drawing.Point(481, 472);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 18);
            this.label35.TabIndex = 73;
            this.label35.Text = "Telepathy";
            // 
            // richTextBox12
            // 
            this.richTextBox12.Location = new System.Drawing.Point(557, 472);
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.Size = new System.Drawing.Size(260, 25);
            this.richTextBox12.TabIndex = 72;
            this.richTextBox12.Text = "";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label33.Location = new System.Drawing.Point(481, 441);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(75, 18);
            this.label33.TabIndex = 71;
            this.label33.Text = "Subjective";
            // 
            // richTextBox11
            // 
            this.richTextBox11.Location = new System.Drawing.Point(567, 441);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.Size = new System.Drawing.Size(249, 25);
            this.richTextBox11.TabIndex = 70;
            this.richTextBox11.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(481, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Defeat Text";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label28.Location = new System.Drawing.Point(481, 407);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 18);
            this.label28.TabIndex = 68;
            this.label28.Text = "Possessive";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(567, 407);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(249, 25);
            this.richTextBox6.TabIndex = 67;
            this.richTextBox6.Text = "";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label30.Location = new System.Drawing.Point(481, 376);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 18);
            this.label30.TabIndex = 66;
            this.label30.Text = "Name";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(540, 375);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(277, 25);
            this.richTextBox7.TabIndex = 65;
            this.richTextBox7.Text = "";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label31.Location = new System.Drawing.Point(612, 252);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 28);
            this.label31.TabIndex = 64;
            this.label31.Text = "Strings";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label32.Location = new System.Drawing.Point(481, 346);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(108, 18);
            this.label32.TabIndex = 62;
            this.label32.Text = "Encounter Text";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(568, 316);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(249, 25);
            this.richTextBox8.TabIndex = 61;
            this.richTextBox8.Text = "";
            // 
            // richTextBox9
            // 
            this.richTextBox9.Location = new System.Drawing.Point(595, 347);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(222, 25);
            this.richTextBox9.TabIndex = 59;
            this.richTextBox9.Text = "";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label34.Location = new System.Drawing.Point(481, 284);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(48, 18);
            this.label34.TabIndex = 58;
            this.label34.Text = "Article";
            // 
            // richTextBox10
            // 
            this.richTextBox10.Location = new System.Drawing.Point(539, 283);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(277, 25);
            this.richTextBox10.TabIndex = 57;
            this.richTextBox10.Text = "";
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown19.Location = new System.Drawing.Point(303, 320);
            this.numericUpDown19.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown19.TabIndex = 56;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label29.Location = new System.Drawing.Point(488, 40);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 18);
            this.label29.TabIndex = 55;
            this.label29.Text = "AI Name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label27.Location = new System.Drawing.Point(487, 158);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 18);
            this.label27.TabIndex = 53;
            this.label27.Text = "Sprite Name";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(579, 155);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(229, 27);
            this.richTextBox5.TabIndex = 52;
            this.richTextBox5.Text = "";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label26.Location = new System.Drawing.Point(486, 130);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(133, 18);
            this.label26.TabIndex = 51;
            this.label26.Text = "Battle Music Name";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(622, 127);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(186, 25);
            this.richTextBox4.TabIndex = 50;
            this.richTextBox4.Text = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label25.Location = new System.Drawing.Point(608, 7);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 28);
            this.label25.TabIndex = 49;
            this.label25.Text = "General";
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown11.Location = new System.Drawing.Point(284, 380);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown11.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label17.Location = new System.Drawing.Point(255, 380);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 18);
            this.label17.TabIndex = 47;
            this.label17.Text = "IQ";
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown12.Location = new System.Drawing.Point(291, 352);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown12.TabIndex = 46;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label18.Location = new System.Drawing.Point(256, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 18);
            this.label18.TabIndex = 45;
            this.label18.Text = "HP";
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown13.Location = new System.Drawing.Point(311, 526);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown13.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label19.Location = new System.Drawing.Point(256, 526);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 18);
            this.label19.TabIndex = 43;
            this.label19.Text = "Speed";
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown14.Location = new System.Drawing.Point(288, 498);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown14.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label20.Location = new System.Drawing.Point(255, 498);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 18);
            this.label20.TabIndex = 41;
            this.label20.Text = "PP";
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown15.Location = new System.Drawing.Point(321, 470);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown15.TabIndex = 40;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label21.Location = new System.Drawing.Point(255, 472);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 18);
            this.label21.TabIndex = 39;
            this.label21.Text = "Offense";
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown16.Location = new System.Drawing.Point(301, 412);
            this.numericUpDown16.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown16.TabIndex = 38;
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown17.Location = new System.Drawing.Point(575, 101);
            this.numericUpDown17.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(233, 22);
            this.numericUpDown17.TabIndex = 37;
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown18.Location = new System.Drawing.Point(325, 283);
            this.numericUpDown18.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown18.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label22.Location = new System.Drawing.Point(255, 412);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 18);
            this.label22.TabIndex = 35;
            this.label22.Text = "Luck";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label23.Location = new System.Drawing.Point(256, 319);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 18);
            this.label23.TabIndex = 34;
            this.label23.Text = "Guts";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label24.Location = new System.Drawing.Point(256, 286);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 18);
            this.label24.TabIndex = 33;
            this.label24.Text = "Defense";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label16.Location = new System.Drawing.Point(335, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 28);
            this.label16.TabIndex = 32;
            this.label16.Text = "Stats";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.DecimalPlaces = 3;
            this.numericUpDown9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown9.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown9.Location = new System.Drawing.Point(76, 382);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown9.TabIndex = 29;
            this.numericUpDown9.ValueChanged += new System.EventHandler(this.numericUpDown9_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(7, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 18);
            this.label14.TabIndex = 28;
            this.label14.Text = "Physical";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.DecimalPlaces = 3;
            this.numericUpDown8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown8.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown8.Location = new System.Drawing.Point(46, 351);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown8.TabIndex = 27;
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.numericUpDown8_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(7, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Fire";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.DecimalPlaces = 3;
            this.numericUpDown7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown7.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown7.Location = new System.Drawing.Point(48, 515);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown7.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(7, 515);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Wet";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 3;
            this.numericUpDown5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown5.Location = new System.Drawing.Point(68, 480);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown5.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Poison";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 3;
            this.numericUpDown4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown4.Location = new System.Drawing.Point(72, 445);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nausua";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 3;
            this.numericUpDown3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown3.Location = new System.Drawing.Point(40, 415);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown2.Location = new System.Drawing.Point(84, 318);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Location = new System.Drawing.Point(84, 284);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Modifiers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Explosion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Electricity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(488, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Battle Background Name";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(558, 40);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(249, 25);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(488, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Experience";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(667, 74);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(141, 25);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(661, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enemy Name";
            this.label1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(729, 606);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(102, 19);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(4, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(478, 214);
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(189, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(443, 13);
            this.label15.TabIndex = 78;
            this.label15.Text = "remember if it causes you pain to look at this, it caused me much more pain to ma" +
    "ke - enigma";
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Mother 4 enemy file|*.edat";
            this.openImageDialog.Title = "Open Image";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "Mother 4 enemy file|*.edat";
            this.saveImageDialog.Title = "Save Image";
            // 
            // importImageDialog
            // 
            this.importImageDialog.Filter = "Image files|*.bmp;*.png";
            this.importImageDialog.Title = "Import Image";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 650);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip);
            this.DoubleBuffered = true;
            this.Icon = global::M4EC.Properties.Resources.icon;
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M4EC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.previewPanel.ResumeLayout(false);
            this.previewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private global::System.ComponentModel.IContainer components;
		private global::System.Windows.Forms.ToolStrip toolStrip;
		private global::System.Windows.Forms.SplitContainer splitContainer;
		private global::System.Windows.Forms.ToolStripButton openButton;
		private global::System.Windows.Forms.ToolStripButton saveButton;
		private global::System.Windows.Forms.ToolStripButton saveAsButton;
		private global::System.Windows.Forms.OpenFileDialog openImageDialog;
		private global::System.Windows.Forms.SaveFileDialog saveImageDialog;
		private global::System.Windows.Forms.OpenFileDialog importImageDialog;
		private global::System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDown13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericUpDown14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numericUpDown15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numericUpDown16;
        private System.Windows.Forms.NumericUpDown numericUpDown17;
        private System.Windows.Forms.NumericUpDown numericUpDown18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown19;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.RichTextBox richTextBox13;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.RichTextBox richTextBox12;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RichTextBox richTextBox11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.NumericUpDown numericUpDown20;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown21;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.RichTextBox richTextBox14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.RichTextBox richTextBox15;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
