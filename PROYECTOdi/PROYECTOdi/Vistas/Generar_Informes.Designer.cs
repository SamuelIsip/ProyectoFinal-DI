namespace PROYECTOdi.Vistas
{
    partial class Generar_Informes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generar_Informes));
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.dgPreguntas = new System.Windows.Forms.DataGridView();
            this.cbCEV = new System.Windows.Forms.ComboBox();
            this.cbRA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblObservaciones.Location = new System.Drawing.Point(71, 585);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(120, 18);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Observaciones ";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblRespuesta.Location = new System.Drawing.Point(71, 459);
            this.lblRespuesta.MaximumSize = new System.Drawing.Size(675, 150);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(88, 18);
            this.lblRespuesta.TabIndex = 12;
            this.lblRespuesta.Text = "Respuesta ";
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblEnunciado.Location = new System.Drawing.Point(71, 353);
            this.lblEnunciado.MaximumSize = new System.Drawing.Size(675, 150);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(88, 18);
            this.lblEnunciado.TabIndex = 11;
            this.lblEnunciado.Text = "Enunciado ";
            // 
            // dgPreguntas
            // 
            this.dgPreguntas.AllowUserToAddRows = false;
            this.dgPreguntas.AllowUserToResizeColumns = false;
            this.dgPreguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPreguntas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgPreguntas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPreguntas.EnableHeadersVisualStyles = false;
            this.dgPreguntas.Location = new System.Drawing.Point(28, 122);
            this.dgPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPreguntas.MultiSelect = false;
            this.dgPreguntas.Name = "dgPreguntas";
            this.dgPreguntas.ReadOnly = true;
            this.dgPreguntas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgPreguntas.RowHeadersVisible = false;
            this.dgPreguntas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11F);
            this.dgPreguntas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPreguntas.RowTemplate.Height = 24;
            this.dgPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgPreguntas.Size = new System.Drawing.Size(768, 164);
            this.dgPreguntas.TabIndex = 9;
            this.dgPreguntas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPreguntas_CellContentClick);
            // 
            // cbCEV
            // 
            this.cbCEV.AllowDrop = true;
            this.cbCEV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCEV.DropDownWidth = 350;
            this.cbCEV.Enabled = false;
            this.cbCEV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCEV.Font = new System.Drawing.Font("Consolas", 11F);
            this.cbCEV.FormattingEnabled = true;
            this.cbCEV.Location = new System.Drawing.Point(459, 68);
            this.cbCEV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCEV.Name = "cbCEV";
            this.cbCEV.Size = new System.Drawing.Size(355, 26);
            this.cbCEV.TabIndex = 8;
            this.cbCEV.SelectedIndexChanged += new System.EventHandler(this.cbCEV_SelectedIndexChanged);
            // 
            // cbRA
            // 
            this.cbRA.AllowDrop = true;
            this.cbRA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbRA.DropDownWidth = 500;
            this.cbRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRA.Font = new System.Drawing.Font("Consolas", 11F);
            this.cbRA.FormattingEnabled = true;
            this.cbRA.Location = new System.Drawing.Point(28, 68);
            this.cbRA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRA.Name = "cbRA";
            this.cbRA.Size = new System.Drawing.Size(355, 26);
            this.cbRA.TabIndex = 7;
            this.cbRA.SelectedIndexChanged += new System.EventHandler(this.cbRA_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selecciona un Resualtado de Aprendizaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selecciona un Criterio de Evaluzación";
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInforme.Enabled = false;
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnInforme.Location = new System.Drawing.Point(659, 578);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(193, 32);
            this.btnInforme.TabIndex = 16;
            this.btnInforme.Text = "Generar Informe";
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblTipo.Location = new System.Drawing.Point(71, 314);
            this.lblTipo.MaximumSize = new System.Drawing.Size(675, 150);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(144, 18);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo de pregunta ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 11F);
            this.button4.Location = new System.Drawing.Point(778, 620);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 18;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Generar_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(866, 670);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.dgPreguntas);
            this.Controls.Add(this.cbCEV);
            this.Controls.Add(this.cbRA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(882, 709);
            this.MinimumSize = new System.Drawing.Size(882, 709);
            this.Name = "Generar_Informes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar_Informes";
            ((System.ComponentModel.ISupportInitialize)(this.dgPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.DataGridView dgPreguntas;
        private System.Windows.Forms.ComboBox cbCEV;
        private System.Windows.Forms.ComboBox cbRA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button button4;
    }
}