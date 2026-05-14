namespace MyContacts
{
    partial class AddContactWindow
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
            PB_ContactPhoto = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LB_Email = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TB_Name = new TextBox();
            TB_Prenom = new TextBox();
            TB_Email = new TextBox();
            TB_Adresse = new TextBox();
            TB_Tel = new TextBox();
            TB_Ville = new TextBox();
            label7 = new Label();
            Groupe = new ComboBox();
            BT_Add = new Button();
            BT_ChooseImqge = new Button();
            ((System.ComponentModel.ISupportInitialize)PB_ContactPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PB_ContactPhoto
            // 
            PB_ContactPhoto.BorderStyle = BorderStyle.FixedSingle;
            PB_ContactPhoto.Location = new Point(12, 12);
            PB_ContactPhoto.Name = "PB_ContactPhoto";
            PB_ContactPhoto.Size = new Size(581, 405);
            PB_ContactPhoto.SizeMode = PictureBoxSizeMode.CenterImage;
            PB_ContactPhoto.TabIndex = 1;
            PB_ContactPhoto.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 423);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(581, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 696);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 11;
            label3.Text = "Ville :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 595);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 10;
            label2.Text = "Adresse :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 591);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 9;
            label1.Text = "Tel :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LB_Email
            // 
            LB_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_Email.Location = new Point(35, 537);
            LB_Email.Name = "LB_Email";
            LB_Email.Size = new Size(88, 38);
            LB_Email.TabIndex = 8;
            LB_Email.Text = "Email :";
            LB_Email.TextAlign = ContentAlignment.MiddleRight;
            LB_Email.Click += LB_Email_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 485);
            label4.Name = "label4";
            label4.Size = new Size(122, 38);
            label4.TabIndex = 12;
            label4.Text = "Prenom :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 437);
            label5.Name = "label5";
            label5.Size = new Size(98, 38);
            label5.TabIndex = 13;
            label5.Text = "Nom :";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 750);
            label6.Name = "label6";
            label6.Size = new Size(122, 38);
            label6.TabIndex = 14;
            label6.Text = "Groupe :";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TB_Name
            // 
            TB_Name.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Name.Location = new Point(166, 437);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(410, 45);
            TB_Name.TabIndex = 15;
            // 
            // TB_Prenom
            // 
            TB_Prenom.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Prenom.Location = new Point(166, 485);
            TB_Prenom.Name = "TB_Prenom";
            TB_Prenom.Size = new Size(410, 45);
            TB_Prenom.TabIndex = 16;
            // 
            // TB_Email
            // 
            TB_Email.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Email.Location = new Point(166, 537);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(410, 45);
            TB_Email.TabIndex = 17;
            // 
            // TB_Adresse
            // 
            TB_Adresse.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Adresse.Location = new Point(166, 588);
            TB_Adresse.Name = "TB_Adresse";
            TB_Adresse.Size = new Size(410, 45);
            TB_Adresse.TabIndex = 18;
            // 
            // TB_Tel
            // 
            TB_Tel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Tel.Location = new Point(166, 639);
            TB_Tel.Name = "TB_Tel";
            TB_Tel.Size = new Size(410, 45);
            TB_Tel.TabIndex = 19;
            // 
            // TB_Ville
            // 
            TB_Ville.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Ville.Location = new Point(166, 690);
            TB_Ville.Name = "TB_Ville";
            TB_Ville.Size = new Size(410, 45);
            TB_Ville.TabIndex = 20;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(50, 646);
            label7.Name = "label7";
            label7.Size = new Size(88, 38);
            label7.TabIndex = 22;
            label7.Text = "Tel :";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Groupe
            // 
            Groupe.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Groupe.FormattingEnabled = true;
            Groupe.Location = new Point(166, 745);
            Groupe.Name = "Groupe";
            Groupe.Size = new Size(410, 46);
            Groupe.TabIndex = 23;
            // 
            // BT_Add
            // 
            BT_Add.Dock = DockStyle.Bottom;
            BT_Add.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BT_Add.Location = new Point(0, 824);
            BT_Add.Name = "BT_Add";
            BT_Add.Size = new Size(602, 34);
            BT_Add.TabIndex = 24;
            BT_Add.Text = "Ajouter un contact";
            BT_Add.UseVisualStyleBackColor = true;
            // 
            // BT_ChooseImqge
            // 
            BT_ChooseImqge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BT_ChooseImqge.Location = new Point(11, 371);
            BT_ChooseImqge.Name = "BT_ChooseImqge";
            BT_ChooseImqge.Size = new Size(565, 34);
            BT_ChooseImqge.TabIndex = 25;
            BT_ChooseImqge.Text = "Choisir une image";
            BT_ChooseImqge.UseVisualStyleBackColor = true;
            // 
            // AddContactWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 858);
            Controls.Add(BT_ChooseImqge);
            Controls.Add(BT_Add);
            Controls.Add(Groupe);
            Controls.Add(label7);
            Controls.Add(TB_Ville);
            Controls.Add(TB_Tel);
            Controls.Add(TB_Adresse);
            Controls.Add(TB_Email);
            Controls.Add(TB_Prenom);
            Controls.Add(TB_Name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LB_Email);
            Controls.Add(pictureBox1);
            Controls.Add(PB_ContactPhoto);
            Name = "AddContactWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter un contact";
            ((System.ComponentModel.ISupportInitialize)PB_ContactPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PB_ContactPhoto;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label LB_Email;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TB_Name;
        private TextBox TB_Prenom;
        private TextBox TB_Email;
        private TextBox TB_Adresse;
        private TextBox TB_Tel;
        private TextBox TB_Ville;
        private Label label7;
        private ComboBox Groupe;
        private Button BT_Add;
        private Button BT_ChooseImqge;
    }
}