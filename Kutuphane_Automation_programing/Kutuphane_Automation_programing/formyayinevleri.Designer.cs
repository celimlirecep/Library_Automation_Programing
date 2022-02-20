
namespace Kutuphane_Automation_programing
{
    partial class formyayinevleri
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
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sdfd = new System.Windows.Forms.Label();
            this.btncik = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dgvyayinevleri = new System.Windows.Forms.DataGridView();
            this.btntemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvyayinevleri)).BeginInit();
            this.SuspendLayout();
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(433, 431);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 17;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(433, 401);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(100, 20);
            this.txtadres.TabIndex = 18;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(433, 371);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(282, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "PHONE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(281, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "ADRESS :";
            // 
            // sdfd
            // 
            this.sdfd.AutoSize = true;
            this.sdfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sdfd.Location = new System.Drawing.Point(281, 371);
            this.sdfd.Name = "sdfd";
            this.sdfd.Size = new System.Drawing.Size(76, 24);
            this.sdfd.TabIndex = 10;
            this.sdfd.Text = "NAME :";
            // 
            // btncik
            // 
            this.btncik.BackColor = System.Drawing.Color.SaddleBrown;
            this.btncik.Location = new System.Drawing.Point(78, 484);
            this.btncik.Name = "btncik";
            this.btncik.Size = new System.Drawing.Size(107, 33);
            this.btncik.TabIndex = 6;
            this.btncik.Text = "QUİT";
            this.btncik.UseVisualStyleBackColor = false;
            this.btncik.Click += new System.EventHandler(this.btncik_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnsil.Location = new System.Drawing.Point(78, 442);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(107, 33);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "DELETE";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzelt
            // 
            this.btnduzelt.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnduzelt.Location = new System.Drawing.Point(78, 400);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(107, 33);
            this.btnduzelt.TabIndex = 8;
            this.btnduzelt.Text = "EDİT";
            this.btnduzelt.UseVisualStyleBackColor = false;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnekle.Location = new System.Drawing.Point(78, 358);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(107, 33);
            this.btnekle.TabIndex = 9;
            this.btnekle.Text = "ADD";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dgvyayinevleri
            // 
            this.dgvyayinevleri.AllowUserToAddRows = false;
            this.dgvyayinevleri.AllowUserToDeleteRows = false;
            this.dgvyayinevleri.AllowUserToResizeColumns = false;
            this.dgvyayinevleri.AllowUserToResizeRows = false;
            this.dgvyayinevleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvyayinevleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvyayinevleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvyayinevleri.Location = new System.Drawing.Point(0, 0);
            this.dgvyayinevleri.Name = "dgvyayinevleri";
            this.dgvyayinevleri.ReadOnly = true;
            this.dgvyayinevleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvyayinevleri.Size = new System.Drawing.Size(584, 300);
            this.dgvyayinevleri.TabIndex = 5;
            this.dgvyayinevleri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvyayinevleri_CellEnter);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btntemizle.Location = new System.Drawing.Point(433, 457);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(100, 32);
            this.btntemizle.TabIndex = 20;
            this.btntemizle.Text = "CLEAN";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // formyayinevleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sdfd);
            this.Controls.Add(this.btncik);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnduzelt);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dgvyayinevleri);
            this.Name = "formyayinevleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yayinevleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formyayinevleri_FormClosing);
            this.Load += new System.EventHandler(this.formyayinevleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvyayinevleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sdfd;
        private System.Windows.Forms.Button btncik;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dgvyayinevleri;
        private System.Windows.Forms.Button btntemizle;
    }
}