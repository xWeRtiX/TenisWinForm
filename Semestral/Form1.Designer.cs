
namespace Semestral
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVolniHraci = new System.Windows.Forms.DataGridView();
            this.dgvTurnaje = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPridat = new System.Windows.Forms.Button();
            this.dgvHraciTurnaje = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOdebrat = new System.Windows.Forms.Button();
            this.btnPridatTenistu = new System.Windows.Forms.Button();
            this.btnUpravitTenistu = new System.Windows.Forms.Button();
            this.btnVytvoritTurnaj = new System.Windows.Forms.Button();
            this.btnOdstranitTurnaj = new System.Windows.Forms.Button();
            this.btnUpravitTurnaj = new System.Windows.Forms.Button();
            this.btnOdebratTenistu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolniHraci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHraciTurnaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volní hráči";
            // 
            // dgvVolniHraci
            // 
            this.dgvVolniHraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolniHraci.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVolniHraci.Location = new System.Drawing.Point(28, 61);
            this.dgvVolniHraci.Name = "dgvVolniHraci";
            this.dgvVolniHraci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVolniHraci.Size = new System.Drawing.Size(278, 150);
            this.dgvVolniHraci.TabIndex = 1;
            // 
            // dgvTurnaje
            // 
            this.dgvTurnaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnaje.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTurnaje.Location = new System.Drawing.Point(456, 61);
            this.dgvTurnaje.Name = "dgvTurnaje";
            this.dgvTurnaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnaje.Size = new System.Drawing.Size(260, 150);
            this.dgvTurnaje.TabIndex = 2;
            this.dgvTurnaje.SelectionChanged += new System.EventHandler(this.dgvTurnaje_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turnaj";
            // 
            // btnPridat
            // 
            this.btnPridat.Location = new System.Drawing.Point(334, 83);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(94, 45);
            this.btnPridat.TabIndex = 4;
            this.btnPridat.Text = "Přidat hráče do turnaje";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.btnPridat_Click);
            // 
            // dgvHraciTurnaje
            // 
            this.dgvHraciTurnaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHraciTurnaje.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHraciTurnaje.Location = new System.Drawing.Point(100, 313);
            this.dgvHraciTurnaje.Name = "dgvHraciTurnaje";
            this.dgvHraciTurnaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHraciTurnaje.Size = new System.Drawing.Size(543, 133);
            this.dgvHraciTurnaje.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hráči v turnaji";
            // 
            // btnOdebrat
            // 
            this.btnOdebrat.Location = new System.Drawing.Point(334, 134);
            this.btnOdebrat.Name = "btnOdebrat";
            this.btnOdebrat.Size = new System.Drawing.Size(94, 45);
            this.btnOdebrat.TabIndex = 7;
            this.btnOdebrat.Text = "Odebrat hráče z turnaje";
            this.btnOdebrat.UseVisualStyleBackColor = true;
            this.btnOdebrat.Click += new System.EventHandler(this.btnOdebrat_Click);
            // 
            // btnPridatTenistu
            // 
            this.btnPridatTenistu.Location = new System.Drawing.Point(28, 217);
            this.btnPridatTenistu.Name = "btnPridatTenistu";
            this.btnPridatTenistu.Size = new System.Drawing.Size(83, 32);
            this.btnPridatTenistu.TabIndex = 8;
            this.btnPridatTenistu.Text = "Přidat tenistu";
            this.btnPridatTenistu.UseVisualStyleBackColor = true;
            this.btnPridatTenistu.Click += new System.EventHandler(this.btnPridatTenistu_Click);
            // 
            // btnUpravitTenistu
            // 
            this.btnUpravitTenistu.Location = new System.Drawing.Point(215, 217);
            this.btnUpravitTenistu.Name = "btnUpravitTenistu";
            this.btnUpravitTenistu.Size = new System.Drawing.Size(91, 32);
            this.btnUpravitTenistu.TabIndex = 9;
            this.btnUpravitTenistu.Text = "Upravit tenistu";
            this.btnUpravitTenistu.UseVisualStyleBackColor = true;
            this.btnUpravitTenistu.Click += new System.EventHandler(this.btnUpravitTenistu_Click);
            // 
            // btnVytvoritTurnaj
            // 
            this.btnVytvoritTurnaj.Location = new System.Drawing.Point(456, 217);
            this.btnVytvoritTurnaj.Name = "btnVytvoritTurnaj";
            this.btnVytvoritTurnaj.Size = new System.Drawing.Size(80, 32);
            this.btnVytvoritTurnaj.TabIndex = 10;
            this.btnVytvoritTurnaj.Text = "Vytvořit turnaj";
            this.btnVytvoritTurnaj.UseVisualStyleBackColor = true;
            this.btnVytvoritTurnaj.Click += new System.EventHandler(this.btnVytvoritTurnaj_Click);
            // 
            // btnOdstranitTurnaj
            // 
            this.btnOdstranitTurnaj.Location = new System.Drawing.Point(542, 217);
            this.btnOdstranitTurnaj.Name = "btnOdstranitTurnaj";
            this.btnOdstranitTurnaj.Size = new System.Drawing.Size(86, 32);
            this.btnOdstranitTurnaj.TabIndex = 11;
            this.btnOdstranitTurnaj.Text = "Odstranit turnaj";
            this.btnOdstranitTurnaj.UseVisualStyleBackColor = true;
            this.btnOdstranitTurnaj.Click += new System.EventHandler(this.btnOdstranitTurnaj_Click);
            // 
            // btnUpravitTurnaj
            // 
            this.btnUpravitTurnaj.Location = new System.Drawing.Point(634, 217);
            this.btnUpravitTurnaj.Name = "btnUpravitTurnaj";
            this.btnUpravitTurnaj.Size = new System.Drawing.Size(82, 32);
            this.btnUpravitTurnaj.TabIndex = 12;
            this.btnUpravitTurnaj.Text = "Upravit turnaj";
            this.btnUpravitTurnaj.UseVisualStyleBackColor = true;
            this.btnUpravitTurnaj.Click += new System.EventHandler(this.btnUpravitTurnaj_Click);
            // 
            // btnOdebratTenistu
            // 
            this.btnOdebratTenistu.Location = new System.Drawing.Point(117, 217);
            this.btnOdebratTenistu.Name = "btnOdebratTenistu";
            this.btnOdebratTenistu.Size = new System.Drawing.Size(92, 32);
            this.btnOdebratTenistu.TabIndex = 13;
            this.btnOdebratTenistu.Text = "Odebrat tenistu";
            this.btnOdebratTenistu.UseVisualStyleBackColor = true;
            this.btnOdebratTenistu.Click += new System.EventHandler(this.btnOdebratTenistu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 458);
            this.Controls.Add(this.btnOdebratTenistu);
            this.Controls.Add(this.btnUpravitTurnaj);
            this.Controls.Add(this.btnOdstranitTurnaj);
            this.Controls.Add(this.btnVytvoritTurnaj);
            this.Controls.Add(this.btnUpravitTenistu);
            this.Controls.Add(this.btnPridatTenistu);
            this.Controls.Add(this.btnOdebrat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHraciTurnaje);
            this.Controls.Add(this.btnPridat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTurnaje);
            this.Controls.Add(this.dgvVolniHraci);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tenis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolniHraci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHraciTurnaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVolniHraci;
        private System.Windows.Forms.DataGridView dgvTurnaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.DataGridView dgvHraciTurnaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOdebrat;
        private System.Windows.Forms.Button btnPridatTenistu;
        private System.Windows.Forms.Button btnUpravitTenistu;
        private System.Windows.Forms.Button btnVytvoritTurnaj;
        private System.Windows.Forms.Button btnOdstranitTurnaj;
        private System.Windows.Forms.Button btnUpravitTurnaj;
        private System.Windows.Forms.Button btnOdebratTenistu;
    }
}

