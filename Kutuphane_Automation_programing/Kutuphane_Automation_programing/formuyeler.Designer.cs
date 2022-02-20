
namespace Kutuphane_Automation_programing
{
    partial class formuyeler
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
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btncik = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btntemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.AllowUserToAddRows = false;
            this.dgvUyeler.AllowUserToDeleteRows = false;
            this.dgvUyeler.AllowUserToResizeColumns = false;
            this.dgvUyeler.AllowUserToResizeRows = false;
            this.dgvUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUyeler.Location = new System.Drawing.Point(0, 0);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.ReadOnly = true;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.Size = new System.Drawing.Size(584, 300);
            this.dgvUyeler.TabIndex = 0;
            this.dgvUyeler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellEnter);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnekle.Location = new System.Drawing.Point(62, 396);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(107, 33);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "ADD";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(265, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(266, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "SURNAME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(266, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(266, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "PHONE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(265, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "MAIL :";
            // 
            // btnduzelt
            // 
            this.btnduzelt.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnduzelt.Location = new System.Drawing.Point(62, 438);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(107, 33);
            this.btnduzelt.TabIndex = 1;
            this.btnduzelt.Text = "EDİT";
            this.btnduzelt.UseVisualStyleBackColor = false;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnsil.Location = new System.Drawing.Point(62, 480);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(107, 33);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "DELETE";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btncik
            // 
            this.btncik.BackColor = System.Drawing.Color.SaddleBrown;
            this.btncik.Location = new System.Drawing.Point(62, 522);
            this.btncik.Name = "btncik";
            this.btncik.Size = new System.Drawing.Size(107, 33);
            this.btncik.TabIndex = 1;
            this.btncik.Text = "QUİT";
            this.btncik.UseVisualStyleBackColor = false;
            this.btncik.Click += new System.EventHandler(this.btncik_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(417, 409);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 4;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(417, 439);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 4;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(417, 469);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 20);
            this.txttc.TabIndex = 4;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(417, 499);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(100, 20);
            this.txttelefon.TabIndex = 4;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(417, 529);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 4;
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btntemizle.Location = new System.Drawing.Point(417, 555);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(100, 32);
            this.btntemizle.TabIndex = 5;
            this.btntemizle.Text = "CLEAN";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // formuyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncik);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnduzelt);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dgvUyeler);
            this.Name = "formuyeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEMBERS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formuyeler_FormClosing);
            this.Load += new System.EventHandler(this.formuyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btncik;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btntemizle;
    }
}