namespace Week_3_Lab_Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit(object sender, EventArgs e)
        {
            string gender = "", age = "", maritalStatus = "", annualIncome ="", employmentStatus = "",educationalAttainment = "";

            if (rbtnMale.Checked)
            {
                gender = rbtnMale.Text;
            }
            else if (rbtnFemale.Checked)
            {
                gender = rbtnFemale.Text;
            }
            else if (rbtnNonBinary.Checked)
            {
                gender= rbtnNonBinary.Text;
            }
            else if(rbtnNotSay.Checked) 
            {
               gender = rbtnNotSay.Text;
            }

            if (rbtnAge1.Checked)
            {
                age = rbtnAge1.Text;
            }
            else if (rbtnAge2.Checked)
            {
                age = rbtnAge2.Text;
            }
            else if (rbtnAge3.Checked)
            {
                age = rbtnAge3.Text;
            }
            else if (rbtnAge4.Checked)
            {
                age = rbtnAge4.Text;
            }
            else if (rbtnAge5.Checked)
            {
                age = rbtnAge5.Text;
            }
            else if (rbtnAge6.Checked)
            {
                age = rbtnAge6.Text;
            }
            else if (rbtnAge7.Checked)
            {
                age = rbtnAge7.Text;
            }

            MessageBox.Show("Successfully Submitted!" + Environment.NewLine + Environment.NewLine + "Thank you for filling out this preference survey." + Environment.NewLine 
                + Environment.NewLine + "Summary of Details: " + Environment.NewLine + "Gender: " + gender + Environment.NewLine + "Age Range" + age + Environment.NewLine 
                + "Marital Status: " + maritalStatus + Environment.NewLine + "Annual Income Range: " + annualIncome + Environment.NewLine + "Employment Status: " + employmentStatus 
                + Environment.NewLine + "Highest Educational Attainment: " + educationalAttainment + Environment.NewLine + "Frequency of Exercise: " + Environment.NewLine 
                + "Frequency on the Usage of Sportswear Products: " + Environment.NewLine + "" + Environment.NewLine + "" + Environment.NewLine + "Influence: " + Environment.NewLine
                + Environment.NewLine);
        }
    }
}
