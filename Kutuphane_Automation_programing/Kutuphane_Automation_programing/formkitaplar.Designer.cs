
namespace Kutuphane_Automation_programing
{
    partial class formkitaplar
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
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtsayfasayisi = new System.Windows.Forms.TextBox();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncik = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dgvkitaplar = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btntemizle = new System.Windows.Forms.Button();
            this.cmbtur = new System.Windows.Forms.ComboBox();
            this.cmbyayinevi = new System.Windows.Forms.ComboBox();
            this.cmbyazar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(402, 407);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(121, 20);
            this.txtstok.TabIndex = 32;
            // 
            // txtsayfasayisi
            // 
            this.txtsayfasayisi.Location = new System.Drawing.Point(402, 380);
            this.txtsayfasayisi.Name = "txtsayfasayisi";
            this.txtsayfasayisi.Size = new System.Drawing.Size(121, 20);
            this.txtsayfasayisi.TabIndex = 33;
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(402, 353);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(121, 20);
            this.txtkitapadi.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(250, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "WRİTER :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(251, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "TYPE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(251, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "STOCK :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(251, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "BOOK PAGE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(250, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "BOOK NAME :";
            // 
            // btncik
            // 
            this.btncik.BackColor = System.Drawing.Color.SaddleBrown;
            this.btncik.Location = new System.Drawing.Point(47, 466);
            this.btncik.Name = "btncik";
            this.btncik.Size = new System.Drawing.Size(107, 33);
            this.btncik.TabIndex = 21;
            this.btncik.Text = "QUİT";
            this.btncik.UseVisualStyleBackColor = false;
            this.btncik.Click += new System.EventHandler(this.btncik_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnsil.Location = new System.Drawing.Point(47, 424);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(107, 33);
            this.btnsil.TabIndex = 22;
            this.btnsil.Text = "DELETE";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzelt
            // 
            this.btnduzelt.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnduzelt.Location = new System.Drawing.Point(47, 382);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(107, 33);
            this.btnduzelt.TabIndex = 23;
            this.btnduzelt.Text = "EDİT";
            this.btnduzelt.UseVisualStyleBackColor = false;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnekle.Location = new System.Drawing.Point(47, 340);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(107, 33);
            this.btnekle.TabIndex = 24;
            this.btnekle.Text = "ADD";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dgvkitaplar
            // 
            this.dgvkitaplar.AllowUserToAddRows = false;
            this.dgvkitaplar.AllowUserToDeleteRows = false;
            this.dgvkitaplar.AllowUserToResizeColumns = false;
            this.dgvkitaplar.AllowUserToResizeRows = false;
            this.dgvkitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkitaplar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvkitaplar.Location = new System.Drawing.Point(0, 0);
            this.dgvkitaplar.Name = "dgvkitaplar";
            this.dgvkitaplar.ReadOnly = true;
            this.dgvkitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvkitaplar.Size = new System.Drawing.Size(584, 300);
            this.dgvkitaplar.TabIndex = 20;
            this.dgvkitaplar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkitaplar_CellEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(250, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "PUBLİSHER :";
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btntemizle.Location = new System.Drawing.Point(402, 524);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(100, 23);
            this.btntemizle.TabIndex = 35;
            this.btntemizle.Text = "CLEAN";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // cmbtur
            // 
            this.cmbtur.FormattingEnabled = true;
            this.cmbtur.Location = new System.Drawing.Point(402, 434);
            this.cmbtur.Name = "cmbtur";
            this.cmbtur.Size = new System.Drawing.Size(121, 21);
            this.cmbtur.TabIndex = 36;
            // 
            // cmbyayinevi
            // 
            this.cmbyayinevi.FormattingEnabled = true;
            this.cmbyayinevi.Location = new System.Drawing.Point(402, 490);
            this.cmbyayinevi.Name = "cmbyayinevi";
            this.cmbyayinevi.Size = new System.Drawing.Size(121, 21);
            this.cmbyayinevi.TabIndex = 36;
            // 
            // cmbyazar
            // 
            this.cmbyazar.FormattingEnabled = true;
            this.cmbyazar.Location = new System.Drawing.Point(402, 462);
            this.cmbyazar.Name = "cmbyazar";
            this.cmbyazar.Size = new System.Drawing.Size(121, 21);
            this.cmbyazar.TabIndex = 36;
            // 
            // formkitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.cmbyazar);
            this.Controls.Add(this.cmbyayinevi);
            this.Controls.Add(this.cmbtur);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtsayfasayisi);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncik);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnduzelt);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dgvkitaplar);
            this.Name = "formkitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formkitaplar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formkitaplar_FormClosing);
            this.Load += new System.EventHandler(this.formkitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtsayfasayisi;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncik;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dgvkitaplar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.ComboBox cmbtur;
        private System.Windows.Forms.ComboBox cmbyayinevi;
        private System.Windows.Forms.ComboBox cmbyazar;
    }
}