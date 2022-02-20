
namespace Kutuphane_Automation_programing
{
    partial class formturler
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
            this.txttur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncik = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dgvturler = new System.Windows.Forms.DataGridView();
            this.btntemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvturler)).BeginInit();
            this.SuspendLayout();
            // 
            // txttur
            // 
            this.txttur.Location = new System.Drawing.Point(424, 284);
            this.txttur.Name = "txttur";
            this.txttur.Size = new System.Drawing.Size(100, 20);
            this.txttur.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(272, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "KİTAP TÜRÜ :";
            // 
            // btncik
            // 
            this.btncik.Location = new System.Drawing.Point(69, 397);
            this.btncik.Name = "btncik";
            this.btncik.Size = new System.Drawing.Size(107, 33);
            this.btncik.TabIndex = 21;
            this.btncik.Text = "QUİT";
            this.btncik.UseVisualStyleBackColor = true;
            this.btncik.Click += new System.EventHandler(this.btncik_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(69, 355);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(107, 33);
            this.btnsil.TabIndex = 22;
            this.btnsil.Text = "DELETE";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzelt
            // 
            this.btnduzelt.Location = new System.Drawing.Point(69, 313);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(107, 33);
            this.btnduzelt.TabIndex = 23;
            this.btnduzelt.Text = "EDİT";
            this.btnduzelt.UseVisualStyleBackColor = true;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(69, 271);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(107, 33);
            this.btnekle.TabIndex = 24;
            this.btnekle.Text = "ADD";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dgvturler
            // 
            this.dgvturler.AllowUserToAddRows = false;
            this.dgvturler.AllowUserToDeleteRows = false;
            this.dgvturler.AllowUserToResizeColumns = false;
            this.dgvturler.AllowUserToResizeRows = false;
            this.dgvturler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvturler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvturler.Location = new System.Drawing.Point(57, 12);
            this.dgvturler.Name = "dgvturler";
            this.dgvturler.ReadOnly = true;
            this.dgvturler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvturler.Size = new System.Drawing.Size(489, 237);
            this.dgvturler.TabIndex = 20;
            this.dgvturler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvturler_CellEnter);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(424, 310);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(100, 29);
            this.btntemizle.TabIndex = 35;
            this.btntemizle.Text = "CLEAN";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // formturler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.txttur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncik);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnduzelt);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dgvturler);
            this.Name = "formturler";
            this.Text = "formturler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formturler_FormClosing);
            this.Load += new System.EventHandler(this.formturler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvturler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncik;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dgvturler;
        private System.Windows.Forms.Button btntemizle;
    }
}