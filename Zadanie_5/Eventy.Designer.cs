
namespace Zadanie_5
{
    partial class Zadanie_5
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxHasloRejestracja1 = new System.Windows.Forms.TextBox();
            this.buttonZarejestruj = new System.Windows.Forms.Button();
            this.textBoxHasloRejestracja2 = new System.Windows.Forms.TextBox();
            this.checkBoxRODO = new System.Windows.Forms.CheckBox();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.textLogowanie = new System.Windows.Forms.TextBox();
            this.textBoxHasloLogowanie = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelHaslo1 = new System.Windows.Forms.Label();
            this.labelRODO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(44, 81);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PlaceholderText = "Login";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 23);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxHasloRejestracja1
            // 
            this.textBoxHasloRejestracja1.Location = new System.Drawing.Point(44, 135);
            this.textBoxHasloRejestracja1.Name = "textBoxHasloRejestracja1";
            this.textBoxHasloRejestracja1.PasswordChar = '*';
            this.textBoxHasloRejestracja1.PlaceholderText = "Haslo";
            this.textBoxHasloRejestracja1.Size = new System.Drawing.Size(100, 23);
            this.textBoxHasloRejestracja1.TabIndex = 1;
            // 
            // buttonZarejestruj
            // 
            this.buttonZarejestruj.Location = new System.Drawing.Point(44, 261);
            this.buttonZarejestruj.Name = "buttonZarejestruj";
            this.buttonZarejestruj.Size = new System.Drawing.Size(75, 23);
            this.buttonZarejestruj.TabIndex = 2;
            this.buttonZarejestruj.Text = "Zarejestruj";
            this.buttonZarejestruj.UseVisualStyleBackColor = true;
            this.buttonZarejestruj.Click += new System.EventHandler(this.buttonZarejestruj_Click);
            // 
            // textBoxHasloRejestracja2
            // 
            this.textBoxHasloRejestracja2.Location = new System.Drawing.Point(44, 167);
            this.textBoxHasloRejestracja2.Name = "textBoxHasloRejestracja2";
            this.textBoxHasloRejestracja2.PasswordChar = '*';
            this.textBoxHasloRejestracja2.PlaceholderText = "Potwierdz Haslo";
            this.textBoxHasloRejestracja2.Size = new System.Drawing.Size(100, 23);
            this.textBoxHasloRejestracja2.TabIndex = 3;
            // 
            // checkBoxRODO
            // 
            this.checkBoxRODO.AutoSize = true;
            this.checkBoxRODO.Location = new System.Drawing.Point(44, 213);
            this.checkBoxRODO.Name = "checkBoxRODO";
            this.checkBoxRODO.Size = new System.Drawing.Size(96, 19);
            this.checkBoxRODO.TabIndex = 4;
            this.checkBoxRODO.Text = "Zgoda RODO";
            this.checkBoxRODO.UseVisualStyleBackColor = true;
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Location = new System.Drawing.Point(606, 187);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(75, 23);
            this.buttonZaloguj.TabIndex = 5;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // textLogowanie
            // 
            this.textLogowanie.Location = new System.Drawing.Point(606, 81);
            this.textLogowanie.Name = "textLogowanie";
            this.textLogowanie.PlaceholderText = "Login";
            this.textLogowanie.Size = new System.Drawing.Size(100, 23);
            this.textLogowanie.TabIndex = 6;
            // 
            // textBoxHasloLogowanie
            // 
            this.textBoxHasloLogowanie.Location = new System.Drawing.Point(606, 135);
            this.textBoxHasloLogowanie.Name = "textBoxHasloLogowanie";
            this.textBoxHasloLogowanie.PasswordChar = '*';
            this.textBoxHasloLogowanie.PlaceholderText = "Haslo";
            this.textBoxHasloLogowanie.Size = new System.Drawing.Size(100, 23);
            this.textBoxHasloLogowanie.TabIndex = 7;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.Maroon;
            this.labelLogin.Location = new System.Drawing.Point(170, 84);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(93, 15);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Login jest pusty";
            this.labelLogin.Visible = false;
            // 
            // labelHaslo1
            // 
            this.labelHaslo1.AutoSize = true;
            this.labelHaslo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHaslo1.ForeColor = System.Drawing.Color.Maroon;
            this.labelHaslo1.Location = new System.Drawing.Point(170, 154);
            this.labelHaslo1.Name = "labelHaslo1";
            this.labelHaslo1.Size = new System.Drawing.Size(124, 15);
            this.labelHaslo1.TabIndex = 9;
            this.labelHaslo1.Text = "Hasla sie nie zgadzaja";
            this.labelHaslo1.Visible = false;
            // 
            // labelRODO
            // 
            this.labelRODO.AutoSize = true;
            this.labelRODO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRODO.ForeColor = System.Drawing.Color.Maroon;
            this.labelRODO.Location = new System.Drawing.Point(170, 213);
            this.labelRODO.Name = "labelRODO";
            this.labelRODO.Size = new System.Drawing.Size(172, 15);
            this.labelRODO.TabIndex = 10;
            this.labelRODO.Text = "CheckBox nie jest zaznaczony";
            this.labelRODO.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rejestracja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(589, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Logowanie";
            // 
            // Zadanie_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRODO);
            this.Controls.Add(this.labelHaslo1);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxHasloLogowanie);
            this.Controls.Add(this.textLogowanie);
            this.Controls.Add(this.buttonZaloguj);
            this.Controls.Add(this.checkBoxRODO);
            this.Controls.Add(this.textBoxHasloRejestracja2);
            this.Controls.Add(this.buttonZarejestruj);
            this.Controls.Add(this.textBoxHasloRejestracja1);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Zadanie_5";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxHasloRejestracja1;
        private System.Windows.Forms.Button buttonZarejestruj;
        private System.Windows.Forms.TextBox textBoxHasloRejestracja2;
        private System.Windows.Forms.CheckBox checkBoxRODO;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.TextBox textLogowanie;
        private System.Windows.Forms.TextBox textBoxHasloLogowanie;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelHaslo1;
        private System.Windows.Forms.Label labelRODO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

