namespace WinFormsWork
{
    partial class FormProductByPrice
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
            label2 = new Label();
            txtStart = new TextBox();
            label1 = new Label();
            txtEnd = new TextBox();
            btnShow = new Button();
            dgvResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(91, 53);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 2;
            label2.Text = "ราคาสินค้าเริ่มต้น :";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(251, 53);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(125, 27);
            txtStart.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(393, 53);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 4;
            label1.Text = "ถึงราคา :";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(474, 53);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(125, 27);
            txtEnd.TabIndex = 5;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Aqua;
            btnShow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(647, 37);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(137, 54);
            btnShow.TabIndex = 6;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(37, 120);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(846, 419);
            dgvResult.TabIndex = 7;
            // 
            // FormProductByPrice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 567);
            Controls.Add(dgvResult);
            Controls.Add(btnShow);
            Controls.Add(txtEnd);
            Controls.Add(label1);
            Controls.Add(txtStart);
            Controls.Add(label2);
            Name = "FormProductByPrice";
            Text = "FormProductByPrice";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtStart;
        private Label label1;
        private TextBox txtEnd;
        private Button btnShow;
        private DataGridView dgvResult;
    }
}