namespace MaskON
{
    partial class DonateMask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textJumlah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxDropoff = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.boxMask = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mask type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Donation amount :";
            // 
            // textJumlah
            // 
            this.textJumlah.Location = new System.Drawing.Point(425, 234);
            this.textJumlah.Name = "textJumlah";
            this.textJumlah.Size = new System.Drawing.Size(200, 31);
            this.textJumlah.TabIndex = 3;
            this.textJumlah.TextChanged += new System.EventHandler(this.textJumlah_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Drop off location :";
            // 
            // boxDropoff
            // 
            this.boxDropoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDropoff.FormattingEnabled = true;
            this.boxDropoff.Items.AddRange(new object[] {
            "Hospital",
            "Local Mosque"});
            this.boxDropoff.Location = new System.Drawing.Point(425, 318);
            this.boxDropoff.Name = "boxDropoff";
            this.boxDropoff.Size = new System.Drawing.Size(200, 33);
            this.boxDropoff.TabIndex = 5;
            this.boxDropoff.SelectedIndexChanged += new System.EventHandler(this.boxDropoff_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(234, 42);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(346, 37);
            this.Title.TabIndex = 6;
            this.Title.Text = "Mask Donation Section";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(186, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 57);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(464, 406);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(161, 57);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // boxMask
            // 
            this.boxMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxMask.FormattingEnabled = true;
            this.boxMask.Items.AddRange(new object[] {
            "N95 mask",
            "Surgery mask"});
            this.boxMask.Location = new System.Drawing.Point(425, 146);
            this.boxMask.Name = "boxMask";
            this.boxMask.Size = new System.Drawing.Size(200, 33);
            this.boxMask.TabIndex = 14;
            this.boxMask.SelectedIndexChanged += new System.EventHandler(this.boxMask_SelectedIndexChanged);
            // 
            // DonateMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 506);
            this.Controls.Add(this.boxMask);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.boxDropoff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textJumlah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DonateMask";
            this.Text = "DonateMask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textJumlah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxDropoff;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox boxMask;
    }
}