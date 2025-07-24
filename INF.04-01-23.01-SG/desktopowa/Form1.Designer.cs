namespace WinFormsApp1
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
            generowanieHasla = new GroupBox();
            button_generuj = new Button();
            checkBox_znakiSpecjalne = new CheckBox();
            checkBox_cyfry = new CheckBox();
            checkBox_litery = new CheckBox();
            input_ileznakow = new TextBox();
            label_ileznakow = new Label();
            input_imie = new TextBox();
            label_imie = new Label();
            input_nazwisko = new TextBox();
            label_nazwisko = new Label();
            label_stanowisko = new Label();
            danePracownika = new GroupBox();
            combobox_stanowisko = new ComboBox();
            button_zatwierdz = new Button();
            generowanieHasla.SuspendLayout();
            danePracownika.SuspendLayout();
            SuspendLayout();
            // 
            // generowanieHasla
            // 
            generowanieHasla.Controls.Add(button_generuj);
            generowanieHasla.Controls.Add(checkBox_znakiSpecjalne);
            generowanieHasla.Controls.Add(checkBox_cyfry);
            generowanieHasla.Controls.Add(checkBox_litery);
            generowanieHasla.Controls.Add(input_ileznakow);
            generowanieHasla.Controls.Add(label_ileznakow);
            generowanieHasla.Location = new Point(438, 46);
            generowanieHasla.Name = "generowanieHasla";
            generowanieHasla.Size = new Size(324, 231);
            generowanieHasla.TabIndex = 1;
            generowanieHasla.TabStop = false;
            generowanieHasla.Text = "Generowanie hasła";
            generowanieHasla.Enter += groupBox2_Enter;
            // 
            // button_generuj
            // 
            button_generuj.BackColor = Color.SteelBlue;
            button_generuj.Location = new Point(100, 188);
            button_generuj.Name = "button_generuj";
            button_generuj.Size = new Size(121, 25);
            button_generuj.TabIndex = 7;
            button_generuj.Text = "Generuj hasło";
            button_generuj.UseVisualStyleBackColor = false;
            button_generuj.Click += button_generuj_Click;
            // 
            // checkBox_znakiSpecjalne
            // 
            checkBox_znakiSpecjalne.AutoSize = true;
            checkBox_znakiSpecjalne.Location = new Point(25, 141);
            checkBox_znakiSpecjalne.Name = "checkBox_znakiSpecjalne";
            checkBox_znakiSpecjalne.Size = new Size(107, 19);
            checkBox_znakiSpecjalne.TabIndex = 6;
            checkBox_znakiSpecjalne.Text = "Znaki specjalne";
            checkBox_znakiSpecjalne.UseVisualStyleBackColor = true;
            // 
            // checkBox_cyfry
            // 
            checkBox_cyfry.AutoSize = true;
            checkBox_cyfry.Location = new Point(25, 116);
            checkBox_cyfry.Name = "checkBox_cyfry";
            checkBox_cyfry.Size = new Size(54, 19);
            checkBox_cyfry.TabIndex = 5;
            checkBox_cyfry.Text = "Cyfry";
            checkBox_cyfry.UseVisualStyleBackColor = true;
            // 
            // checkBox_litery
            // 
            checkBox_litery.AutoSize = true;
            checkBox_litery.Location = new Point(25, 91);
            checkBox_litery.Name = "checkBox_litery";
            checkBox_litery.Size = new Size(126, 19);
            checkBox_litery.TabIndex = 4;
            checkBox_litery.Text = "Małe i wielkie litery";
            checkBox_litery.UseVisualStyleBackColor = true;
            // 
            // input_ileznakow
            // 
            input_ileznakow.Location = new Point(132, 45);
            input_ileznakow.Name = "input_ileznakow";
            input_ileznakow.Size = new Size(174, 23);
            input_ileznakow.TabIndex = 3;
            input_ileznakow.TextChanged += textBox1_TextChanged;
            // 
            // label_ileznakow
            // 
            label_ileznakow.AutoSize = true;
            label_ileznakow.Location = new Point(25, 48);
            label_ileznakow.Name = "label_ileznakow";
            label_ileznakow.Size = new Size(67, 15);
            label_ileznakow.TabIndex = 2;
            label_ileznakow.Text = "Ile znaków?";
            label_ileznakow.Click += label1_Click_1;
            // 
            // input_imie
            // 
            input_imie.Location = new Point(174, 45);
            input_imie.Name = "input_imie";
            input_imie.Size = new Size(174, 23);
            input_imie.TabIndex = 0;
            // 
            // label_imie
            // 
            label_imie.AutoSize = true;
            label_imie.Location = new Point(56, 48);
            label_imie.Name = "label_imie";
            label_imie.Size = new Size(30, 15);
            label_imie.TabIndex = 1;
            label_imie.Text = "Imię";
            // 
            // input_nazwisko
            // 
            input_nazwisko.Location = new Point(173, 92);
            input_nazwisko.Name = "input_nazwisko";
            input_nazwisko.Size = new Size(174, 23);
            input_nazwisko.TabIndex = 2;
            // 
            // label_nazwisko
            // 
            label_nazwisko.AutoSize = true;
            label_nazwisko.Location = new Point(56, 95);
            label_nazwisko.Name = "label_nazwisko";
            label_nazwisko.Size = new Size(57, 15);
            label_nazwisko.TabIndex = 3;
            label_nazwisko.Text = "Naziwsko";
            // 
            // label_stanowisko
            // 
            label_stanowisko.AutoSize = true;
            label_stanowisko.Location = new Point(56, 148);
            label_stanowisko.Name = "label_stanowisko";
            label_stanowisko.Size = new Size(67, 15);
            label_stanowisko.TabIndex = 4;
            label_stanowisko.Text = "Stanowisko";
            label_stanowisko.Click += label1_Click;
            // 
            // danePracownika
            // 
            danePracownika.Controls.Add(combobox_stanowisko);
            danePracownika.Controls.Add(label_stanowisko);
            danePracownika.Controls.Add(label_nazwisko);
            danePracownika.Controls.Add(input_nazwisko);
            danePracownika.Controls.Add(label_imie);
            danePracownika.Controls.Add(input_imie);
            danePracownika.Location = new Point(46, 46);
            danePracownika.Name = "danePracownika";
            danePracownika.Size = new Size(375, 231);
            danePracownika.TabIndex = 0;
            danePracownika.TabStop = false;
            danePracownika.Text = "Dane pracownika";
            danePracownika.Enter += danepracownika_Enter;
            // 
            // combobox_stanowisko
            // 
            combobox_stanowisko.FormattingEnabled = true;
            combobox_stanowisko.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            combobox_stanowisko.Location = new Point(174, 145);
            combobox_stanowisko.Name = "combobox_stanowisko";
            combobox_stanowisko.Size = new Size(173, 23);
            combobox_stanowisko.TabIndex = 5;
            combobox_stanowisko.SelectedIndexChanged += combobox_stanowisko_SelectedIndexChanged;
            // 
            // button_zatwierdz
            // 
            button_zatwierdz.BackColor = Color.SteelBlue;
            button_zatwierdz.Location = new Point(261, 300);
            button_zatwierdz.Name = "button_zatwierdz";
            button_zatwierdz.Size = new Size(328, 25);
            button_zatwierdz.TabIndex = 8;
            button_zatwierdz.Text = "Zatwierdź";
            button_zatwierdz.UseVisualStyleBackColor = false;
            button_zatwierdz.Click += button_zatwierdz_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(803, 349);
            Controls.Add(button_zatwierdz);
            Controls.Add(generowanieHasla);
            Controls.Add(danePracownika);
            Name = "Form1";
            Text = "Dodaj pracownika 00000";
            generowanieHasla.ResumeLayout(false);
            generowanieHasla.PerformLayout();
            danePracownika.ResumeLayout(false);
            danePracownika.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox generowanieHasla;
        private TextBox input_imie;
        private Label label_imie;
        private TextBox input_nazwisko;
        private Label label_nazwisko;
        private Label label_stanowisko;
        private GroupBox danePracownika;
        private ComboBox combobox_stanowisko;
        private TextBox input_ileznakow;
        private Label label_ileznakow;
        private Button button_generuj;
        private CheckBox checkBox_znakiSpecjalne;
        private CheckBox checkBox_cyfry;
        private CheckBox checkBox_litery;
        private Button button_zatwierdz;
    }
}
