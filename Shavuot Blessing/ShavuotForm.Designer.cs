namespace Shavuot_Blessing
{
    partial class ShavuotForm
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
            this.components = new System.ComponentModel.Container();
            this.addPerson = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.EncryptBox = new System.Windows.Forms.CheckBox();
            this.colorTimer = new System.Windows.Forms.Timer(this.components);
            this.personLabel = new System.Windows.Forms.Label();
            this.queueTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addPerson
            // 
            this.addPerson.BackColor = System.Drawing.Color.Wheat;
            this.addPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPerson.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPerson.ForeColor = System.Drawing.Color.Black;
            this.addPerson.Location = new System.Drawing.Point(392, 426);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(92, 34);
            this.addPerson.TabIndex = 1;
            this.addPerson.Text = "Add";
            this.addPerson.UseVisualStyleBackColor = false;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Wheat;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(31, 426);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(251, 34);
            this.comboBox.TabIndex = 2;
            this.comboBox.Text = "Insert Name Here...";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.mainLabel.Location = new System.Drawing.Point(11, 48);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(301, 46);
            this.mainLabel.TabIndex = 3;
            this.mainLabel.Text = "Greetings to...";
            // 
            // ageBox
            // 
            this.ageBox.BackColor = System.Drawing.Color.Wheat;
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.Location = new System.Drawing.Point(309, 426);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(59, 34);
            this.ageBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Wheat;
            this.nameLabel.Location = new System.Drawing.Point(17, 399);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 20);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name :";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.Wheat;
            this.ageLabel.Location = new System.Drawing.Point(293, 399);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(46, 20);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Age :";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Wheat;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.startButton.FlatAppearance.BorderSize = 5;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(671, 426);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(117, 97);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // EncryptBox
            // 
            this.EncryptBox.AutoSize = true;
            this.EncryptBox.BackColor = System.Drawing.Color.Transparent;
            this.EncryptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptBox.ForeColor = System.Drawing.Color.Wheat;
            this.EncryptBox.Location = new System.Drawing.Point(692, 401);
            this.EncryptBox.Name = "EncryptBox";
            this.EncryptBox.Size = new System.Drawing.Size(72, 20);
            this.EncryptBox.TabIndex = 8;
            this.EncryptBox.Text = "Encrypt";
            this.EncryptBox.UseVisualStyleBackColor = false;
            // 
            // colorTimer
            // 
            this.colorTimer.Interval = 1000;
            this.colorTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // personLabel
            // 
            this.personLabel.AutoSize = true;
            this.personLabel.BackColor = System.Drawing.Color.Transparent;
            this.personLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.personLabel.Location = new System.Drawing.Point(110, 130);
            this.personLabel.Name = "personLabel";
            this.personLabel.Size = new System.Drawing.Size(0, 46);
            this.personLabel.TabIndex = 9;
            // 
            // queueTimer
            // 
            this.queueTimer.Interval = 2000;
            this.queueTimer.Tick += new System.EventHandler(this.queueTimer_Tick);
            // 
            // ShavuotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shavuot_Blessing.Properties.Resources.shavuot_wheat;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.personLabel);
            this.Controls.Add(this.EncryptBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.addPerson);
            this.Name = "ShavuotForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox EncryptBox;
        private System.Windows.Forms.Timer colorTimer;
        private System.Windows.Forms.Label personLabel;
        private System.Windows.Forms.Timer queueTimer;
    }
}

