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
            DisplayDinnerLabel.Text = 
                "         This soup is made with the freshest ingredients.\n" +
              "The broth is made from scratch and simmered for hours.\n" +
              "      The vegetables are locally sourced and hand picked.\n" +
              "              Served with a side of fresh baked bread.";
        }

        private void SaladButton_Click(object sender, EventArgs e)
        {
            DisplaySpecialLabel.Text = "  ~Special Steak Salad~";
            DisplayDinnerLabel.Text = 
                "          This Steak came from a locally raised cow.\n" +
              "The cut of meat is stright from the finest American Wagyu.\n" +
              "        Dristled with a homemade raspberry vinaigrette. \n" +
              "Served on a bed of Micro greens stright from moms garden.";
        }

        private void FishButton_Click(object sender, EventArgs e)
        {
            DisplaySpecialLabel.Text = "~Freash Alaskan Salmon~";
            DisplayDinnerLabel.Text = 
                "  This salmon is caught fresh from the Alaskan waters.\n" +
                "The salmon is seasoned with a blend of herbs and spices.\n" +
                "      It is then grilled to perfection and served with a \n" +
                "lemon butter sauce. Served with a side of roasted vegetables.";
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
