namespace exerciciofibonacci
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
            lstfibonacci = new ListBox();
            btncalcular = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lstfibonacci
            // 
            lstfibonacci.FormattingEnabled = true;
            lstfibonacci.ItemHeight = 15;
            lstfibonacci.Location = new Point(67, 51);
            lstfibonacci.Name = "lstfibonacci";
            lstfibonacci.Size = new Size(120, 94);
            lstfibonacci.TabIndex = 0;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(67, 374);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 1;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // button1
            // 
            button1.Location = new Point(644, 374);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btncalcular);
            Controls.Add(lstfibonacci);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstfibonacci;
        private Button btncalcular;
        private Button button1;
    }
}
