namespace SharpHash
{
    partial class FileHashValidator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileHashValidator));
            this.label1 = new System.Windows.Forms.Label();
            this.hash = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TimeRunning = new System.Windows.Forms.Timer(this.components);
            this.HashFilePath = new System.Windows.Forms.TextBox();
            this.OHF = new System.Windows.Forms.Button();
            this.OpenFileFV = new System.Windows.Forms.Button();
            this.FTVPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.val_go = new System.Windows.Forms.Button();
            this.Algorithm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.RichTextBox();
            this.saveReportTrigger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a hash to validate:";
            // 
            // hash
            // 
            this.hash.Location = new System.Drawing.Point(141, 10);
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(246, 20);
            this.hash.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All FIles|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "All Files|*.*";
            this.saveFileDialog.SupportMultiDottedExtensions = true;
            // 
            // TimeRunning
            // 
            this.TimeRunning.Interval = 1;
            this.TimeRunning.Tick += new System.EventHandler(this.TimeRunning_Tick);
            // 
            // HashFilePath
            // 
            this.HashFilePath.Location = new System.Drawing.Point(16, 36);
            this.HashFilePath.Name = "HashFilePath";
            this.HashFilePath.Size = new System.Drawing.Size(290, 20);
            this.HashFilePath.TabIndex = 2;
            // 
            // OHF
            // 
            this.OHF.Location = new System.Drawing.Point(312, 34);
            this.OHF.Name = "OHF";
            this.OHF.Size = new System.Drawing.Size(75, 23);
            this.OHF.TabIndex = 3;
            this.OHF.Text = "Open file...";
            this.OHF.UseVisualStyleBackColor = true;
            this.OHF.Click += new System.EventHandler(this.OHF_Click);
            // 
            // OpenFileFV
            // 
            this.OpenFileFV.Location = new System.Drawing.Point(312, 95);
            this.OpenFileFV.Name = "OpenFileFV";
            this.OpenFileFV.Size = new System.Drawing.Size(75, 23);
            this.OpenFileFV.TabIndex = 5;
            this.OpenFileFV.Text = "Open file...";
            this.OpenFileFV.UseVisualStyleBackColor = true;
            this.OpenFileFV.Click += new System.EventHandler(this.OpenFileFV_Click);
            // 
            // FTVPath
            // 
            this.FTVPath.Location = new System.Drawing.Point(16, 97);
            this.FTVPath.Name = "FTVPath";
            this.FTVPath.Size = new System.Drawing.Size(290, 20);
            this.FTVPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File to validate";
            // 
            // val_go
            // 
            this.val_go.Image = global::SharpHash.Properties.Resources.Next;
            this.val_go.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.val_go.Location = new System.Drawing.Point(16, 150);
            this.val_go.Name = "val_go";
            this.val_go.Size = new System.Drawing.Size(371, 23);
            this.val_go.TabIndex = 7;
            this.val_go.Text = "Validate";
            this.val_go.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.val_go.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.val_go.UseVisualStyleBackColor = true;
            this.val_go.Click += new System.EventHandler(this.val_go_Click);
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
            this.Algorithm.Location = new System.Drawing.Point(139, 123);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(121, 21);
            this.Algorithm.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select a hash algorithm:";
            // 
            // results
            // 
            this.results.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.results.Location = new System.Drawing.Point(16, 179);
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(371, 122);
            this.results.TabIndex = 10;
            this.results.TabStop = false;
            this.results.Text = "";
            // 
            // saveReportTrigger
            // 
            this.saveReportTrigger.Enabled = false;
            this.saveReportTrigger.Location = new System.Drawing.Point(16, 307);
            this.saveReportTrigger.Name = "saveReportTrigger";
            this.saveReportTrigger.Size = new System.Drawing.Size(119, 23);
            this.saveReportTrigger.TabIndex = 11;
            this.saveReportTrigger.Text = "Save Report to file";
            this.saveReportTrigger.UseVisualStyleBackColor = true;
            this.saveReportTrigger.Click += new System.EventHandler(this.saveReportTrigger_Click);
            // 
            // FileHashValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 342);
            this.Controls.Add(this.saveReportTrigger);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.val_go);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenFileFV);
            this.Controls.Add(this.FTVPath);
            this.Controls.Add(this.OHF);
            this.Controls.Add(this.HashFilePath);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileHashValidator";
            this.Text = "File Hash Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hash;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer TimeRunning;
        private System.Windows.Forms.TextBox HashFilePath;
        private System.Windows.Forms.Button OHF;
        private System.Windows.Forms.Button OpenFileFV;
        private System.Windows.Forms.TextBox FTVPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button val_go;
        private System.Windows.Forms.ComboBox Algorithm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Button saveReportTrigger;
    }
}