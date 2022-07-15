
namespace LibrartDataManagementSystem.Borrowers_Return_Book_Forms
{
    partial class BorrowersReturnPopup
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
            this.quantityCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonReturnAll = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityCount)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityCount
            // 
            this.quantityCount.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityCount.Location = new System.Drawing.Point(87, 39);
            this.quantityCount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityCount.Name = "quantityCount";
            this.quantityCount.Size = new System.Drawing.Size(120, 26);
            this.quantityCount.TabIndex = 0;
            this.quantityCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Books to Return";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Lime;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturn.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(112, 71);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            // 
            // buttonReturnAll
            // 
            this.buttonReturnAll.BackColor = System.Drawing.Color.Aqua;
            this.buttonReturnAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturnAll.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnAll.Location = new System.Drawing.Point(96, 117);
            this.buttonReturnAll.Name = "buttonReturnAll";
            this.buttonReturnAll.Size = new System.Drawing.Size(107, 23);
            this.buttonReturnAll.TabIndex = 3;
            this.buttonReturnAll.Text = "Return All";
            this.buttonReturnAll.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Silver;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(96, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(107, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // BorrowersReturnPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 215);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReturnAll);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityCount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BorrowersReturnPopup";
            this.Text = "Return";
            ((System.ComponentModel.ISupportInitialize)(this.quantityCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown quantityCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonReturnAll;
        private System.Windows.Forms.Button buttonCancel;
    }
}