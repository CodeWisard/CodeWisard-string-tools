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
            this.RandomDataInput = new System.Windows.Forms.RichTextBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KeyRefresh
            // 
            this.KeyRefresh.Enabled = true;
            this.KeyRefresh.Interval = 1000;
            this.KeyRefresh.Tick += new System.EventHandler(this.KeyRefresh_Tick);
            // 
            // RandomDataInput
            // 
            this.RandomDataInput.AcceptsTab = true;
            this.RandomDataInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RandomDataInput.DetectUrls = false;
            this.RandomDataInput.EnableAutoDragDrop = true;
            this.RandomDataInput.Location = new System.Drawing.Point(13, 13);
            this.RandomDataInput.Name = "RandomDataInput";
            this.RandomDataInput.Size = new System.Drawing.Size(576, 173);
            this.RandomDataInput.TabIndex = 0;
            this.RandomDataInput.Text = "";
            this.RandomDataInput.TextChanged += new System.EventHandler(this.RandomDataInput_TextChanged);
            this.RandomDataInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RandomDataInput_MouseMove);
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
            this.Algorithm.Text = "Algorithm";
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
            this.TimeStampDisplay.Location = new System.Drawing.Point(347, 272);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FontAwesome", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 348);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.RandomDataInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "SharpHash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer KeyRefresh;
        private System.Windows.Forms.RichTextBox RandomDataInput;
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
        private System.Windows.Forms.Label label4;
    }
}

