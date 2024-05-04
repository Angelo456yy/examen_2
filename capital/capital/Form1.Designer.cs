namespace capital
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
            MI = new TextBox();
            Taza = new TextBox();
            Pi = new TextBox();
            Calcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // MI
            // 
            MI.Location = new Point(78, 62);
            MI.Name = "MI";
            MI.Size = new Size(169, 23);
            MI.TabIndex = 0;
            MI.TextChanged += MI_TextChanged;
            // 
            // Taza
            // 
            Taza.Location = new Point(78, 140);
            Taza.Name = "Taza";
            Taza.Size = new Size(169, 23);
            Taza.TabIndex = 1;
            Taza.TextChanged += Taza_TextChanged;
            // 
            // Pi
            // 
            Pi.Location = new Point(78, 215);
            Pi.Name = "Pi";
            Pi.Size = new Size(169, 23);
            Pi.TabIndex = 3;
            Pi.TextChanged += Pi_TextChanged;
            // 
            // Calcular
            // 
            Calcular.BackColor = Color.Transparent;
            Calcular.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Calcular.Location = new Point(330, 152);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(142, 69);
            Calcular.TabIndex = 4;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += Calcular_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(78, 35);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 5;
            label1.Text = "Monto inicial";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(78, 110);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 6;
            label2.Text = "Tasa de interes anual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(78, 175);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 7;
            label3.Text = "Periodo de tiempo ";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(330, 251);
            button1.Name = "button1";
            button1.Size = new Size(142, 69);
            button1.TabIndex = 8;
            button1.Text = "Limpiar datos ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(436, 20);
            label4.Name = "label4";
            label4.Size = new Size(219, 32);
            label4.TabIndex = 9;
            label4.Text = "Calculo de Capital";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(341, 85);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 10;
            label5.Text = "Bienvenido ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(701, 336);
            label6.Name = "label6";
            label6.Size = new Size(87, 32);
            label6.TabIndex = 11;
            label6.Text = "HOLA ";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Calcular);
            Controls.Add(Pi);
            Controls.Add(Taza);
            Controls.Add(MI);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MI;
        private TextBox Taza;
        private TextBox Pi;
        private Button Calcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
