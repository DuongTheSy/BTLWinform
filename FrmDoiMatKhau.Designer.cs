namespace BTLWinform
{
    partial class FrmDoiMatKhau
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtOldPass = new TextBox();
            txtConfirmPass = new TextBox();
            txtNewPass = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 36);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 107);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 178);
            label3.Name = "label3";
            label3.Size = new Size(194, 22);
            label3.TabIndex = 2;
            label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(44, 61);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(283, 30);
            txtOldPass.TabIndex = 3;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(44, 215);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(283, 30);
            txtConfirmPass.TabIndex = 4;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(44, 132);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(283, 30);
            txtNewPass.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(112, 260);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 332);
            Controls.Add(btnUpdate);
            Controls.Add(txtNewPass);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtOldPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDoiMatKhau";
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOldPass;
        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
        private Button btnUpdate;
    }
}