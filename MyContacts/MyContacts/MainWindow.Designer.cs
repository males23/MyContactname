namespace MyContacts
{
    partial class BT_AddContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BT_AddContact));
            PNL_Left = new Panel();
            group_contact_list = new GroupBox();
            Group_Search = new GroupBox();
            TB_Search = new TextBox();
            button1 = new Button();
            LB_Contacts = new ListBox();
            CB_group = new ComboBox();
            PNL_Right = new Panel();
            BT_DeleteContact = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LB_EmailText = new Label();
            LB_Email = new Label();
            LB_Name = new Label();
            LB_Group = new Label();
            PB_ContactPhoto = new PictureBox();
            PNL_Left.SuspendLayout();
            group_contact_list.SuspendLayout();
            Group_Search.SuspendLayout();
            PNL_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_ContactPhoto).BeginInit();
            SuspendLayout();
            // 
            // PNL_Left
            // 
            PNL_Left.Controls.Add(group_contact_list);
            PNL_Left.Location = new Point(2, -2);
            PNL_Left.Name = "PNL_Left";
            PNL_Left.Size = new Size(360, 676);
            PNL_Left.TabIndex = 0;
            // 
            // group_contact_list
            // 
            group_contact_list.Controls.Add(Group_Search);
            group_contact_list.Controls.Add(button1);
            group_contact_list.Controls.Add(LB_Contacts);
            group_contact_list.Controls.Add(CB_group);
            group_contact_list.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            group_contact_list.Location = new Point(10, 14);
            group_contact_list.Name = "group_contact_list";
            group_contact_list.Size = new Size(350, 662);
            group_contact_list.TabIndex = 1;
            group_contact_list.TabStop = false;
            group_contact_list.Text = "Mes contacts";
            // 
            // Group_Search
            // 
            Group_Search.Controls.Add(TB_Search);
            Group_Search.Location = new Point(6, 576);
            Group_Search.Name = "Group_Search";
            Group_Search.Size = new Size(335, 80);
            Group_Search.TabIndex = 1;
            Group_Search.TabStop = false;
            Group_Search.Text = "Rechercher :";
            // 
            // TB_Search
            // 
            TB_Search.Location = new Point(6, 37);
            TB_Search.Name = "TB_Search";
            TB_Search.Size = new Size(323, 39);
            TB_Search.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(28, 510);
            button1.Name = "button1";
            button1.Size = new Size(296, 54);
            button1.TabIndex = 1;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LB_Contacts
            // 
            LB_Contacts.FormattingEnabled = true;
            LB_Contacts.ItemHeight = 32;
            LB_Contacts.Location = new Point(6, 84);
            LB_Contacts.Name = "LB_Contacts";
            LB_Contacts.Size = new Size(335, 420);
            LB_Contacts.Sorted = true;
            LB_Contacts.TabIndex = 1;
            // 
            // CB_group
            // 
            CB_group.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_group.FormattingEnabled = true;
            CB_group.Location = new Point(6, 38);
            CB_group.Name = "CB_group";
            CB_group.Size = new Size(335, 40);
            CB_group.TabIndex = 1;
            // 
            // PNL_Right
            // 
            PNL_Right.Controls.Add(BT_DeleteContact);
            PNL_Right.Controls.Add(label6);
            PNL_Right.Controls.Add(label5);
            PNL_Right.Controls.Add(label4);
            PNL_Right.Controls.Add(label3);
            PNL_Right.Controls.Add(label2);
            PNL_Right.Controls.Add(label1);
            PNL_Right.Controls.Add(LB_EmailText);
            PNL_Right.Controls.Add(LB_Email);
            PNL_Right.Controls.Add(LB_Name);
            PNL_Right.Controls.Add(LB_Group);
            PNL_Right.Controls.Add(PB_ContactPhoto);
            PNL_Right.Location = new Point(368, 12);
            PNL_Right.Name = "PNL_Right";
            PNL_Right.Size = new Size(592, 662);
            PNL_Right.TabIndex = 1;
            // 
            // BT_DeleteContact
            // 
            BT_DeleteContact.BackColor = Color.Transparent;
            BT_DeleteContact.BackgroundImage = (Image)resources.GetObject("BT_DeleteContact.BackgroundImage");
            BT_DeleteContact.BackgroundImageLayout = ImageLayout.Stretch;
            BT_DeleteContact.FlatStyle = FlatStyle.Flat;
            BT_DeleteContact.Location = new Point(538, 12);
            BT_DeleteContact.Name = "BT_DeleteContact";
            BT_DeleteContact.Size = new Size(32, 32);
            BT_DeleteContact.TabIndex = 11;
            BT_DeleteContact.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(97, 613);
            label6.Name = "label6";
            label6.Size = new Size(487, 38);
            label6.TabIndex = 10;
            label6.Text = "Montpellier";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(131, 568);
            label5.Name = "label5";
            label5.Size = new Size(458, 38);
            label5.TabIndex = 9;
            label5.Text = "23 Rue du Puech 34000";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(97, 526);
            label4.Name = "label4";
            label4.Size = new Size(487, 38);
            label4.TabIndex = 8;
            label4.Text = "06 XX XX XX XX";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 613);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 7;
            label3.Text = "Ville :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 576);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 6;
            label2.Text = "Adresse :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 526);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 5;
            label1.Text = "Tel :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LB_EmailText
            // 
            LB_EmailText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_EmailText.Location = new Point(97, 478);
            LB_EmailText.Name = "LB_EmailText";
            LB_EmailText.Size = new Size(487, 38);
            LB_EmailText.TabIndex = 4;
            LB_EmailText.Text = "aime.males@yahoo.fr";
            LB_EmailText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LB_Email
            // 
            LB_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_Email.Location = new Point(3, 478);
            LB_Email.Name = "LB_Email";
            LB_Email.Size = new Size(88, 38);
            LB_Email.TabIndex = 3;
            LB_Email.Text = "Email :";
            LB_Email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LB_Name
            // 
            LB_Name.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_Name.Location = new Point(3, 408);
            LB_Name.Name = "LB_Name";
            LB_Name.Size = new Size(581, 50);
            LB_Name.TabIndex = 2;
            LB_Name.Text = "Nom Prenom";
            LB_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LB_Group
            // 
            LB_Group.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_Group.Location = new Point(422, 361);
            LB_Group.Name = "LB_Group";
            LB_Group.Size = new Size(162, 38);
            LB_Group.TabIndex = 1;
            LB_Group.Text = "Groupe";
            LB_Group.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PB_ContactPhoto
            // 
            PB_ContactPhoto.BorderStyle = BorderStyle.FixedSingle;
            PB_ContactPhoto.Image = (Image)resources.GetObject("PB_ContactPhoto.Image");
            PB_ContactPhoto.Location = new Point(3, 3);
            PB_ContactPhoto.Name = "PB_ContactPhoto";
            PB_ContactPhoto.Size = new Size(581, 402);
            PB_ContactPhoto.SizeMode = PictureBoxSizeMode.CenterImage;
            PB_ContactPhoto.TabIndex = 0;
            PB_ContactPhoto.TabStop = false;
            // 
            // BT_AddContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 678);
            Controls.Add(PNL_Right);
            Controls.Add(PNL_Left);
            Name = "BT_AddContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyContacts";
            PNL_Left.ResumeLayout(false);
            group_contact_list.ResumeLayout(false);
            Group_Search.ResumeLayout(false);
            Group_Search.PerformLayout();
            PNL_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_ContactPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PNL_Left;
        private GroupBox group_contact_list;
        private ComboBox CB_group;
        private Button button1;
        private ListBox LB_Contacts;
        private GroupBox Group_Search;
        private TextBox TB_Search;
        private Panel PNL_Right;
        private PictureBox PB_ContactPhoto;
        private Label LB_Group;
        private Label LB_Name;
        private Label LB_EmailText;
        private Label LB_Email;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button BT_DeleteContact;
    }
}
