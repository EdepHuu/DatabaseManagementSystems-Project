﻿
namespace DatabaseManagementSystemProject
{
    partial class Klavye
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tur = new System.Windows.Forms.TextBox();
            this.tus = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.TextBox();
            this.klavyeid = new System.Windows.Forms.TextBox();
            this.listele = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(827, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "Klavye Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1027, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 102;
            this.label3.Text = "Tuş Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1027, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Klavye Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(827, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Ürün Kodu";
            // 
            // tur
            // 
            this.tur.BackColor = System.Drawing.Color.White;
            this.tur.Location = new System.Drawing.Point(830, 175);
            this.tur.Multiline = true;
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(180, 27);
            this.tur.TabIndex = 99;
            this.tur.TextChanged += new System.EventHandler(this.tur_TextChanged);
            // 
            // tus
            // 
            this.tus.BackColor = System.Drawing.Color.White;
            this.tus.Location = new System.Drawing.Point(1030, 175);
            this.tus.Multiline = true;
            this.tus.Name = "tus";
            this.tus.Size = new System.Drawing.Size(180, 27);
            this.tus.TabIndex = 98;
            this.tus.TextChanged += new System.EventHandler(this.tuş_TextChanged);
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.White;
            this.tip.Location = new System.Drawing.Point(1030, 75);
            this.tip.Multiline = true;
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(180, 27);
            this.tip.TabIndex = 97;
            this.tip.TextChanged += new System.EventHandler(this.tip_TextChanged);
            // 
            // klavyeid
            // 
            this.klavyeid.BackColor = System.Drawing.Color.White;
            this.klavyeid.Location = new System.Drawing.Point(830, 75);
            this.klavyeid.Multiline = true;
            this.klavyeid.Name = "klavyeid";
            this.klavyeid.Size = new System.Drawing.Size(180, 27);
            this.klavyeid.TabIndex = 96;
            this.klavyeid.TextChanged += new System.EventHandler(this.klavyeid_TextChanged);
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.MediumPurple;
            this.listele.FlatAppearance.BorderSize = 0;
            this.listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listele.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listele.Location = new System.Drawing.Point(830, 455);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(400, 50);
            this.listele.TabIndex = 95;
            this.listele.Text = "LISTELE";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.MediumPurple;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.Location = new System.Drawing.Point(1040, 524);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(190, 50);
            this.sil.TabIndex = 94;
            this.sil.Text = "SIL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.MediumPurple;
            this.ekle.FlatAppearance.BorderSize = 0;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle.Location = new System.Drawing.Point(830, 524);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(190, 50);
            this.ekle.TabIndex = 93;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 682);
            this.dataGridView1.TabIndex = 92;
            // 
            // Klavye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1251, 706);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.tus);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.klavyeid);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Klavye";
            this.Text = "Klavye";
            this.Load += new System.EventHandler(this.Klavye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tur;
        private System.Windows.Forms.TextBox tus;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.TextBox klavyeid;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}