namespace Vyachka.EncryptorRSA.WinFormsApp
{
    partial class MainForm
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
            this.closedKey_Lbl = new System.Windows.Forms.Label();
            this.p_Lbl = new System.Windows.Forms.Label();
            this.q_Lbl = new System.Windows.Forms.Label();
            this.closedKey_textBox = new System.Windows.Forms.TextBox();
            this.q_textBox = new System.Windows.Forms.TextBox();
            this.p_textBox = new System.Windows.Forms.TextBox();
            this.encrypt_Btn = new System.Windows.Forms.Button();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.result_Lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrypt_Btn = new System.Windows.Forms.Button();
            this.r_textBox = new System.Windows.Forms.TextBox();
            this.r_Lbl = new System.Windows.Forms.Label();
            this.file_textBox = new System.Windows.Forms.TextBox();
            this.file_Lbl = new System.Windows.Forms.Label();
            this.encrypt_Lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closedKey_Lbl
            // 
            this.closedKey_Lbl.AutoSize = true;
            this.closedKey_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closedKey_Lbl.Location = new System.Drawing.Point(60, 277);
            this.closedKey_Lbl.Name = "closedKey_Lbl";
            this.closedKey_Lbl.Size = new System.Drawing.Size(110, 25);
            this.closedKey_Lbl.TabIndex = 0;
            this.closedKey_Lbl.Text = "Closed key";
            // 
            // p_Lbl
            // 
            this.p_Lbl.AutoSize = true;
            this.p_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p_Lbl.Location = new System.Drawing.Point(12, 156);
            this.p_Lbl.Name = "p_Lbl";
            this.p_Lbl.Size = new System.Drawing.Size(23, 25);
            this.p_Lbl.TabIndex = 1;
            this.p_Lbl.Text = "p";
            // 
            // q_Lbl
            // 
            this.q_Lbl.AutoSize = true;
            this.q_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q_Lbl.Location = new System.Drawing.Point(12, 200);
            this.q_Lbl.Name = "q_Lbl";
            this.q_Lbl.Size = new System.Drawing.Size(23, 25);
            this.q_Lbl.TabIndex = 2;
            this.q_Lbl.Text = "q";
            // 
            // closedKey_textBox
            // 
            this.closedKey_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closedKey_textBox.Location = new System.Drawing.Point(176, 275);
            this.closedKey_textBox.Name = "closedKey_textBox";
            this.closedKey_textBox.Size = new System.Drawing.Size(202, 27);
            this.closedKey_textBox.TabIndex = 3;
            this.closedKey_textBox.TextChanged += new System.EventHandler(this.ParamTextBox_TextChanged);
            // 
            // q_textBox
            // 
            this.q_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q_textBox.Location = new System.Drawing.Point(41, 201);
            this.q_textBox.Name = "q_textBox";
            this.q_textBox.Size = new System.Drawing.Size(202, 27);
            this.q_textBox.TabIndex = 4;
            this.q_textBox.TextChanged += new System.EventHandler(this.ParamTextBox_TextChanged);
            // 
            // p_textBox
            // 
            this.p_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p_textBox.Location = new System.Drawing.Point(41, 157);
            this.p_textBox.Name = "p_textBox";
            this.p_textBox.Size = new System.Drawing.Size(202, 27);
            this.p_textBox.TabIndex = 5;
            this.p_textBox.TextChanged += new System.EventHandler(this.ParamTextBox_TextChanged);
            // 
            // encrypt_Btn
            // 
            this.encrypt_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt_Btn.Location = new System.Drawing.Point(101, 340);
            this.encrypt_Btn.Name = "encrypt_Btn";
            this.encrypt_Btn.Size = new System.Drawing.Size(100, 32);
            this.encrypt_Btn.TabIndex = 6;
            this.encrypt_Btn.Text = "Encrypt";
            this.encrypt_Btn.UseVisualStyleBackColor = true;
            this.encrypt_Btn.Click += new System.EventHandler(this.Encrypt_Btn_Click);
            // 
            // result_textBox
            // 
            this.result_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_textBox.Location = new System.Drawing.Point(506, 64);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_textBox.Size = new System.Drawing.Size(331, 323);
            this.result_textBox.TabIndex = 7;
            // 
            // result_Lbl
            // 
            this.result_Lbl.AutoSize = true;
            this.result_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_Lbl.Location = new System.Drawing.Point(633, 36);
            this.result_Lbl.Name = "result_Lbl";
            this.result_Lbl.Size = new System.Drawing.Size(66, 25);
            this.result_Lbl.TabIndex = 8;
            this.result_Lbl.Text = "Result";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(224, 26);
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // decrypt_Btn
            // 
            this.decrypt_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt_Btn.Location = new System.Drawing.Point(354, 340);
            this.decrypt_Btn.Name = "decrypt_Btn";
            this.decrypt_Btn.Size = new System.Drawing.Size(100, 32);
            this.decrypt_Btn.TabIndex = 10;
            this.decrypt_Btn.Text = "Decrypt";
            this.decrypt_Btn.UseVisualStyleBackColor = true;
            this.decrypt_Btn.Click += new System.EventHandler(this.Decrypt_Btn_Click);
            // 
            // r_textBox
            // 
            this.r_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_textBox.Location = new System.Drawing.Point(297, 178);
            this.r_textBox.Name = "r_textBox";
            this.r_textBox.Size = new System.Drawing.Size(202, 27);
            this.r_textBox.TabIndex = 11;
            this.r_textBox.TextChanged += new System.EventHandler(this.ParamTextBox_TextChanged);
            // 
            // r_Lbl
            // 
            this.r_Lbl.AutoSize = true;
            this.r_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_Lbl.Location = new System.Drawing.Point(273, 180);
            this.r_Lbl.Name = "r_Lbl";
            this.r_Lbl.Size = new System.Drawing.Size(18, 25);
            this.r_Lbl.TabIndex = 12;
            this.r_Lbl.Text = "r";
            // 
            // file_textBox
            // 
            this.file_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.file_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_textBox.Location = new System.Drawing.Point(101, 61);
            this.file_textBox.Name = "file_textBox";
            this.file_textBox.ReadOnly = true;
            this.file_textBox.Size = new System.Drawing.Size(353, 27);
            this.file_textBox.TabIndex = 13;
            // 
            // file_Lbl
            // 
            this.file_Lbl.AutoSize = true;
            this.file_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_Lbl.Location = new System.Drawing.Point(46, 60);
            this.file_Lbl.Name = "file_Lbl";
            this.file_Lbl.Size = new System.Drawing.Size(49, 25);
            this.file_Lbl.TabIndex = 14;
            this.file_Lbl.Text = "File:";
            // 
            // encrypt_Lbl
            // 
            this.encrypt_Lbl.AutoSize = true;
            this.encrypt_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt_Lbl.Location = new System.Drawing.Point(96, 113);
            this.encrypt_Lbl.Name = "encrypt_Lbl";
            this.encrypt_Lbl.Size = new System.Drawing.Size(105, 25);
            this.encrypt_Lbl.TabIndex = 15;
            this.encrypt_Lbl.Text = "To encrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(349, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "To decrypt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.ShowHelp = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encrypt_Lbl);
            this.Controls.Add(this.file_Lbl);
            this.Controls.Add(this.file_textBox);
            this.Controls.Add(this.r_Lbl);
            this.Controls.Add(this.r_textBox);
            this.Controls.Add(this.decrypt_Btn);
            this.Controls.Add(this.result_Lbl);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.encrypt_Btn);
            this.Controls.Add(this.p_textBox);
            this.Controls.Add(this.q_textBox);
            this.Controls.Add(this.closedKey_textBox);
            this.Controls.Add(this.q_Lbl);
            this.Controls.Add(this.p_Lbl);
            this.Controls.Add(this.closedKey_Lbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "RSA encryptor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closedKey_Lbl;
        private System.Windows.Forms.Label p_Lbl;
        private System.Windows.Forms.Label q_Lbl;
        private System.Windows.Forms.TextBox closedKey_textBox;
        private System.Windows.Forms.TextBox q_textBox;
        private System.Windows.Forms.TextBox p_textBox;
        private System.Windows.Forms.Button encrypt_Btn;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Label result_Lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button decrypt_Btn;
        private System.Windows.Forms.TextBox r_textBox;
        private System.Windows.Forms.Label r_Lbl;
        private System.Windows.Forms.TextBox file_textBox;
        private System.Windows.Forms.Label file_Lbl;
        private System.Windows.Forms.Label encrypt_Lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

