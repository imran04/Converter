namespace converter
{
    partial class App
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
            this.BinaryText = new System.Windows.Forms.TextBox();
            this.PlainText = new System.Windows.Forms.TextBox();
            this.BinaryText2Text = new System.Windows.Forms.Button();
            this.Text2BinaryText = new System.Windows.Forms.Button();
            this.BianryLabel = new System.Windows.Forms.Label();
            this.PlainTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BinaryText
            // 
            this.BinaryText.Location = new System.Drawing.Point(13, 50);
            this.BinaryText.Multiline = true;
            this.BinaryText.Name = "BinaryText";
            this.BinaryText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BinaryText.Size = new System.Drawing.Size(463, 139);
            this.BinaryText.TabIndex = 0;
            // 
            // textBox2
            // 
            this.PlainText.Location = new System.Drawing.Point(13, 217);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "textBox2";
            this.PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainText.Size = new System.Drawing.Size(463, 151);
            this.PlainText.TabIndex = 1;
            // 
            // button1
            // 
            this.BinaryText2Text.Location = new System.Drawing.Point(165, 374);
            this.BinaryText2Text.Name = "button1";
            this.BinaryText2Text.Size = new System.Drawing.Size(146, 23);
            this.BinaryText2Text.TabIndex = 2;
            this.BinaryText2Text.Text = "Binary to Text";
            this.BinaryText2Text.UseVisualStyleBackColor = true;
            this.BinaryText2Text.Click += new System.EventHandler(this.BinaryText2Text_Click);
            // 
            // button2
            // 
            this.Text2BinaryText.Location = new System.Drawing.Point(317, 374);
            this.Text2BinaryText.Name = "button2";
            this.Text2BinaryText.Size = new System.Drawing.Size(147, 23);
            this.Text2BinaryText.TabIndex = 3;
            this.Text2BinaryText.Text = "Text to Binary";
            this.Text2BinaryText.UseVisualStyleBackColor = true;
            this.Text2BinaryText.Click += new System.EventHandler(this.Text2BinaryText_Click);
            // 
            // label1
            // 
            this.BianryLabel.AutoSize = true;
            this.BianryLabel.Location = new System.Drawing.Point(12, 34);
            this.BianryLabel.Name = "label1";
            this.BianryLabel.Size = new System.Drawing.Size(60, 13);
            this.BianryLabel.TabIndex = 4;
            this.BianryLabel.Text = "Binary Text";
            // 
            // label2
            // 
            this.PlainTextLabel.AutoSize = true;
            this.PlainTextLabel.Location = new System.Drawing.Point(15, 196);
            this.PlainTextLabel.Name = "label2";
            this.PlainTextLabel.Size = new System.Drawing.Size(28, 13);
            this.PlainTextLabel.TabIndex = 5;
            this.PlainTextLabel.Text = "Text";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 409);
            this.Controls.Add(this.PlainTextLabel);
            this.Controls.Add(this.BianryLabel);
            this.Controls.Add(this.Text2BinaryText);
            this.Controls.Add(this.BinaryText2Text);
            this.Controls.Add(this.PlainText);
            this.Controls.Add(this.BinaryText);
            this.Name = "App";
            this.Text = "Binary To Text and Vice Versa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BinaryText;
        private System.Windows.Forms.TextBox PlainText;
        private System.Windows.Forms.Button BinaryText2Text;
        private System.Windows.Forms.Button Text2BinaryText;
        private System.Windows.Forms.Label BianryLabel;
        private System.Windows.Forms.Label PlainTextLabel;
    }
}

