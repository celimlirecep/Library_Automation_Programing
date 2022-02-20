
namespace Kutuphane_Automation_programing
{
    partial class formyazarlar
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
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtdogumtarihi = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncik = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dgvyazarlar = new System.Windows.Forms.DataGridView();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.btntemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvyazarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(435, 518);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 30;
            // 
            // txtdogumtarihi
            // 
            this.txtdogumtarihi.Location = new System.Drawing.Point(435, 489);
            this.txtdogumtarihi.MaxLength = 10;
            this.txtdogumtarihi.Name = "txtdogumtarihi";
            this.txtdogumtarihi.Size = new System.Drawing.Size(100, 20);
            this.txtdogumtarihi.TabIndex = 31;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(435, 431);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 33;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(435, 402);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(236, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "MAIL :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(237, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "BİRTHDAY :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(237, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "GENDER :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(237, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "SURNAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(237, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "NAME :";
            // 
            // btncik
            // 
            this.btncik.BackColor = System.Drawing.Color.SaddleBrown;
            this.btncik.Location = new System.Drawing.Point(58, 534);
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
            this.btnsil.Location = new System.Drawing.Point(58, 490);
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
            this.btnduzelt.Location = new System.Drawing.Point(58, 446);
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
            this.btnekle.Location = new System.Drawing.Point(58, 402);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(107, 33);
            this.btnekle.TabIndex = 24;
            this.btnekle.Text = "ADD";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dgvyazarlar
            // 
            this.dgvyazarlar.AllowUserToAddRows = false;
            this.dgvyazarlar.AllowUserToDeleteRows = false;
            this.dgvyazarlar.AllowUserToResizeColumns = false;
            this.dgvyazarlar.AllowUserToResizeRows = false;
            this.dgvyazarlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvyazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvyazarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvyazarlar.Location = new System.Drawing.Point(0, 0);
            this.dgvyazarlar.Name = "dgvyazarlar";
            this.dgvyazarlar.ReadOnly = true;
            this.dgvyazarlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvyazarlar.Size = new System.Drawing.Size(584, 300);
            this.dgvyazarlar.TabIndex = 20;
            this.dgvyazarlar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvyazarlar_CellEnter);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(435, 547);
            this.txttel.MaxLength = 10;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(237, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "PHONE :";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(435, 462);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmbcinsiyet.TabIndex = 35;
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btntemizle.Location = new System.Drawing.Point(435, 573);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(100, 23);
            this.btntemizle.TabIndex = 36;
            this.btntemizle.Text = "CLEAN";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // formyazarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtdogumtarihi);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
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
            this.Controls.Add(this.dgvyazarlar);
            this.Name = "formyazarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formyazarlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formyazarlar_FormClosing);
            this.Load += new System.EventHandler(this.formyazarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvyazarlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtdogumtarihi;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncik;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dgvyazarlar;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Button btntemizle;
    }
}