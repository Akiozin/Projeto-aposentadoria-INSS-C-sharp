namespace Projeto_aposentadoria_INSS
{
    partial class FormAposentadoria
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
            panel1 = new Panel();
            btnCalcular = new Button();
            lblResultado = new Label();
            dtpHoje = new DateTimePicker();
            label4 = new Label();
            dtpIngresso = new DateTimePicker();
            label3 = new Label();
            txtIdade = new TextBox();
            cmbSexo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(lblResultado);
            panel1.Controls.Add(dtpHoje);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpIngresso);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtIdade);
            panel1.Controls.Add(cmbSexo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(145, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 350);
            panel1.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalcular.Location = new Point(205, 216);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 28);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResultado.Location = new Point(26, 315);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 21);
            lblResultado.TabIndex = 8;
            // 
            // dtpHoje
            // 
            dtpHoje.Location = new Point(113, 164);
            dtpHoje.Name = "dtpHoje";
            dtpHoje.Size = new Size(249, 23);
            dtpHoje.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 6;
            label4.Text = "Data Atual:";
            // 
            // dtpIngresso
            // 
            dtpIngresso.CalendarFont = new Font("Segoe UI", 9F);
            dtpIngresso.Font = new Font("Segoe UI", 9F);
            dtpIngresso.Location = new Point(245, 124);
            dtpIngresso.Name = "dtpIngresso";
            dtpIngresso.Size = new Size(254, 23);
            dtpIngresso.TabIndex = 5;
            dtpIngresso.Value = new DateTime(2025, 3, 6, 1, 36, 16, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(234, 21);
            label3.TabIndex = 4;
            label3.Text = "Data de ingresso no trabalho:";
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 12F);
            txtIdade.Location = new Point(69, 77);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 29);
            txtIdade.TabIndex = 3;
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.Font = new Font("Segoe UI", 12F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbSexo.Location = new Point(69, 28);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 29);
            cmbSexo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "Idade:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 0;
            label1.Text = "Sexo:";
            // 
            // FormAposentadoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAposentadoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo aposentadoria INSS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtIdade;
        private ComboBox cmbSexo;
        private DateTimePicker dtpIngresso;
        private Label label3;
        private DateTimePicker dtpHoje;
        private Label label4;
        private Button btnCalcular;
        private Label lblResultado;
    }
}