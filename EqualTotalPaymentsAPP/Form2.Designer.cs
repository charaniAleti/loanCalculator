
namespace EqualTotalPaymentsAPP
{
    partial class Form2
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gridResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Chocolate;
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeading.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(237, 77);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(250, 35);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Equity payment values";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(33, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gridResults
            // 
            this.gridResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Location = new System.Drawing.Point(56, 132);
            this.gridResults.Name = "gridResults";
            this.gridResults.RowHeadersWidth = 51;
            this.gridResults.RowTemplate.Height = 29;
            this.gridResults.Size = new System.Drawing.Size(570, 593);
            this.gridResults.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 757);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gridResults;
    }
}