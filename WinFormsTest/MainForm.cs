namespace WinFormsTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello, {FirstNameText.Text} {LastNameText.Text}!\n\nHope you're having a great time with WinForms!");
        }
    }
}
