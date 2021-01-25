
namespace IPGet
{
    partial class GetForm
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
            this.GetButton = new System.Windows.Forms.Button();
            this.IPV4Box = new System.Windows.Forms.TextBox();
            this.IPV6Box = new System.Windows.Forms.TextBox();
            this.IPV4Label = new System.Windows.Forms.Label();
            this.IPV6Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(180, 115);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(108, 33);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "Get IP";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // IPV4Box
            // 
            this.IPV4Box.Location = new System.Drawing.Point(180, 209);
            this.IPV4Box.Name = "IPV4Box";
            this.IPV4Box.ReadOnly = true;
            this.IPV4Box.Size = new System.Drawing.Size(146, 20);
            this.IPV4Box.TabIndex = 1;
            // 
            // IPV6Box
            // 
            this.IPV6Box.Location = new System.Drawing.Point(180, 255);
            this.IPV6Box.Name = "IPV6Box";
            this.IPV6Box.ReadOnly = true;
            this.IPV6Box.Size = new System.Drawing.Size(146, 20);
            this.IPV6Box.TabIndex = 2;
            // 
            // IPV4Label
            // 
            this.IPV4Label.AutoSize = true;
            this.IPV4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPV4Label.Location = new System.Drawing.Point(74, 209);
            this.IPV4Label.Name = "IPV4Label";
            this.IPV4Label.Size = new System.Drawing.Size(100, 18);
            this.IPV4Label.TabIndex = 3;
            this.IPV4Label.Text = "IPV4 Address:";
            // 
            // IPV6Label
            // 
            this.IPV6Label.AutoSize = true;
            this.IPV6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPV6Label.Location = new System.Drawing.Point(74, 257);
            this.IPV6Label.Name = "IPV6Label";
            this.IPV6Label.Size = new System.Drawing.Size(100, 18);
            this.IPV6Label.TabIndex = 4;
            this.IPV6Label.Text = "IPV6 Address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 5;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(74, 70);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(100, 18);
            this.InputLabel.TabIndex = 6;
            this.InputLabel.Text = "Host Domain:";
            // 
            // GetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 391);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IPV6Label);
            this.Controls.Add(this.IPV4Label);
            this.Controls.Add(this.IPV6Box);
            this.Controls.Add(this.IPV4Box);
            this.Controls.Add(this.GetButton);
            this.Name = "GetForm";
            this.Text = "IPGet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox IPV4Box;
        private System.Windows.Forms.TextBox IPV6Box;
        private System.Windows.Forms.Label IPV4Label;
        private System.Windows.Forms.Label IPV6Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label InputLabel;
    }
}

