namespace ExcelToImageConverter
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
            ExcelFilePathTextBox = new TextBox();
            OutputFolderTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ExcelFilePathTextBox
            // 
            ExcelFilePathTextBox.Location = new System.Drawing.Point(12, 32);
            ExcelFilePathTextBox.Name = "ExcelFilePathTextBox";
            ExcelFilePathTextBox.Size = new System.Drawing.Size(268, 23);
            ExcelFilePathTextBox.TabIndex = 0;
            // 
            // OutputFolderTextBox
            // 
            OutputFolderTextBox.Location = new System.Drawing.Point(12, 89);
            OutputFolderTextBox.Name = "OutputFolderTextBox";
            OutputFolderTextBox.Size = new System.Drawing.Size(268, 23);
            OutputFolderTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(286, 32);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BrowseExcelFileButton_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(286, 89);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BrowseOutputFolderButton_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(116, 137);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "CONVERT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ConvertButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 15);
            label1.TabIndex = 5;
            label1.Text = "Select an Excel file to convert:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(202, 15);
            label2.TabIndex = 6;
            label2.Text = "Choose an output directory for imgs:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(373, 178);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(OutputFolderTextBox);
            Controls.Add(ExcelFilePathTextBox);
            Name = "Form1";
            Text = "Excel To Image Converter v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ExcelFilePathTextBox;
        private TextBox OutputFolderTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
    }
}