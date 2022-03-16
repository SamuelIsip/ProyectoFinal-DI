namespace PROYECTOdi.Vistas
{
    partial class Realizar_Examen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Realizar_Examen));
            this.rAprendizaje = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cEvaluacion = new System.Windows.Forms.CheckedListBox();
            this.lExamenes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rAprendizaje
            // 
            this.rAprendizaje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rAprendizaje.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rAprendizaje.FormattingEnabled = true;
            this.rAprendizaje.Location = new System.Drawing.Point(12, 48);
            this.rAprendizaje.Name = "rAprendizaje";
            this.rAprendizaje.Size = new System.Drawing.Size(602, 26);
            this.rAprendizaje.TabIndex = 14;
            this.rAprendizaje.SelectedIndexChanged += new System.EventHandler(this.rAprendizaje_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Realizar Examen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resultados de Aprendizaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Criterios de Evaluación";
            // 
            // cEvaluacion
            // 
            this.cEvaluacion.CheckOnClick = true;
            this.cEvaluacion.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEvaluacion.FormattingEnabled = true;
            this.cEvaluacion.Location = new System.Drawing.Point(13, 109);
            this.cEvaluacion.Name = "cEvaluacion";
            this.cEvaluacion.Size = new System.Drawing.Size(601, 104);
            this.cEvaluacion.TabIndex = 8;
            // 
            // lExamenes
            // 
            this.lExamenes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lExamenes.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExamenes.Location = new System.Drawing.Point(178, 270);
            this.lExamenes.Name = "lExamenes";
            this.lExamenes.Size = new System.Drawing.Size(179, 28);
            this.lExamenes.TabIndex = 15;
            this.lExamenes.Text = "Visualizar Examenes";
            this.lExamenes.UseVisualStyleBackColor = false;
            this.lExamenes.Click += new System.EventHandler(this.lExamenes_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(543, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Realizar_Examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 344);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lExamenes);
            this.Controls.Add(this.rAprendizaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cEvaluacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Realizar_Examen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Realizar_Examen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rAprendizaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cEvaluacion;
        private System.Windows.Forms.Button lExamenes;
        private System.Windows.Forms.Button button2;
    }
}