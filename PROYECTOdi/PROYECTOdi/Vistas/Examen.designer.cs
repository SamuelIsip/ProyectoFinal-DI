namespace PROYECTOdi.Vistas
{
    partial class Examen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.preguntasExamen = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cExamen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.preguntasExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // preguntasExamen
            // 
            this.preguntasExamen.AllowUserToAddRows = false;
            this.preguntasExamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.preguntasExamen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.preguntasExamen.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.preguntasExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preguntasExamen.Location = new System.Drawing.Point(12, 51);
            this.preguntasExamen.MultiSelect = false;
            this.preguntasExamen.Name = "preguntasExamen";
            this.preguntasExamen.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.preguntasExamen.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.preguntasExamen.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11F);
            this.preguntasExamen.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.preguntasExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.preguntasExamen.Size = new System.Drawing.Size(521, 150);
            this.preguntasExamen.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar Examen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.Location = new System.Drawing.Point(391, 293);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(142, 27);
            this.borrar.TabIndex = 6;
            this.borrar.Text = "Borrar Pregunta";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código Examen";
            // 
            // cExamen
            // 
            this.cExamen.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cExamen.Location = new System.Drawing.Point(12, 25);
            this.cExamen.Name = "cExamen";
            this.cExamen.Size = new System.Drawing.Size(112, 25);
            this.cExamen.TabIndex = 8;
            // 
            // Examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(545, 332);
            this.Controls.Add(this.cExamen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.preguntasExamen);
            this.Name = "Examen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar Examen";
            ((System.ComponentModel.ISupportInitialize)(this.preguntasExamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView preguntasExamen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cExamen;
    }
}