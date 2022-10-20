
namespace Enppy
{
    partial class Enppy
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
            this.labelValue = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.labelEncrypt = new System.Windows.Forms.Label();
            this.valueDecrypt = new System.Windows.Forms.Label();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(45, 36);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(37, 13);
            this.labelValue.TabIndex = 0;
            this.labelValue.Text = "Value:";
            this.labelValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(132, 112);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(95, 29);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(300, 20);
            this.txtValue.TabIndex = 2;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // labelEncrypt
            // 
            this.labelEncrypt.AutoSize = true;
            this.labelEncrypt.Location = new System.Drawing.Point(36, 60);
            this.labelEncrypt.Name = "labelEncrypt";
            this.labelEncrypt.Size = new System.Drawing.Size(46, 13);
            this.labelEncrypt.TabIndex = 3;
            this.labelEncrypt.Text = "Encrypt:";
            // 
            // valueDecrypt
            // 
            this.valueDecrypt.AutoSize = true;
            this.valueDecrypt.Location = new System.Drawing.Point(36, 86);
            this.valueDecrypt.Name = "valueDecrypt";
            this.valueDecrypt.Size = new System.Drawing.Size(47, 13);
            this.valueDecrypt.TabIndex = 4;
            this.valueDecrypt.Text = "Decrypt:";
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(95, 53);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(300, 20);
            this.txtEncrypt.TabIndex = 5;
            this.txtEncrypt.TextChanged += new System.EventHandler(this.txtEncrypt_TextChanged);
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(95, 79);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(300, 20);
            this.txtDecrypt.TabIndex = 6;
            this.txtDecrypt.TextChanged += new System.EventHandler(this.txtDecrypt_TextChanged);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(253, 112);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Enppy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 163);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.valueDecrypt);
            this.Controls.Add(this.labelEncrypt);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.labelValue);
            this.Name = "Enppy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enppy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label labelEncrypt;
        private System.Windows.Forms.Label valueDecrypt;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

