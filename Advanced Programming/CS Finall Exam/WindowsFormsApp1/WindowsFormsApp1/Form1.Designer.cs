
namespace WindowsFormsApp1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAli = new System.Windows.Forms.Button();
            this.btnReza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(41, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(428, 84);
            this.listBox1.TabIndex = 7;
            // 
            // btnAli
            // 
            this.btnAli.Location = new System.Drawing.Point(41, 147);
            this.btnAli.Name = "btnAli";
            this.btnAli.Size = new System.Drawing.Size(428, 35);
            this.btnAli.TabIndex = 8;
            this.btnAli.Text = "rooms that rented buy Ali";
            this.btnAli.UseVisualStyleBackColor = true;
            this.btnAli.Click += new System.EventHandler(this.btnAli_Click);
            // 
            // btnReza
            // 
            this.btnReza.Location = new System.Drawing.Point(41, 188);
            this.btnReza.Name = "btnReza";
            this.btnReza.Size = new System.Drawing.Size(428, 35);
            this.btnReza.TabIndex = 9;
            this.btnReza.Text = "rooms that rented buy Reza";
            this.btnReza.UseVisualStyleBackColor = true;
            this.btnReza.Click += new System.EventHandler(this.btnReza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 363);
            this.Controls.Add(this.btnReza);
            this.Controls.Add(this.btnAli);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAli;
        private System.Windows.Forms.Button btnReza;
    }
}

