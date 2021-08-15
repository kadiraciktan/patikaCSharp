
namespace VotingApp
{
    partial class VotingForm
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
            this.cbxKategoriler = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxPuan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxKategoriler
            // 
            this.cbxKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategoriler.FormattingEnabled = true;
            this.cbxKategoriler.Location = new System.Drawing.Point(101, 12);
            this.cbxKategoriler.Name = "cbxKategoriler";
            this.cbxKategoriler.Size = new System.Drawing.Size(121, 23);
            this.cbxKategoriler.TabIndex = 0;
            this.cbxKategoriler.SelectionChangeCommitted += new System.EventHandler(this.cbxKategoriler_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Oy Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxPuan
            // 
            this.cbxPuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPuan.FormattingEnabled = true;
            this.cbxPuan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxPuan.Location = new System.Drawing.Point(101, 41);
            this.cbxPuan.MaxDropDownItems = 10;
            this.cbxPuan.Name = "cbxPuan";
            this.cbxPuan.Size = new System.Drawing.Size(121, 23);
            this.cbxPuan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori Ortalama Puanı :";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(203, 129);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(12, 15);
            this.lblPuan.TabIndex = 6;
            this.lblPuan.Text = "-";
            // 
            // VotingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 171);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPuan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxKategoriler);
            this.Name = "VotingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VotingForm";
            this.Load += new System.EventHandler(this.VotingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKategoriler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxPuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPuan;
    }
}