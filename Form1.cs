namespace CoinToss_App
{
    public partial class Form1 : Form
    {
        int head = 0;
        int tails = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            Random Toss = new Random();
            int num = Toss.Next(1, 3);
            if (num == 1) //tail
            {
                lblResult.Text = "Tail";
                picBox.ImageLocation = @"C:"; //Here you have to put tail picture path
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                tails++;
                lblTails.Text = "Tails: " + tails.ToString();
            }
            else if (num == 2) { //head
                lblResult.Text = "Head";
                picBox.ImageLocation = @"C:"; //Here you have to put head picture path
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                head++;
                lblHeads.Text = "Heads:" + head.ToString();
            }
            else
            {
                lblResult.Text = "Something went wrong. Please try again.";
            }
        }

    }
}