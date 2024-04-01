namespace oop17
{
    partial class OOP17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OOP17));
            label1 = new Label();
            label2 = new Label();
            button_elips = new Button();
            button_hyperbola = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox_hyperbola = new TextBox();
            textBox_elipse = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label_elipse = new Label();
            label_hyperbola = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(261, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 0;
            label1.Text = "Еліпс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 1;
            label2.Text = "Гіпербола";
            // 
            // button_elips
            // 
            button_elips.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_elips.Location = new Point(261, 239);
            button_elips.Name = "button_elips";
            button_elips.Size = new Size(141, 51);
            button_elips.TabIndex = 2;
            button_elips.Text = "Обчислити y";
            button_elips.UseVisualStyleBackColor = true;
            button_elips.Click += button_elips_Click;
            // 
            // button_hyperbola
            // 
            button_hyperbola.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_hyperbola.Location = new Point(12, 239);
            button_hyperbola.Name = "button_hyperbola";
            button_hyperbola.Size = new Size(141, 51);
            button_hyperbola.TabIndex = 3;
            button_hyperbola.Text = "Обчислити y";
            button_hyperbola.UseVisualStyleBackColor = true;
            button_hyperbola.Click += button_hyperbola_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(261, 57);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 4;
            label3.Text = "Введіть x";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 57);
            label4.Name = "label4";
            label4.Size = new Size(99, 30);
            label4.TabIndex = 5;
            label4.Text = "Введіть x";
            // 
            // textBox_hyperbola
            // 
            textBox_hyperbola.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_hyperbola.Location = new Point(12, 111);
            textBox_hyperbola.Name = "textBox_hyperbola";
            textBox_hyperbola.Size = new Size(109, 33);
            textBox_hyperbola.TabIndex = 6;
            // 
            // textBox_elipse
            // 
            textBox_elipse.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_elipse.Location = new Point(261, 111);
            textBox_elipse.Name = "textBox_elipse";
            textBox_elipse.Size = new Size(109, 33);
            textBox_elipse.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(49, 30);
            label5.TabIndex = 8;
            label5.Text = "y = ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(261, 179);
            label6.Name = "label6";
            label6.Size = new Size(49, 30);
            label6.TabIndex = 9;
            label6.Text = "y = ";
            // 
            // label_elipse
            // 
            label_elipse.AutoSize = true;
            label_elipse.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_elipse.Location = new Point(300, 179);
            label_elipse.Name = "label_elipse";
            label_elipse.Size = new Size(0, 30);
            label_elipse.TabIndex = 10;
            // 
            // label_hyperbola
            // 
            label_hyperbola.AutoSize = true;
            label_hyperbola.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_hyperbola.Location = new Point(52, 179);
            label_hyperbola.Name = "label_hyperbola";
            label_hyperbola.Size = new Size(0, 30);
            label_hyperbola.TabIndex = 11;
            // 
            // OOP17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(501, 310);
            Controls.Add(label_hyperbola);
            Controls.Add(label_elipse);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox_elipse);
            Controls.Add(textBox_hyperbola);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_hyperbola);
            Controls.Add(button_elips);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OOP17";
            Text = "OOP17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_elips;
        private Button button_hyperbola;
        private Label label3;
        private Label label4;
        private TextBox textBox_hyperbola;
        private TextBox textBox_elipse;
        private Label label5;
        private Label label6;
        private Label label_elipse;
        private Label label_hyperbola;
    }
}
