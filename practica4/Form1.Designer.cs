namespace practica4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNombres = new TextBox();
            tbApellidos = new TextBox();
            tbTelefono = new TextBox();
            tbEdad = new TextBox();
            tbEstatura = new TextBox();
            rbHombre = new RadioButton();
            rbMujer = new RadioButton();
            button1 = new Button();
            btCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbNombres
            // 
            tbNombres.Location = new Point(292, 12);
            tbNombres.Name = "tbNombres";
            tbNombres.Size = new Size(150, 31);
            tbNombres.TabIndex = 0;
            // 
            // tbApellidos
            // 
            tbApellidos.BackColor = SystemColors.HighlightText;
            tbApellidos.Location = new Point(292, 49);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(150, 31);
            tbApellidos.TabIndex = 1;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(292, 86);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(150, 31);
            tbTelefono.TabIndex = 2;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(292, 123);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(150, 31);
            tbEdad.TabIndex = 3;
            // 
            // tbEstatura
            // 
            tbEstatura.Location = new Point(292, 160);
            tbEstatura.Name = "tbEstatura";
            tbEstatura.Size = new Size(150, 31);
            tbEstatura.TabIndex = 4;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.Location = new Point(212, 41);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(103, 29);
            rbHombre.TabIndex = 5;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.Location = new Point(62, 41);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(82, 29);
            rbMujer.TabIndex = 6;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(376, 352);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(153, 352);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(112, 34);
            btCancelar.TabIndex = 9;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 18);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 10;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 55);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 11;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 89);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 12;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 126);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 13;
            label4.Text = "Edad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 166);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 14;
            label5.Text = "Estatura:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 166);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMujer);
            groupBox1.Controls.Add(rbHombre);
            groupBox1.Location = new Point(153, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 84);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btCancelar);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEstatura);
            Controls.Add(tbEdad);
            Controls.Add(tbTelefono);
            Controls.Add(tbApellidos);
            Controls.Add(tbNombres);
            Name = "Form1";
            Text = "v";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombres;
        private TextBox tbApellidos;
        private TextBox tbTelefono;
        private TextBox tbEdad;
        private TextBox tbEstatura;
        private RadioButton rbHombre;
        private RadioButton rbMujer;
        private Button button1;
        private Button btCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
    }
}
