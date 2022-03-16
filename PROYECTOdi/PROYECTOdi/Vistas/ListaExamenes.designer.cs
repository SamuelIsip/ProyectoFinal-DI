namespace PROYECTOdi.Vistas
{
    partial class ListaExamenes
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
            this.dataGridExamenes = new System.Windows.Forms.DataGridView();
            this.vExamen = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExamenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridExamenes
            // 
            this.dataGridExamenes.AllowUserToAddRows = false;
            this.dataGridExamenes.AllowUserToDeleteRows = false;
            this.dataGridExamenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridExamenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridExamenes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExamenes.Location = new System.Drawing.Point(12, 12);
            this.dataGridExamenes.Name = "dataGridExamenes";
            this.dataGridExamenes.RowHeadersWidth = 51;
            this.dataGridExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExamenes.Size = new System.Drawing.Size(260, 150);
            this.dataGridExamenes.TabIndex = 0;
            // 
            // vExamen
            // 
            this.vExamen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vExamen.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vExamen.Location = new System.Drawing.Point(12, 203);
            this.vExamen.Name = "vExamen";
            this.vExamen.Size = new System.Drawing.Size(101, 46);
            this.vExamen.TabIndex = 1;
            this.vExamen.Text = "Visualizar Examen";
            this.vExamen.UseVisualStyleBackColor = false;
            this.vExamen.Click += new System.EventHandler(this.vExamen_Click);
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volver.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(197, 219);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 30);
            this.volver.TabIndex = 2;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // ListaExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.vExamen);
            this.Controls.Add(this.dataGridExamenes);
            this.Name = "ListaExamenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaExamenes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExamenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridExamenes;
        private System.Windows.Forms.Button vExamen;
        private System.Windows.Forms.Button volver;
    }
}