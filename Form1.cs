namespace LAB3_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLetterGrade_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScore.Text, out int score) || score < 0 || score > 100)
            {
                lblResult.Text = "Enter the whole number from 0 to 100.";
                return;
            }
            lblResult.Text = $"Letter Grade: {GetLetterGrade(score)}";
        }
        private string GetLetterGrade(int score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80)
                return "B";
            else if (score >= 70)
                return "C";
            else if (score >= 60)
                return "D";
            else
                return "F";
        }
        private int CalculateNeededScore(int score)
        {
            return 100 - score;
        }

        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScore.Text, out int score) || score < 0 || score > 100)
            {
                lblResult.Text = "Enter a whole number from 0 to 100.";
                return;
            }
            lblResult.Text = IsPassing(score) ? "PASS" : "FAIL";
        }
        private bool IsPassing(int score)
        {
            return score >= 50;
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScore.Text,out int score) || score < 0 || score > 100)
            {
                lblResult.Text = "Enter the whole number from 0 to 100";
                return;
            }
            lblResult.Text=$"{CalculateNeededScore(score)} points to reaach 100";
        }
    }
}
