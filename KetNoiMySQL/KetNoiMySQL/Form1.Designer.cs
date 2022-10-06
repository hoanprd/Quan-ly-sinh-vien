
namespace KetNoiMySQL
{
    partial class Form1
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
            this.DatabaseNameLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.DatabaseNameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SeverTextBox = new System.Windows.Forms.TextBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.GioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.LopTextBox = new System.Windows.Forms.TextBox();
            this.HoVaTenTextBox = new System.Windows.Forms.TextBox();
            this.MSSVTextBox = new System.Windows.Forms.TextBox();
            this.GioiTinhLabel = new System.Windows.Forms.Label();
            this.LopLabel = new System.Windows.Forms.Label();
            this.HoVaTenLabel = new System.Windows.Forms.Label();
            this.MSSVLabel = new System.Windows.Forms.Label();
            this.ThemButton = new System.Windows.Forms.Button();
            this.SuaButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseNameLabel
            // 
            this.DatabaseNameLabel.AutoSize = true;
            this.DatabaseNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseNameLabel.Location = new System.Drawing.Point(12, 46);
            this.DatabaseNameLabel.Name = "DatabaseNameLabel";
            this.DatabaseNameLabel.Size = new System.Drawing.Size(165, 27);
            this.DatabaseNameLabel.TabIndex = 0;
            this.DatabaseNameLabel.Text = "Database name:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 88);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(114, 27);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 129);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(110, 27);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(12, 172);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(59, 27);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port:";
            // 
            // DatabaseNameTextBox
            // 
            this.DatabaseNameTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseNameTextBox.Location = new System.Drawing.Point(183, 50);
            this.DatabaseNameTextBox.Name = "DatabaseNameTextBox";
            this.DatabaseNameTextBox.Size = new System.Drawing.Size(341, 27);
            this.DatabaseNameTextBox.TabIndex = 4;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(183, 92);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(341, 27);
            this.UsernameTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(183, 133);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(341, 27);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortTextBox.Location = new System.Drawing.Point(183, 176);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(341, 27);
            this.PortTextBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(550, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(712, 508);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(376, 219);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(148, 49);
            this.LoadButton.TabIndex = 9;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SeverTextBox
            // 
            this.SeverTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeverTextBox.Location = new System.Drawing.Point(183, 13);
            this.SeverTextBox.Name = "SeverTextBox";
            this.SeverTextBox.Size = new System.Drawing.Size(341, 27);
            this.SeverTextBox.TabIndex = 11;
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerLabel.Location = new System.Drawing.Point(12, 9);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(80, 27);
            this.ServerLabel.TabIndex = 10;
            this.ServerLabel.Text = "Server:";
            // 
            // GioiTinhTextBox
            // 
            this.GioiTinhTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinhTextBox.Location = new System.Drawing.Point(183, 413);
            this.GioiTinhTextBox.Name = "GioiTinhTextBox";
            this.GioiTinhTextBox.Size = new System.Drawing.Size(341, 27);
            this.GioiTinhTextBox.TabIndex = 19;
            // 
            // LopTextBox
            // 
            this.LopTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LopTextBox.Location = new System.Drawing.Point(183, 370);
            this.LopTextBox.Name = "LopTextBox";
            this.LopTextBox.Size = new System.Drawing.Size(341, 27);
            this.LopTextBox.TabIndex = 18;
            // 
            // HoVaTenTextBox
            // 
            this.HoVaTenTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoVaTenTextBox.Location = new System.Drawing.Point(183, 329);
            this.HoVaTenTextBox.Name = "HoVaTenTextBox";
            this.HoVaTenTextBox.Size = new System.Drawing.Size(341, 27);
            this.HoVaTenTextBox.TabIndex = 17;
            // 
            // MSSVTextBox
            // 
            this.MSSVTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSSVTextBox.Location = new System.Drawing.Point(183, 287);
            this.MSSVTextBox.Name = "MSSVTextBox";
            this.MSSVTextBox.Size = new System.Drawing.Size(341, 27);
            this.MSSVTextBox.TabIndex = 16;
            // 
            // GioiTinhLabel
            // 
            this.GioiTinhLabel.AutoSize = true;
            this.GioiTinhLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinhLabel.Location = new System.Drawing.Point(12, 409);
            this.GioiTinhLabel.Name = "GioiTinhLabel";
            this.GioiTinhLabel.Size = new System.Drawing.Size(103, 27);
            this.GioiTinhLabel.TabIndex = 15;
            this.GioiTinhLabel.Text = "Giới tính:";
            // 
            // LopLabel
            // 
            this.LopLabel.AutoSize = true;
            this.LopLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LopLabel.Location = new System.Drawing.Point(12, 366);
            this.LopLabel.Name = "LopLabel";
            this.LopLabel.Size = new System.Drawing.Size(58, 27);
            this.LopLabel.TabIndex = 14;
            this.LopLabel.Text = "Lớp:";
            // 
            // HoVaTenLabel
            // 
            this.HoVaTenLabel.AutoSize = true;
            this.HoVaTenLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoVaTenLabel.Location = new System.Drawing.Point(12, 325);
            this.HoVaTenLabel.Name = "HoVaTenLabel";
            this.HoVaTenLabel.Size = new System.Drawing.Size(106, 27);
            this.HoVaTenLabel.TabIndex = 13;
            this.HoVaTenLabel.Text = "Họ và tên";
            // 
            // MSSVLabel
            // 
            this.MSSVLabel.AutoSize = true;
            this.MSSVLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSSVLabel.Location = new System.Drawing.Point(12, 283);
            this.MSSVLabel.Name = "MSSVLabel";
            this.MSSVLabel.Size = new System.Drawing.Size(77, 27);
            this.MSSVLabel.TabIndex = 12;
            this.MSSVLabel.Text = "MSSV:";
            // 
            // ThemButton
            // 
            this.ThemButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemButton.Location = new System.Drawing.Point(12, 468);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(165, 49);
            this.ThemButton.TabIndex = 20;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // SuaButton
            // 
            this.SuaButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaButton.Location = new System.Drawing.Point(183, 468);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(165, 49);
            this.SuaButton.TabIndex = 21;
            this.SuaButton.Text = "Sửa";
            this.SuaButton.UseVisualStyleBackColor = true;
            this.SuaButton.Click += new System.EventHandler(this.SuaButton_Click);
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(354, 468);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(165, 49);
            this.XoaButton.TabIndex = 22;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 219);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(148, 49);
            this.ExitButton.TabIndex = 23;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 530);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.SuaButton);
            this.Controls.Add(this.ThemButton);
            this.Controls.Add(this.GioiTinhTextBox);
            this.Controls.Add(this.LopTextBox);
            this.Controls.Add(this.HoVaTenTextBox);
            this.Controls.Add(this.MSSVTextBox);
            this.Controls.Add(this.GioiTinhLabel);
            this.Controls.Add(this.LopLabel);
            this.Controls.Add(this.HoVaTenLabel);
            this.Controls.Add(this.MSSVLabel);
            this.Controls.Add(this.SeverTextBox);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.DatabaseNameTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.DatabaseNameLabel);
            this.Name = "Form1";
            this.Text = "QuanLySinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DatabaseNameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox DatabaseNameTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox SeverTextBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.TextBox GioiTinhTextBox;
        private System.Windows.Forms.TextBox LopTextBox;
        private System.Windows.Forms.TextBox HoVaTenTextBox;
        private System.Windows.Forms.TextBox MSSVTextBox;
        private System.Windows.Forms.Label GioiTinhLabel;
        private System.Windows.Forms.Label LopLabel;
        private System.Windows.Forms.Label HoVaTenLabel;
        private System.Windows.Forms.Label MSSVLabel;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

