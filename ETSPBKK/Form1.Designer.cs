namespace ETSPBKK
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            amount_txt = new TextBox();
            fromcombo1 = new ComboBox();
            tocombo2 = new ComboBox();
            conv_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 77);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Convert From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 115);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Convert To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 193);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 3;
            label4.Text = "Converted Amount: ";
            label4.Click += label4_Click;
            // 
            // amount_txt
            // 
            amount_txt.Location = new Point(133, 30);
            amount_txt.Name = "amount_txt";
            amount_txt.Size = new Size(122, 23);
            amount_txt.TabIndex = 4;
            // 
            // fromcombo1
            // 
            fromcombo1.FormattingEnabled = true;
            fromcombo1.Items.AddRange(new object[] { "Rupees", "Dollar", "Euro" });
            fromcombo1.Location = new Point(133, 74);
            fromcombo1.Name = "fromcombo1";
            fromcombo1.Size = new Size(121, 23);
            fromcombo1.TabIndex = 5;
            // 
            // tocombo2
            // 
            tocombo2.FormattingEnabled = true;
            tocombo2.Items.AddRange(new object[] { "Rupees", "Dollar", "Euro" });
            tocombo2.Location = new Point(134, 112);
            tocombo2.Name = "tocombo2";
            tocombo2.Size = new Size(121, 23);
            tocombo2.TabIndex = 6;
            // 
            // conv_btn
            // 
            conv_btn.Location = new Point(290, 30);
            conv_btn.Name = "conv_btn";
            conv_btn.Size = new Size(122, 84);
            conv_btn.TabIndex = 7;
            conv_btn.Text = "Convert";
            conv_btn.UseVisualStyleBackColor = true;
            conv_btn.Click += conv_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(424, 285);
            Controls.Add(conv_btn);
            Controls.Add(tocombo2);
            Controls.Add(fromcombo1);
            Controls.Add(amount_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox amount_txt;
        private ComboBox fromcombo1;
        private ComboBox tocombo2;
        private Button conv_btn;
    }
}