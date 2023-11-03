namespace GerenciadorDeEstoque.Telas
{
    partial class LoginAcesso
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImgAlx = new System.Windows.Forms.PictureBox();
            this.ImgLoja = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLoja)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 42);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 70);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // ImgAlx
            // 
            this.ImgAlx.Image = global::GerenciadorDeEstoque.Properties.Resources.LoginAlx;
            this.ImgAlx.Location = new System.Drawing.Point(4, 2);
            this.ImgAlx.Name = "ImgAlx";
            this.ImgAlx.Size = new System.Drawing.Size(150, 150);
            this.ImgAlx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgAlx.TabIndex = 5;
            this.ImgAlx.TabStop = false;
            this.ImgAlx.Visible = false;
            // 
            // ImgLoja
            // 
            this.ImgLoja.Image = global::GerenciadorDeEstoque.Properties.Resources.LoginLoja;
            this.ImgLoja.Location = new System.Drawing.Point(4, 2);
            this.ImgLoja.Name = "ImgLoja";
            this.ImgLoja.Size = new System.Drawing.Size(150, 150);
            this.ImgLoja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLoja.TabIndex = 6;
            this.ImgLoja.TabStop = false;
            this.ImgLoja.Visible = false;
            // 
            // LoginAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ImgAlx);
            this.Controls.Add(this.ImgLoja);
            this.Name = "LoginAcesso";
            this.Text = "LoginAcesso";
            ((System.ComponentModel.ISupportInitialize)(this.ImgAlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLoja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImgAlx;
        private System.Windows.Forms.PictureBox ImgLoja;
    }
}