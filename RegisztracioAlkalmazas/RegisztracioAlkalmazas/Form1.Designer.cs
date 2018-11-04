namespace RegisztracioAlkalmazas
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.boyRadioBtn = new System.Windows.Forms.RadioButton();
            this.girlRadioBtn = new System.Windows.Forms.RadioButton();
            this.hobbiLabel = new System.Windows.Forms.Label();
            this.newhobbiLabel = new System.Windows.Forms.Label();
            this.newhobbiTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.hobbieListBox = new System.Windows.Forms.ListBox();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(36, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Név : ";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(8, 50);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(71, 13);
            this.birthLabel.TabIndex = 1;
            this.birthLabel.Text = "Szül. dátum : ";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(8, 76);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(38, 13);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Nem : ";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(90, 21);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 3;
            // 
            // boyRadioBtn
            // 
            this.boyRadioBtn.AutoSize = true;
            this.boyRadioBtn.Location = new System.Drawing.Point(122, 76);
            this.boyRadioBtn.Name = "boyRadioBtn";
            this.boyRadioBtn.Size = new System.Drawing.Size(31, 17);
            this.boyRadioBtn.TabIndex = 5;
            this.boyRadioBtn.TabStop = true;
            this.boyRadioBtn.Text = "F";
            this.boyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // girlRadioBtn
            // 
            this.girlRadioBtn.AutoSize = true;
            this.girlRadioBtn.Location = new System.Drawing.Point(159, 76);
            this.girlRadioBtn.Name = "girlRadioBtn";
            this.girlRadioBtn.Size = new System.Drawing.Size(33, 17);
            this.girlRadioBtn.TabIndex = 6;
            this.girlRadioBtn.TabStop = true;
            this.girlRadioBtn.Text = "N";
            this.girlRadioBtn.UseVisualStyleBackColor = true;
            // 
            // hobbiLabel
            // 
            this.hobbiLabel.AutoSize = true;
            this.hobbiLabel.Location = new System.Drawing.Point(196, 24);
            this.hobbiLabel.Name = "hobbiLabel";
            this.hobbiLabel.Size = new System.Drawing.Size(85, 13);
            this.hobbiLabel.TabIndex = 7;
            this.hobbiLabel.Text = "Kedvenc hobbi :";
            // 
            // newhobbiLabel
            // 
            this.newhobbiLabel.AutoSize = true;
            this.newhobbiLabel.Location = new System.Drawing.Point(196, 142);
            this.newhobbiLabel.Name = "newhobbiLabel";
            this.newhobbiLabel.Size = new System.Drawing.Size(55, 13);
            this.newhobbiLabel.TabIndex = 9;
            this.newhobbiLabel.Text = "Új hobbi : ";
            // 
            // newhobbiTxtBox
            // 
            this.newhobbiTxtBox.Location = new System.Drawing.Point(287, 139);
            this.newhobbiTxtBox.Name = "newhobbiTxtBox";
            this.newhobbiTxtBox.Size = new System.Drawing.Size(100, 20);
            this.newhobbiTxtBox.TabIndex = 10;
            this.newhobbiTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newhobbiTxtBox_KeyDown);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(287, 165);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 47);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Hozzáad";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(92, 140);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 72);
            this.loadBtn.TabIndex = 12;
            this.loadBtn.Text = "Betöltés";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(11, 140);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 72);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Mentés";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // hobbieListBox
            // 
            this.hobbieListBox.FormattingEnabled = true;
            this.hobbieListBox.Location = new System.Drawing.Point(287, 12);
            this.hobbieListBox.Name = "hobbieListBox";
            this.hobbieListBox.Size = new System.Drawing.Size(100, 121);
            this.hobbieListBox.TabIndex = 14;
            this.hobbieListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hobbieListBox_KeyDown);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(90, 47);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(139, 20);
            this.birthDatePicker.TabIndex = 15;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(225, 165);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(56, 47);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Törlés";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 224);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.hobbieListBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.newhobbiTxtBox);
            this.Controls.Add(this.newhobbiLabel);
            this.Controls.Add(this.hobbiLabel);
            this.Controls.Add(this.girlRadioBtn);
            this.Controls.Add(this.boyRadioBtn);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adatlap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.RadioButton boyRadioBtn;
        private System.Windows.Forms.RadioButton girlRadioBtn;
        private System.Windows.Forms.Label hobbiLabel;
        private System.Windows.Forms.Label newhobbiLabel;
        private System.Windows.Forms.TextBox newhobbiTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox hobbieListBox;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Button deleteBtn;
    }
}

