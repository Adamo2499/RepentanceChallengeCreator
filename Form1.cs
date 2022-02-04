namespace RepentanceChallengeCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String newName = Microsoft.VisualBasic.Interaction.InputBox("Set a new name to challenge pack", "Challenge Pack Name", "");
            if(newName != null)
            {
                challengePackName.Text = newName;
            }
        }
    }
}