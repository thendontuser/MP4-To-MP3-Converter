namespace MP4_To_MP3_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FileNameTextBox = new TextBox();
            OpenBtn = new Button();
            ConvertSaveBtn = new Button();
            MP3RadioBtn = new RadioButton();
            WavRadioBtn = new RadioButton();
            SuspendLayout();
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.BackColor = Color.FloralWhite;
            FileNameTextBox.Location = new Point(178, 26);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(502, 27);
            FileNameTextBox.TabIndex = 0;
            // 
            // OpenBtn
            // 
            OpenBtn.Location = new Point(12, 12);
            OpenBtn.Name = "OpenBtn";
            OpenBtn.Size = new Size(160, 55);
            OpenBtn.TabIndex = 1;
            OpenBtn.Text = "Open";
            OpenBtn.UseVisualStyleBackColor = true;
            OpenBtn.Click += OpenBtn_Click;
            // 
            // ConvertSaveBtn
            // 
            ConvertSaveBtn.Location = new Point(12, 73);
            ConvertSaveBtn.Name = "ConvertSaveBtn";
            ConvertSaveBtn.Size = new Size(160, 52);
            ConvertSaveBtn.TabIndex = 2;
            ConvertSaveBtn.Text = "Convert/Save";
            ConvertSaveBtn.UseVisualStyleBackColor = true;
            ConvertSaveBtn.Click += ConvertSaveBtn_Click;
            // 
            // MP3RadioBtn
            // 
            MP3RadioBtn.AutoSize = true;
            MP3RadioBtn.Location = new Point(178, 73);
            MP3RadioBtn.Name = "MP3RadioBtn";
            MP3RadioBtn.Size = new Size(59, 24);
            MP3RadioBtn.TabIndex = 3;
            MP3RadioBtn.TabStop = true;
            MP3RadioBtn.Text = "MP3";
            MP3RadioBtn.UseVisualStyleBackColor = true;
            // 
            // WavRadioBtn
            // 
            WavRadioBtn.AutoSize = true;
            WavRadioBtn.Location = new Point(179, 101);
            WavRadioBtn.Name = "WavRadioBtn";
            WavRadioBtn.Size = new Size(58, 24);
            WavRadioBtn.TabIndex = 4;
            WavRadioBtn.TabStop = true;
            WavRadioBtn.Text = "Wav";
            WavRadioBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(692, 137);
            Controls.Add(WavRadioBtn);
            Controls.Add(MP3RadioBtn);
            Controls.Add(ConvertSaveBtn);
            Controls.Add(OpenBtn);
            Controls.Add(FileNameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FileNameTextBox;
        private Button OpenBtn;
        private Button ConvertSaveBtn;
        private RadioButton MP3RadioBtn;
        private RadioButton WavRadioBtn;
    }
}
