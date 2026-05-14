namespace MyContacts
{
    public partial class BT_AddContact : Form
    {
        public BT_AddContact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContactWindow acw = new AddContactWindow();
            acw.ShowDialog();   
        }
    }
}
