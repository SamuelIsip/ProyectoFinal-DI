namespace PROYECTOdi
{
    partial class Preguntas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCEV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTtest = new System.Windows.Forms.RadioButton();
            this.rbRCorta = new System.Windows.Forms.RadioButton();
            this.rbRLarga = new System.Windows.Forms.RadioButton();
            this.txtBox1 = new System.Windows.Forms.TabControl();
            this.Enunciado = new System.Windows.Forms.TabPage();
            this.txtBoxEnunciado = new System.Windows.Forms.TextBox();
            this.Respuesta = new System.Windows.Forms.TabPage();
            this.txtBoxRespuesta = new System.Windows.Forms.TextBox();
            this.Observaciones = new System.Windows.Forms.TabPage();
            this.txtBoxObservac = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBenunciado = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBpC = new System.Windows.Forms.TextBox();
            this.txtBpB = new System.Windows.Forms.TextBox();
            this.txtBpA = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBO = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRespuestas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.txtBox1.SuspendLayout();
            this.Enunciado.SuspendLayout();
            this.Respuesta.SuspendLayout();
            this.Observaciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "COD_CE";
            // 
            // txtBoxCEV
            // 
            this.txtBoxCEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCEV.Enabled = false;
            this.txtBoxCEV.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCEV.Location = new System.Drawing.Point(20, 32);
            this.txtBoxCEV.Multiline = true;
            this.txtBoxCEV.Name = "txtBoxCEV";
            this.txtBoxCEV.Size = new System.Drawing.Size(133, 65);
            this.txtBoxCEV.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbTtest);
            this.groupBox1.Controls.Add(this.rbRCorta);
            this.groupBox1.Controls.Add(this.rbRLarga);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(162, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pregunta";
            // 
            // rbTtest
            // 
            this.rbTtest.AutoSize = true;
            this.rbTtest.Location = new System.Drawing.Point(26, 68);
            this.rbTtest.Name = "rbTtest";
            this.rbTtest.Size = new System.Drawing.Size(98, 22);
            this.rbTtest.TabIndex = 2;
            this.rbTtest.TabStop = true;
            this.rbTtest.Text = "Tipo Test";
            this.rbTtest.UseVisualStyleBackColor = true;
            this.rbTtest.CheckedChanged += new System.EventHandler(this.rbTtest_CheckedChanged);
            // 
            // rbRCorta
            // 
            this.rbRCorta.AutoSize = true;
            this.rbRCorta.Location = new System.Drawing.Point(26, 44);
            this.rbRCorta.Name = "rbRCorta";
            this.rbRCorta.Size = new System.Drawing.Size(146, 22);
            this.rbRCorta.TabIndex = 1;
            this.rbRCorta.TabStop = true;
            this.rbRCorta.Text = "Respuesta Corta";
            this.rbRCorta.UseVisualStyleBackColor = true;
            this.rbRCorta.CheckedChanged += new System.EventHandler(this.rbRCorta_CheckedChanged);
            // 
            // rbRLarga
            // 
            this.rbRLarga.AutoSize = true;
            this.rbRLarga.Location = new System.Drawing.Point(26, 20);
            this.rbRLarga.Name = "rbRLarga";
            this.rbRLarga.Size = new System.Drawing.Size(146, 22);
            this.rbRLarga.TabIndex = 0;
            this.rbRLarga.TabStop = true;
            this.rbRLarga.Text = "Respuesta Larga";
            this.rbRLarga.UseVisualStyleBackColor = true;
            this.rbRLarga.CheckedChanged += new System.EventHandler(this.rbRLarga_CheckedChanged);
            // 
            // txtBox1
            // 
            this.txtBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox1.Controls.Add(this.Enunciado);
            this.txtBox1.Controls.Add(this.Respuesta);
            this.txtBox1.Controls.Add(this.Observaciones);
            this.txtBox1.Location = new System.Drawing.Point(20, 118);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.SelectedIndex = 0;
            this.txtBox1.Size = new System.Drawing.Size(358, 278);
            this.txtBox1.TabIndex = 4;
            // 
            // Enunciado
            // 
            this.Enunciado.BackColor = System.Drawing.Color.Transparent;
            this.Enunciado.Controls.Add(this.txtBoxEnunciado);
            this.Enunciado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.Location = new System.Drawing.Point(4, 22);
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Padding = new System.Windows.Forms.Padding(3);
            this.Enunciado.Size = new System.Drawing.Size(350, 252);
            this.Enunciado.TabIndex = 0;
            this.Enunciado.Text = "Enunciado";
            // 
            // txtBoxEnunciado
            // 
            this.txtBoxEnunciado.BackColor = System.Drawing.Color.White;
            this.txtBoxEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEnunciado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxEnunciado.Location = new System.Drawing.Point(3, 3);
            this.txtBoxEnunciado.Multiline = true;
            this.txtBoxEnunciado.Name = "txtBoxEnunciado";
            this.txtBoxEnunciado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxEnunciado.Size = new System.Drawing.Size(344, 246);
            this.txtBoxEnunciado.TabIndex = 0;
            this.txtBoxEnunciado.TabStop = false;
            this.txtBoxEnunciado.Tag = "";
            // 
            // Respuesta
            // 
            this.Respuesta.Controls.Add(this.txtBoxRespuesta);
            this.Respuesta.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta.Location = new System.Drawing.Point(4, 22);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Padding = new System.Windows.Forms.Padding(3);
            this.Respuesta.Size = new System.Drawing.Size(350, 252);
            this.Respuesta.TabIndex = 1;
            this.Respuesta.Text = "Respuesta";
            this.Respuesta.UseVisualStyleBackColor = true;
            // 
            // txtBoxRespuesta
            // 
            this.txtBoxRespuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxRespuesta.Location = new System.Drawing.Point(3, 3);
            this.txtBoxRespuesta.Multiline = true;
            this.txtBoxRespuesta.Name = "txtBoxRespuesta";
            this.txtBoxRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRespuesta.Size = new System.Drawing.Size(344, 246);
            this.txtBoxRespuesta.TabIndex = 1;
            this.txtBoxRespuesta.TabStop = false;
            this.txtBoxRespuesta.Tag = "";
            // 
            // Observaciones
            // 
            this.Observaciones.Controls.Add(this.txtBoxObservac);
            this.Observaciones.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Observaciones.Location = new System.Drawing.Point(4, 22);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Padding = new System.Windows.Forms.Padding(3);
            this.Observaciones.Size = new System.Drawing.Size(350, 252);
            this.Observaciones.TabIndex = 2;
            this.Observaciones.Text = "Observaciones";
            this.Observaciones.UseVisualStyleBackColor = true;
            // 
            // txtBoxObservac
            // 
            this.txtBoxObservac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxObservac.Location = new System.Drawing.Point(3, 3);
            this.txtBoxObservac.Multiline = true;
            this.txtBoxObservac.Name = "txtBoxObservac";
            this.txtBoxObservac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxObservac.Size = new System.Drawing.Size(344, 246);
            this.txtBoxObservac.TabIndex = 2;
            this.txtBoxObservac.TabStop = false;
            this.txtBoxObservac.Tag = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(179, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(287, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtBenunciado);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(19, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 48);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enunciado";
            // 
            // txtBenunciado
            // 
            this.txtBenunciado.Location = new System.Drawing.Point(8, 19);
            this.txtBenunciado.Name = "txtBenunciado";
            this.txtBenunciado.Size = new System.Drawing.Size(348, 25);
            this.txtBenunciado.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBpC);
            this.groupBox3.Controls.Add(this.txtBpB);
            this.groupBox3.Controls.Add(this.txtBpA);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(19, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preguntas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "A";
            // 
            // txtBpC
            // 
            this.txtBpC.Location = new System.Drawing.Point(26, 70);
            this.txtBpC.Name = "txtBpC";
            this.txtBpC.Size = new System.Drawing.Size(330, 25);
            this.txtBpC.TabIndex = 2;
            // 
            // txtBpB
            // 
            this.txtBpB.Location = new System.Drawing.Point(26, 44);
            this.txtBpB.Name = "txtBpB";
            this.txtBpB.Size = new System.Drawing.Size(330, 25);
            this.txtBpB.TabIndex = 1;
            // 
            // txtBpA
            // 
            this.txtBpA.Location = new System.Drawing.Point(26, 18);
            this.txtBpA.Name = "txtBpA";
            this.txtBpA.Size = new System.Drawing.Size(330, 25);
            this.txtBpA.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtBO);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(19, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 49);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Observaciones";
            // 
            // txtBO
            // 
            this.txtBO.Location = new System.Drawing.Point(6, 19);
            this.txtBO.Name = "txtBO";
            this.txtBO.Size = new System.Drawing.Size(350, 25);
            this.txtBO.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.txtBoxRespuestas);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(19, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 63);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Respuesta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Escribir respuesta empezando por A), B) o C)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxRespuestas
            // 
            this.txtBoxRespuestas.Location = new System.Drawing.Point(8, 36);
            this.txtBoxRespuestas.Name = "txtBoxRespuestas";
            this.txtBoxRespuestas.Size = new System.Drawing.Size(347, 25);
            this.txtBoxRespuestas.TabIndex = 1;
            // 
            // Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 439);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxCEV);
            this.Controls.Add(this.label1);
            this.Name = "Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preguntas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txtBox1.ResumeLayout(false);
            this.Enunciado.ResumeLayout(false);
            this.Enunciado.PerformLayout();
            this.Respuesta.ResumeLayout(false);
            this.Respuesta.PerformLayout();
            this.Observaciones.ResumeLayout(false);
            this.Observaciones.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCEV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTtest;
        private System.Windows.Forms.RadioButton rbRCorta;
        private System.Windows.Forms.RadioButton rbRLarga;
        private System.Windows.Forms.TabControl txtBox1;
        private System.Windows.Forms.TabPage Enunciado;
        private System.Windows.Forms.TextBox txtBoxEnunciado;
        private System.Windows.Forms.TabPage Respuesta;
        private System.Windows.Forms.TextBox txtBoxRespuesta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage Observaciones;
        private System.Windows.Forms.TextBox txtBoxObservac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBenunciado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBpC;
        private System.Windows.Forms.TextBox txtBpB;
        private System.Windows.Forms.TextBox txtBpA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtBoxRespuestas;
        private System.Windows.Forms.Label label2;
    }
}