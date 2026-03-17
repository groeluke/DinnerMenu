/*Luke Groesbeck
Spring 2026
RCET 2265
Project DinnerMenu
Computer Fundamentals and Introduction to Programming
https://github.com/groeluke/DinnerMenu.git
*/

namespace DinnerMenu
{
    public partial class DinerSpecialMenu : Form
    {
        public DinerSpecialMenu()
        {
            InitializeComponent();
            // Initialize the form and its components.
        }

        private void SoupButton_Click(object sender, EventArgs e)
        {
            DisplaySpecialLabel.Text = "   ~Fresh Tomato Soup~";
            DisplayDinnerLabel.Text = 
                "        This soup is made with the freshest ingredients.\n" +
              "The broth base is made from scratch and simmered for hours.\n" +
              "     The vegetables are locally sourced and hand picked.\n" +
              "             Served with a side of fresh baked bread.";
            // Display the soup special and description when the button is clicked.
        }

        private void SaladButton_Click(object sender, EventArgs e)
        {
            DisplaySpecialLabel.Text = "  ~Special Steak Salad~";
            DisplayDinnerLabel.Text = 
                "          This Steak came from a locally raised cow.\n" +
              "The cut of meat is stright from the finest American Wagyu.\n" +
              "        Dristled with a homemade raspberry vinaigrette. \n" +
              "Served on a bed of Micro greens stright from moms garden.";
            // Display the salad special and description when the button is clicked.
        }

        private void FishButton_Click(object sender, EventArgs e)
        {
            DisplaySpecialLabel.Text = "~Freash Alaskan Salmon~";
            DisplayDinnerLabel.Text = 
                "  This salmon is caught fresh from the Alaskan waters.\n" +
                "The salmon is seasoned with a blend of herbs and spices.\n" +
                "      It is then grilled to perfection and served with a \n" +
                "lemon butter sauce. Served with a side of roasted vegetables.";
            // Display the fish special and description when the button is clicked.
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // Close the application when the exit button is clicked.
        }
        private void DinerLabel_Click(object sender, EventArgs e)
        {

        }

        private void DinerSpecialMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
