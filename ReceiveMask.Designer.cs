namespace MaskON
{
    partial class ReceiveMask
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
            this.txtN95 = new System.Windows.Forms.Label();
            this.boxSurgery = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxRequiredn95 = new System.Windows.Forms.TextBox();
            this.boxRequiredsurgery = new System.Windows.Forms.TextBox();
            this.boxN95 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.boxDropoff = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtN95
            // 
            this.txtN95.AutoSize = true;
            this.txtN95.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN95.Location = new System.Drawing.Point(26, 74);
            this.txtN95.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtN95.Name = "txtN95";
            this.txtN95.Size = new System.Drawing.Size(101, 13);
            this.txtN95.TabIndex = 0;
            this.txtN95.Text = "Available N95 mask";
            // 
            // boxSurgery
            // 
            this.boxSurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSurgery.FormattingEnabled = true;
            this.boxSurgery.Location = new System.Drawing.Point(159, 112);
            this.boxSurgery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxSurgery.Name = "boxSurgery";
            this.boxSurgery.Size = new System.Drawing.Size(86, 17);
            this.boxSurgery.TabIndex = 2;
            this.boxSurgery.SelectedIndexChanged += new System.EventHandler(this.boxSurgery_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available Surgery mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "_____________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mask Reciever Section";
            // 
            // boxRequiredn95
            // 
            this.boxRequiredn95.Location = new System.Drawing.Point(412, 76);
            this.boxRequiredn95.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxRequiredn95.Name = "boxRequiredn95";
            this.boxRequiredn95.Size = new System.Drawing.Size(52, 20);
            this.boxRequiredn95.TabIndex = 12;
            this.boxRequiredn95.TextChanged += new System.EventHandler(this.boxRequiredn95_TextChanged);
            // 
            // boxRequiredsurgery
            // 
            this.boxRequiredsurgery.Location = new System.Drawing.Point(412, 114);
            this.boxRequiredsurgery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxRequiredsurgery.Name = "boxRequiredsurgery";
            this.boxRequiredsurgery.Size = new System.Drawing.Size(52, 20);
            this.boxRequiredsurgery.TabIndex = 13;
            this.boxRequiredsurgery.TextChanged += new System.EventHandler(this.boxRequiredsurgery_TextChanged);
            // 
            // boxN95
            // 
            this.boxN95.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxN95.FormattingEnabled = true;
            this.boxN95.Location = new System.Drawing.Point(159, 74);
            this.boxN95.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxN95.Name = "boxN95";
            this.boxN95.Size = new System.Drawing.Size(86, 17);
            this.boxN95.TabIndex = 17;
            this.boxN95.SelectedIndexChanged += new System.EventHandler(this.boxN95_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Spesific amount required :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Spesific amount required :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(260, 227);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 30);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(142, 227);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 30);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Drop off location :";
            // 
            // boxDropoff
            // 
            this.boxDropoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDropoff.FormattingEnabled = true;
            this.boxDropoff.Items.AddRange(new object[] {
            "Hospital",
            "Local Mosque"});
            this.boxDropoff.Location = new System.Drawing.Point(246, 186);
            this.boxDropoff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxDropoff.Name = "boxDropoff";
            this.boxDropoff.Size = new System.Drawing.Size(102, 21);
            this.boxDropoff.TabIndex = 23;
            this.boxDropoff.SelectedIndexChanged += new System.EventHandler(this.boxDropoff_SelectedIndexChanged);
            // 
            // ReceiveMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 283);
            this.Controls.Add(this.boxDropoff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxN95);
            this.Controls.Add(this.boxRequiredsurgery);
            this.Controls.Add(this.boxRequiredn95);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxSurgery);
            this.Controls.Add(this.txtN95);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReceiveMask";
            this.Text = "ReceiveMask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtN95;
        private System.Windows.Forms.ListBox boxSurgery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxRequiredn95;
        private System.Windows.Forms.TextBox boxRequiredsurgery;
        private System.Windows.Forms.ListBox boxN95;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox boxDropoff;
    }
}