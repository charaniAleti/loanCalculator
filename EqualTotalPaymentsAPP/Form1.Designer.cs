
namespace EqualTotalPaymentsAPP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanPeriod = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(402, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = " Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(402, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual Interest rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(402, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loan period (months)";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(569, 145);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(125, 27);
            this.txtLoanAmount.TabIndex = 3;
            this.txtLoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(569, 216);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(125, 27);
            this.txtInterestRate.TabIndex = 4;
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // txtLoanPeriod
            // 
            this.txtLoanPeriod.Location = new System.Drawing.Point(569, 283);
            this.txtLoanPeriod.Name = "txtLoanPeriod";
            this.txtLoanPeriod.Size = new System.Drawing.Size(125, 27);
            this.txtLoanPeriod.TabIndex = 5;
            this.txtLoanPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanPeriod_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(549, 356);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLoanPeriod);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanPeriod;
        private System.Windows.Forms.Button btnCalculate;
    }
}

