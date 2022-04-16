namespace BulkRenameFiles
{
    partial class MainForm
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
            this.SourceDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReplaceText = new System.Windows.Forms.TextBox();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dlgBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // SourceDirectory
            // 
            this.SourceDirectory.Location = new System.Drawing.Point(371, 79);
            this.SourceDirectory.Name = "SourceDirectory";
            this.SourceDirectory.Size = new System.Drawing.Size(476, 31);
            this.SourceDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directory : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find Text   :";
            // 
            // FindText
            // 
            this.FindText.Location = new System.Drawing.Point(371, 180);
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(150, 31);
            this.FindText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Replace Text   :";
            // 
            // ReplaceText
            // 
            this.ReplaceText.Location = new System.Drawing.Point(371, 284);
            this.ReplaceText.Name = "ReplaceText";
            this.ReplaceText.Size = new System.Drawing.Size(150, 31);
            this.ReplaceText.TabIndex = 2;
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Location = new System.Drawing.Point(186, 394);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(111, 29);
            this.chkRecursive.TabIndex = 3;
            this.chkRecursive.Text = "Recursive";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(321, 504);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(112, 34);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(911, 77);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(61, 34);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 629);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.chkRecursive);
            this.Controls.Add(this.ReplaceText);
            this.Controls.Add(this.FindText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceDirectory);
            this.Name = "MainForm";
            this.Text = "Bulk Rename of folders / Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SourceDirectory;
        private Label label1;
        private Label label2;
        private TextBox FindText;
        private Label label3;
        private TextBox ReplaceText;
        private CheckBox chkRecursive;
        private Button btnProcess;
        private Button btnBrowse;
        private FolderBrowserDialog dlgBrowse;
    }
}