namespace Practica2_Cronometrada
{
    partial class Form1
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
            this.timelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlusLeftLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlusRightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.diferencia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MinusRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MinusLeftLabel = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.TimesRightLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TimesLeftLabel = new System.Windows.Forms.Label();
            this.cociente = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.DividedRigthLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DividedLeftLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cociente)).BeginInit();
            this.SuspendLayout();
            // 
            // timelabel
            // 
            this.timelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(282, 9);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(200, 30);
            this.timelabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo Restante";
            // 
            // PlusLeftLabel
            // 
            this.PlusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusLeftLabel.Location = new System.Drawing.Point(50, 67);
            this.PlusLeftLabel.Name = "PlusLeftLabel";
            this.PlusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusLeftLabel.TabIndex = 2;
            this.PlusLeftLabel.Text = "?";
            this.PlusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusRightLabel
            // 
            this.PlusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusRightLabel.Location = new System.Drawing.Point(182, 67);
            this.PlusRightLabel.Name = "PlusRightLabel";
            this.PlusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusRightLabel.TabIndex = 6;
            this.PlusRightLabel.Text = "?";
            this.PlusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 7;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(314, 76);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 2;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // diferencia
            // 
            this.diferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diferencia.Location = new System.Drawing.Point(314, 137);
            this.diferencia.Name = "diferencia";
            this.diferencia.Size = new System.Drawing.Size(100, 35);
            this.diferencia.TabIndex = 3;
            this.diferencia.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusRightLabel
            // 
            this.MinusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusRightLabel.Location = new System.Drawing.Point(182, 128);
            this.MinusRightLabel.Name = "MinusRightLabel";
            this.MinusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusRightLabel.TabIndex = 11;
            this.MinusRightLabel.Text = "?";
            this.MinusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusLeftLabel
            // 
            this.MinusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusLeftLabel.Location = new System.Drawing.Point(50, 128);
            this.MinusLeftLabel.Name = "MinusLeftLabel";
            this.MinusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusLeftLabel.TabIndex = 9;
            this.MinusLeftLabel.Text = "?";
            this.MinusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Producto
            // 
            this.Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.Location = new System.Drawing.Point(314, 202);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(100, 35);
            this.Producto.TabIndex = 4;
          
            this.Producto.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 17;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimesRightLabel
            // 
            this.TimesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesRightLabel.Location = new System.Drawing.Point(182, 193);
            this.TimesRightLabel.Name = "TimesRightLabel";
            this.TimesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.TimesRightLabel.TabIndex = 16;
            this.TimesRightLabel.Text = "?";
            this.TimesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 15;
            this.label10.Text = "x";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimesLeftLabel
            // 
            this.TimesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesLeftLabel.Location = new System.Drawing.Point(50, 193);
            this.TimesLeftLabel.Name = "TimesLeftLabel";
            this.TimesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.TimesLeftLabel.TabIndex = 14;
            this.TimesLeftLabel.Text = "?";
            this.TimesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cociente
            // 
            this.cociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cociente.Location = new System.Drawing.Point(314, 261);
            this.cociente.Name = "cociente";
            this.cociente.Size = new System.Drawing.Size(100, 35);
            this.cociente.TabIndex = 5;
           
            this.cociente.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(248, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 22;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DividedRigthLabel
            // 
            this.DividedRigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DividedRigthLabel.Location = new System.Drawing.Point(182, 252);
            this.DividedRigthLabel.Name = "DividedRigthLabel";
            this.DividedRigthLabel.Size = new System.Drawing.Size(60, 50);
            this.DividedRigthLabel.TabIndex = 21;
            this.DividedRigthLabel.Text = "?";
            this.DividedRigthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(116, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 20;
            this.label14.Text = "/";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DividedLeftLabel
            // 
            this.DividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DividedLeftLabel.Location = new System.Drawing.Point(50, 252);
            this.DividedLeftLabel.Name = "DividedLeftLabel";
            this.DividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.DividedLeftLabel.TabIndex = 19;
            this.DividedLeftLabel.Text = "?";
            this.DividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(133, 315);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(154, 34);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Iniciar la Prueba";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.cociente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DividedRigthLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DividedLeftLabel);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TimesRightLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TimesLeftLabel);
            this.Controls.Add(this.diferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinusRightLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MinusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PlusRightLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba Matemática";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cociente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlusLeftLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PlusRightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown diferencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinusRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MinusLeftLabel;
        private System.Windows.Forms.NumericUpDown Producto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TimesRightLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TimesLeftLabel;
        private System.Windows.Forms.NumericUpDown cociente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DividedRigthLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label DividedLeftLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer timer1;
    }
}

