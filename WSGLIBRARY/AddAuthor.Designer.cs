namespace WSGLIBRARY
{
    partial class AddAuthor
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
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxSex = new System.Windows.Forms.TextBox();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxNationality = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxTitle.Location = new System.Drawing.Point(146, 110);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(204, 22);
            this.TextBoxTitle.TabIndex = 15;
            this.TextBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxSex
            // 
            this.TextBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxSex.Location = new System.Drawing.Point(128, 169);
            this.TextBoxSex.Name = "TextBoxSex";
            this.TextBoxSex.Size = new System.Drawing.Size(204, 22);
            this.TextBoxSex.TabIndex = 32;
            this.TextBoxSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.BackColor = System.Drawing.Color.LightCyan;
            this.AddAuthorButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAuthorButton.Location = new System.Drawing.Point(355, 270);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(103, 44);
            this.AddAuthorButton.TabIndex = 31;
            this.AddAuthorButton.Text = "ADD";
            this.AddAuthorButton.UseVisualStyleBackColor = false;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "SEX";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "NATIONALITY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxNationality
            // 
            this.TextBoxNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxNationality.Location = new System.Drawing.Point(212, 228);
            this.TextBoxNationality.Name = "TextBoxNationality";
            this.TextBoxNationality.Size = new System.Drawing.Size(204, 22);
            this.TextBoxNationality.TabIndex = 28;
            this.TextBoxNationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(470, 406);
            this.Controls.Add(this.TextBoxSex);
            this.Controls.Add(this.AddAuthorButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxNationality);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.label1);
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSex;
        private System.Windows.Forms.Button AddAuthorButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxNationality;
    }
}