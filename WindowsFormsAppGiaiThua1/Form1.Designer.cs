namespace WindowsFormsAppGiaiThua1
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
            lblInput = new Label();
            lblResult = new Label();
            lblDisplayResult = new Label();
            txtInput = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(94, 79);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(67, 20);
            lblInput.TabIndex = 0;
            lblInput.Text = "Nhập số:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(94, 235);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(60, 20);
            lblResult.TabIndex = 1;
            lblResult.Text = "Kết quả";
            // 
            // lblDisplayResult
            // 
            lblDisplayResult.AutoSize = true;
            lblDisplayResult.Location = new Point(94, 316);
            lblDisplayResult.Name = "lblDisplayResult";
            lblDisplayResult.Size = new Size(50, 20);
            lblDisplayResult.TabIndex = 2;
            lblDisplayResult.Text = "label1";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(191, 76);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(372, 27);
            txtInput.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(319, 159);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(117, 24);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Tính Giai Thừa";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            Controls.Add(lblDisplayResult);
            Controls.Add(lblResult);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private Label lblResult;
        private Label lblDisplayResult;
        private TextBox txtInput;
        private Button btnCalculate;
    }
}
