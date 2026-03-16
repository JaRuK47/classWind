namespace klaswind
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
            cmbOperation = new ComboBox();
            txtFirst = new TextBox();
            txtSecond = new TextBox();
            txtResult = new TextBox();
            cmbFirstType = new ComboBox();
            cmbSecondType = new ComboBox();
            SuspendLayout();
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperation.Location = new Point(21, 32);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(52, 28);
            cmbOperation.TabIndex = 0;
            cmbOperation.Text = "+";
            cmbOperation.SelectedIndexChanged += onValueChanged;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(90, 12);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(125, 27);
            txtFirst.TabIndex = 1;
            txtFirst.TextChanged += onValueChanged;
            // 
            // txtSecond
            // 
            txtSecond.Location = new Point(90, 54);
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(125, 27);
            txtSecond.TabIndex = 2;
            txtSecond.TextChanged += onValueChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(21, 102);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(287, 27);
            txtResult.TabIndex = 3;
            // 
            // cmbFirstType
            // 
            cmbFirstType.FormattingEnabled = true;
            cmbFirstType.Location = new Point(232, 11);
            cmbFirstType.Name = "cmbFirstType";
            cmbFirstType.Size = new Size(76, 28);
            cmbFirstType.TabIndex = 7;
            cmbFirstType.SelectedIndexChanged += onValueChanged;
            // 
            // cmbSecondType
            // 
            cmbSecondType.FormattingEnabled = true;
            cmbSecondType.Location = new Point(232, 54);
            cmbSecondType.Name = "cmbSecondType";
            cmbSecondType.Size = new Size(76, 28);
            cmbSecondType.TabIndex = 8;
            cmbSecondType.SelectedIndexChanged += onValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 151);
            Controls.Add(cmbSecondType);
            Controls.Add(cmbFirstType);
            Controls.Add(txtResult);
            Controls.Add(txtSecond);
            Controls.Add(txtFirst);
            Controls.Add(cmbOperation);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperation;
        private TextBox txtFirst;
        private TextBox txtSecond;
        private TextBox txtResult;
        private ComboBox cmbFirstType;
        private ComboBox cmbSecondType;
    }
}
