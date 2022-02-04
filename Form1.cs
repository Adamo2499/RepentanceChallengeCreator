namespace RepentanceChallengeCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            String newName = Microsoft.VisualBasic.Interaction.InputBox("Set a new name to challenge pack", "Challenge Pack Name", "");
            if(newName != null)
            {
                challengePackName.Text = newName;
            }
        }

        

        private void createChallenge_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            form2.Show();
        }

        private void modifyChallenge_Click(object sender, EventArgs e)
        {
            try
            { 
                
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show(null,"Select challenge to modify", "Error", MessageBoxButtons.OK);
            }
        }
        private void removeChallenge_Click(object sender, EventArgs e)
        {
            try
            {
                if (challengesList.Items.Count > 0)
                {
                    challengesList.Items.RemoveAt(challengesList.SelectedIndex);
                }
                else
                {
                    MessageBox.Show(null, "List is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(null, "Select challenge to remove!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}