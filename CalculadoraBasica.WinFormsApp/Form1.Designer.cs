namespace CalculadoraBasica.WinFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtMostrarResultado = new TextBox();
            lblOperacao = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button14 = new Button();
            button16 = new Button();
            button15 = new Button();
            button17 = new Button();
            button18 = new Button();
            button20 = new Button();
            SuspendLayout();
            // 
            // txtMostrarResultado
            // 
            txtMostrarResultado.Location = new Point(12, 12);
            txtMostrarResultado.Name = "txtMostrarResultado";
            txtMostrarResultado.Size = new Size(190, 23);
            txtMostrarResultado.TabIndex = 0;
            txtMostrarResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.BackColor = Color.White;
            lblOperacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacao.ForeColor = Color.FromArgb(255, 128, 0);
            lblOperacao.Location = new Point(15, 15);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(43, 41);
            button1.TabIndex = 2;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(61, 41);
            button2.Name = "button2";
            button2.Size = new Size(43, 41);
            button2.TabIndex = 3;
            button2.Text = "CE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(110, 41);
            button3.Name = "button3";
            button3.Size = new Size(43, 41);
            button3.TabIndex = 4;
            button3.Text = "÷";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(159, 41);
            button4.Name = "button4";
            button4.Size = new Size(43, 41);
            button4.TabIndex = 5;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(159, 88);
            button5.Name = "button5";
            button5.Size = new Size(43, 41);
            button5.TabIndex = 9;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(110, 88);
            button6.Name = "button6";
            button6.Size = new Size(43, 41);
            button6.TabIndex = 8;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(61, 88);
            button7.Name = "button7";
            button7.Size = new Size(43, 41);
            button7.TabIndex = 7;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(12, 88);
            button8.Name = "button8";
            button8.Size = new Size(43, 41);
            button8.TabIndex = 6;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(159, 135);
            button9.Name = "button9";
            button9.Size = new Size(43, 41);
            button9.TabIndex = 13;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.DimGray;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.Control;
            button10.Location = new Point(110, 135);
            button10.Name = "button10";
            button10.Size = new Size(43, 41);
            button10.TabIndex = 12;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.DimGray;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.Control;
            button11.Location = new Point(61, 135);
            button11.Name = "button11";
            button11.Size = new Size(43, 41);
            button11.TabIndex = 11;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DimGray;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.Control;
            button12.Location = new Point(12, 135);
            button12.Name = "button12";
            button12.Size = new Size(43, 41);
            button12.TabIndex = 10;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.DimGray;
            button14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = SystemColors.Control;
            button14.Location = new Point(110, 182);
            button14.Name = "button14";
            button14.Size = new Size(43, 41);
            button14.TabIndex = 16;
            button14.Text = "3";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.DimGray;
            button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.Control;
            button16.Location = new Point(12, 182);
            button16.Name = "button16";
            button16.Size = new Size(43, 41);
            button16.TabIndex = 14;
            button16.Text = "1";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.DimGray;
            button15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.Control;
            button15.Location = new Point(61, 182);
            button15.Name = "button15";
            button15.Size = new Size(43, 41);
            button15.TabIndex = 15;
            button15.Text = "2";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(255, 128, 0);
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = SystemColors.Control;
            button17.Location = new Point(159, 182);
            button17.Name = "button17";
            button17.Size = new Size(43, 88);
            button17.TabIndex = 21;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.DimGray;
            button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button18.ForeColor = SystemColors.Control;
            button18.Location = new Point(110, 229);
            button18.Name = "button18";
            button18.Size = new Size(43, 41);
            button18.TabIndex = 20;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.DimGray;
            button20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button20.ForeColor = SystemColors.Control;
            button20.Location = new Point(12, 229);
            button20.Name = "button20";
            button20.Size = new Size(92, 41);
            button20.TabIndex = 18;
            button20.Text = "0";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(215, 285);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button20);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblOperacao);
            Controls.Add(txtMostrarResultado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMostrarResultado;
        private Label lblOperacao;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button14;
        private Button button16;
        private Button button15;
        private Button button17;
        private Button button18;
        private Button button20;
    }
}