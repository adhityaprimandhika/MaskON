namespace MaskON
{
    partial class Tipe
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
            this.btnDonator = new System.Windows.Forms.Button();
            this.btnRecieve = new System.Windows.Forms.Button();
            this.textPertanyaan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDonator
            // 
            this.btnDonator.Location = new System.Drawing.Point(63, 94);
            this.btnDonator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDonator.Name = "btnDonator";
            this.btnDonator.Size = new System.Drawing.Size(70, 42);
            this.btnDonator.TabIndex = 0;
            this.btnDonator.Text = "Be a donator";
            this.btnDonator.UseVisualStyleBackColor = true;
            this.btnDonator.Click += new System.EventHandler(this.btnDonator_Click);
            // 
            // btnRecieve
            // 
            this.btnRecieve.Location = new System.Drawing.Point(173, 94);
            this.btnRecieve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecieve.Name = "btnRecieve";
            this.btnRecieve.Size = new System.Drawing.Size(70, 42);
            this.btnRecieve.TabIndex = 1;
            this.btnRecieve.Text = "Receive donation\r\n";
            this.btnRecieve.UseVisualStyleBackColor = true;
            this.btnRecieve.Click += new System.EventHandler(this.btnRecieve_Click);
            // 
            // textPertanyaan
            // 
            this.textPertanyaan.AutoSize = true;
            this.textPertanyaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPertanyaan.Location = new System.Drawing.Point(54, 45);
            this.textPertanyaan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textPertanyaan.Name = "textPertanyaan";
            this.textPertanyaan.Size = new System.Drawing.Size(197, 20);
            this.textPertanyaan.TabIndex = 2;
            this.textPertanyaan.Text = "What would you like to do?";
            // 
            // Tipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.textPertanyaan);
            this.Controls.Add(this.btnRecieve);
            this.Controls.Add(this.btnDonator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tipe";
            this.Text = "Tipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDonator;
        private System.Windows.Forms.Button btnRecieve;
        private System.Windows.Forms.Label textPertanyaan;
    }
}