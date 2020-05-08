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
            this.label4 = new System.Windows.Forms.Label();
            this.lb_N95 = new System.Windows.Forms.Label();
            this.lb_Surgery = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.tb_Lokasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_N95 = new System.Windows.Forms.NumericUpDown();
            this.NUD_Surgery = new System.Windows.Forms.NumericUpDown();
            this.btn_Receive_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_N95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Surgery)).BeginInit();
            this.SuspendLayout();
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
            this.label4.Text = "Mask Receiver Section";
            // 
            // lb_N95
            // 
            this.lb_N95.AutoSize = true;
            this.lb_N95.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_N95.Location = new System.Drawing.Point(288, 78);
            this.lb_N95.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_N95.Name = "lb_N95";
            this.lb_N95.Size = new System.Drawing.Size(27, 13);
            this.lb_N95.TabIndex = 18;
            this.lb_N95.Text = "N95";
            // 
            // lb_Surgery
            // 
            this.lb_Surgery.AutoSize = true;
            this.lb_Surgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Surgery.Location = new System.Drawing.Point(288, 116);
            this.lb_Surgery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Surgery.Name = "lb_Surgery";
            this.lb_Surgery.Size = new System.Drawing.Size(43, 13);
            this.lb_Surgery.TabIndex = 19;
            this.lb_Surgery.Text = "Surgery\r\n";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(275, 220);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(80, 30);
            this.btn_Submit.TabIndex = 20;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(382, 220);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(76, 30);
            this.btn_Back.TabIndex = 21;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dtgView
            // 
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Location = new System.Drawing.Point(12, 62);
            this.dtgView.Name = "dtgView";
            this.dtgView.Size = new System.Drawing.Size(240, 150);
            this.dtgView.TabIndex = 22;
            // 
            // tb_Lokasi
            // 
            this.tb_Lokasi.Location = new System.Drawing.Point(358, 152);
            this.tb_Lokasi.Name = "tb_Lokasi";
            this.tb_Lokasi.Size = new System.Drawing.Size(100, 20);
            this.tb_Lokasi.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Lokasi";
            // 
            // NUD_N95
            // 
            this.NUD_N95.Location = new System.Drawing.Point(358, 78);
            this.NUD_N95.Name = "NUD_N95";
            this.NUD_N95.Size = new System.Drawing.Size(100, 20);
            this.NUD_N95.TabIndex = 25;
            // 
            // NUD_Surgery
            // 
            this.NUD_Surgery.Location = new System.Drawing.Point(358, 114);
            this.NUD_Surgery.Name = "NUD_Surgery";
            this.NUD_Surgery.Size = new System.Drawing.Size(100, 20);
            this.NUD_Surgery.TabIndex = 26;
            // 
            // btn_Receive_Refresh
            // 
            this.btn_Receive_Refresh.Location = new System.Drawing.Point(89, 224);
            this.btn_Receive_Refresh.Name = "btn_Receive_Refresh";
            this.btn_Receive_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Receive_Refresh.TabIndex = 27;
            this.btn_Receive_Refresh.Text = "Refresh";
            this.btn_Receive_Refresh.UseVisualStyleBackColor = true;
            this.btn_Receive_Refresh.Click += new System.EventHandler(this.btn_Receive_Refresh_Click);
            // 
            // ReceiveMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 283);
            this.Controls.Add(this.btn_Receive_Refresh);
            this.Controls.Add(this.NUD_Surgery);
            this.Controls.Add(this.NUD_N95);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Lokasi);
            this.Controls.Add(this.dtgView);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lb_Surgery);
            this.Controls.Add(this.lb_N95);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceiveMask";
            this.Text = "ReceiveMask";
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_N95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Surgery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_N95;
        private System.Windows.Forms.Label lb_Surgery;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dtgView;
        private System.Windows.Forms.TextBox tb_Lokasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_N95;
        private System.Windows.Forms.NumericUpDown NUD_Surgery;
        private System.Windows.Forms.Button btn_Receive_Refresh;
    }
}