namespace Niemiecki
{
    partial class Form1
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
            this.textInsert = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInsert
            // 
            this.textInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInsert.Location = new System.Drawing.Point(12, 12);
            this.textInsert.Multiline = true;
            this.textInsert.Name = "textInsert";
            this.textInsert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInsert.Size = new System.Drawing.Size(780, 588);
            this.textInsert.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.Enabled = false;
            this.checkButton.Location = new System.Drawing.Point(12, 635);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(780, 28);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Popraw";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 606);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(780, 28);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Usuń";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(12, 664);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(780, 28);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 699);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.textInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInsert;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
    }
}

