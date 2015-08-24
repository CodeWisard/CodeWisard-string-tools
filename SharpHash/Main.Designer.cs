namespace SharpHash
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.KeyRefresh = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.StringInput = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Algorithm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeStampDisplay = new System.Windows.Forms.TextBox();
            this.RD = new System.Windows.Forms.CheckBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.URD = new System.Windows.Forms.CheckBox();
            this.Randomart = new System.Windows.Forms.GroupBox();
            this.Lenght = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileValidator = new System.Windows.Forms.ToolStripButton();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyRefresh
            // 
            this.KeyRefresh.Enabled = true;
            this.KeyRefresh.Interval = 1000;
            this.KeyRefresh.Tick += new System.EventHandler(this.KeyRefresh_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String to hash";
            // 
            // StringInput
            // 
            this.StringInput.Location = new System.Drawing.Point(91, 190);
            this.StringInput.Name = "StringInput";
            this.StringInput.Size = new System.Drawing.Size(498, 20);
            this.StringInput.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Location = new System.Drawing.Point(91, 313);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(143, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Hash";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Algorithm
            // 
            this.Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Algorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA512"});
            this.Algorithm.Location = new System.Drawing.Point(122, 221);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(121, 21);
            this.Algorithm.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose an algorithm";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(91, 248);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(498, 20);
            this.Output.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hashed string";
            // 
            // TimeStampDisplay
            // 
            this.TimeStampDisplay.Location = new System.Drawing.Point(368, 274);
            this.TimeStampDisplay.Name = "TimeStampDisplay";
            this.TimeStampDisplay.ReadOnly = true;
            this.TimeStampDisplay.Size = new System.Drawing.Size(221, 20);
            this.TimeStampDisplay.TabIndex = 8;
            // 
            // RD
            // 
            this.RD.AutoSize = true;
            this.RD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RD.Location = new System.Drawing.Point(91, 275);
            this.RD.Name = "RD";
            this.RD.Size = new System.Drawing.Size(102, 17);
            this.RD.TabIndex = 9;
            this.RD.Text = "Remove Dashes";
            this.RD.UseVisualStyleBackColor = true;
            this.RD.CheckedChanged += new System.EventHandler(this.RD_CheckedChanged);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(497, 326);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(95, 13);
            this.VersionLabel.TabIndex = 10;
            this.VersionLabel.Text = "Version Not Found";
            // 
            // URD
            // 
            this.URD.AutoSize = true;
            this.URD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.URD.Location = new System.Drawing.Point(199, 276);
            this.URD.Name = "URD";
            this.URD.Size = new System.Drawing.Size(114, 17);
            this.URD.TabIndex = 12;
            this.URD.Text = "use randomart data";
            this.URD.UseVisualStyleBackColor = true;
            // 
            // Randomart
            // 
            this.Randomart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Randomart.Location = new System.Drawing.Point(12, 28);
            this.Randomart.Name = "Randomart";
            this.Randomart.Size = new System.Drawing.Size(577, 156);
            this.Randomart.TabIndex = 13;
            this.Randomart.TabStop = false;
            this.Randomart.Text = "Randomart";
            // 
            // Lenght
            // 
            this.Lenght.AutoSize = true;
            this.Lenght.Location = new System.Drawing.Point(249, 224);
            this.Lenght.Name = "Lenght";
            this.Lenght.Size = new System.Drawing.Size(40, 13);
            this.Lenght.TabIndex = 14;
            this.Lenght.Text = "Lenght";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileValidator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(601, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileValidator
            // 
            this.FileValidator.Image = global::SharpHash.Properties.Resources.Hash_20_20;
            this.FileValidator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FileValidator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileValidator.Name = "FileValidator";
            this.FileValidator.Size = new System.Drawing.Size(94, 22);
            this.FileValidator.Text = "File Validator";
            this.FileValidator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileValidator.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FileValidator.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "clock.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::SharpHash.Properties.Resources.Clock_20_20;
            this.label4.Location = new System.Drawing.Point(327, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "         ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 348);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Lenght);
            this.Controls.Add(this.Randomart);
            this.Controls.Add(this.URD);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.RD);
            this.Controls.Add(this.TimeStampDisplay);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.StringInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SharpHash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer KeyRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StringInput;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ComboBox Algorithm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimeStampDisplay;
        private System.Windows.Forms.CheckBox RD;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.CheckBox URD;
        private System.Windows.Forms.GroupBox Randomart;
        private System.Windows.Forms.Label Lenght;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton FileValidator;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Label label4;
    }
}

