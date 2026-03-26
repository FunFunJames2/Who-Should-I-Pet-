namespace who_to_pet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int pet = Random.Shared.Next(1, 6);
            switch (pet)
            {
                case 1:
                    whoToPet.Text = "You should pet Fluffy.";
                break;
                case 2:
                    whoToPet.Text = "You should pet Nova.";
                break;
                case 3:
                    whoToPet.Text = "You should pet Blossom.";
                break;
                case 4:
                    whoToPet.Text = "You should pet Cinnabon.";
                break;
                case 5:
                    whoToPet.Text = "You should pet Arnie.";
                break;
                default:
                    whoToPet.Text = "Something went wrong, and we couldn't generate a random number. Sorry! :(";
                break;
            }
        }
    }
}
