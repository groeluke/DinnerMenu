namespace DinnerMenu
{
    public partial class DinerSpecialMenu : Form
    {
        public DinerSpecialMenu()
        {
            InitializeComponent();
        }

        private void DinerLabel_Click(object sender, EventArgs e)
        {

        }

        private void SoupButton_Click(object sender, EventArgs e)
        {
            DisplaySpecialLabel.Text = "    ~Soup of the Day~";
        }

        private void SaladButton_Click(object sender, EventArgs e)
        {
            DisplaySpecialLabel.Text = "  ~Special Steak Salad~";
        }

        private void FishButton_Click(object sender, EventArgs e)
        {
            DisplaySpecialLabel.Text = "~Freash Alaskan Salmon~";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DinerSpecialMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
