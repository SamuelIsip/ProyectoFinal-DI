namespace PROYECTOdi.Vistas
{
    partial class MENU
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInform = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnGestPr = new System.Windows.Forms.Button();
            this.btnGestCev = new System.Windows.Forms.Button();
            this.btnGestRa = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnInform, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnExam, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnGestPr, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGestCev, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGestRa, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.58491F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.58491F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.75472F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.37736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.20755F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(231, 265);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(164, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 30);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalir, "Salir de la Aplicación");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnInform
            // 
            this.btnInform.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInform.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInform.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInform.Location = new System.Drawing.Point(39, 180);
            this.btnInform.Name = "btnInform";
            this.btnInform.Size = new System.Drawing.Size(119, 46);
            this.btnInform.TabIndex = 8;
            this.btnInform.Text = "Gestionar Informe";
            this.toolTip1.SetToolTip(this.btnInform, "Gestionar Informes con las preguntas");
            this.btnInform.UseVisualStyleBackColor = false;
            this.btnInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExam.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.Location = new System.Drawing.Point(39, 127);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(119, 47);
            this.btnExam.TabIndex = 6;
            this.btnExam.Text = "Realizar Examen";
            this.toolTip1.SetToolTip(this.btnExam, "Realizar el Examen del Alumno");
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnGestPr
            // 
            this.btnGestPr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGestPr.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGestPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestPr.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestPr.Location = new System.Drawing.Point(39, 73);
            this.btnGestPr.Name = "btnGestPr";
            this.btnGestPr.Size = new System.Drawing.Size(119, 48);
            this.btnGestPr.TabIndex = 4;
            this.btnGestPr.Text = "Gestionar Preguntas";
            this.toolTip1.SetToolTip(this.btnGestPr, "Preguntas del Examen");
            this.btnGestPr.UseVisualStyleBackColor = false;
            this.btnGestPr.Click += new System.EventHandler(this.btnGestPr_Click);
            // 
            // btnGestCev
            // 
            this.btnGestCev.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGestCev.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGestCev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestCev.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCev.Location = new System.Drawing.Point(39, 38);
            this.btnGestCev.Name = "btnGestCev";
            this.btnGestCev.Size = new System.Drawing.Size(119, 29);
            this.btnGestCev.TabIndex = 2;
            this.btnGestCev.Text = "Gestionar CE";
            this.toolTip1.SetToolTip(this.btnGestCev, "Criterios de Evaluación");
            this.btnGestCev.UseVisualStyleBackColor = false;
            this.btnGestCev.Click += new System.EventHandler(this.btnGestCev_Click);
            // 
            // btnGestRa
            // 
            this.btnGestRa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGestRa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGestRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestRa.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestRa.Location = new System.Drawing.Point(39, 3);
            this.btnGestRa.Name = "btnGestRa";
            this.btnGestRa.Size = new System.Drawing.Size(119, 29);
            this.btnGestRa.TabIndex = 0;
            this.btnGestRa.Text = "Gestionar RA";
            this.toolTip1.SetToolTip(this.btnGestRa, "Resultados de Aprendizaje");
            this.btnGestRa.UseVisualStyleBackColor = false;
            this.btnGestRa.Click += new System.EventHandler(this.btnGestRa_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 265);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MENU";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInform;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnGestPr;
        private System.Windows.Forms.Button btnGestCev;
        private System.Windows.Forms.Button btnGestRa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}