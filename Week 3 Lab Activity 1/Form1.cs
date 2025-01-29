using Week_3_Lab_Activity_1.Properties;

namespace Week_3_Lab_Activity_1
{
    public partial class Form1 : Form
    {
        string[] surveyDetails = new string[16];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit(object sender, EventArgs e)
        {
            string[] personalInformation = new string[7];

            if (rbtnMale.Checked)
            {
                personalInformation[0] = rbtnMale.Text;
            }
            else if (rbtnFemale.Checked)
            {
                personalInformation[0] = rbtnFemale.Text;
            }
            else if (rbtnNonBinary.Checked)
            {
                personalInformation[0] = rbtnNonBinary.Text;
            }
            else if (rbtnNotSay.Checked)
            {
                personalInformation[0] = rbtnNotSay.Text;
            }

            if (rbtnAge1.Checked)
            {
                personalInformation[1] = rbtnAge1.Text;
            }
            else if (rbtnAge2.Checked)
            {
                personalInformation[1] = rbtnAge2.Text;
            }
            else if (rbtnAge3.Checked)
            {
                personalInformation[1] = rbtnAge3.Text;
            }
            else if (rbtnAge4.Checked)
            {
                personalInformation[1] = rbtnAge4.Text;
            }
            else if (rbtnAge5.Checked)
            {
                personalInformation[1] = rbtnAge5.Text;
            }
            else if (rbtnAge6.Checked)
            {
                personalInformation[1] = rbtnAge6.Text;
            }
            else if (rbtnAge7.Checked)
            {
                personalInformation[1] = rbtnAge7.Text;
            }

            if (rbtnSingle.Checked)
            {
                personalInformation[2] = rbtnSingle.Text;
            }
            else if (rbtnDivorced.Checked)
            {
                personalInformation[2] = rbtnDivorced.Text;
            }
            else if (rbtnMarried.Checked)
            {
                personalInformation[2] = rbtnMarried.Text;
            }
            else if (rbtnWidowed.Checked)
            {
                personalInformation[2] = rbtnWidowed.Text;
            }
            else if (rbtnNotSayStatus.Checked)
            {
                personalInformation[2] = rbtnNotSayStatus.Text;
            }

            if (rbtnIncomeRange1.Checked)
            {
                personalInformation[3] = rbtnIncomeRange1.Text;
            }
            else if (rbtnIncomeRange2.Checked)
            {
                personalInformation[3] = rbtnIncomeRange2.Text;
            }
            else if (rbtnIncomeRange3.Checked)
            {
                personalInformation[3] = rbtnIncomeRange3.Text;
            }
            else if (rbtnIncomeRange4.Checked)
            {
                personalInformation[3] = rbtnIncomeRange4.Text;
            }
            else if (rbtnIncomeRange5.Checked)
            {
                personalInformation[3] = rbtnIncomeRange5.Text;
            }
            else if (rbtnIncomeRange6.Checked)
            {
                personalInformation[3] = rbtnIncomeRange6.Text;
            }
            else if (rbtnIncomeRange7.Checked)
            {
                personalInformation[3] = rbtnIncomeRange7.Text;
            }

            if (rbtnEmployedFull.Checked)
            {
                personalInformation[4] = rbtnEmployedFull.Text;
            }
            else if (rbtnSelfEmployed.Checked)
            {
                personalInformation[4] = rbtnSelfEmployed.Text;
            }
            else if (rbtnEmployedPart.Checked)
            {
                personalInformation[4] = rbtnEmployedPart.Text;
            }
            else if (rbtnUnemployed.Checked)
            {
                personalInformation[4] = rbtnUnemployed.Text;
            }
            else if (rbtnNotJob.Checked)
            {
                personalInformation[4] = rbtnNotJob.Text;
            }
            else if (rbtnHomemaker.Checked)
            {
                personalInformation[4] = rbtnHomemaker.Text;
            }
            else if (rbtnStudent.Checked)
            {
                personalInformation[4] = rbtnStudent.Text;
            }
            else if (rbtnNotSayEmployment.Checked)
            {
                personalInformation[4] = rbtnNotSayEmployment.Text;
            }

            if (rbtneducation1.Checked)
            {
                personalInformation[5] = rbtneducation1.Text;
            }
            else if (rbtneducation2.Checked)
            {
                personalInformation[5] = rbtneducation2.Text;
            }
            else if (rbtneducation3.Checked)
            {
                personalInformation[5] = rbtneducation3.Text;
            }
            else if (rbtneducation4.Checked)
            {
                personalInformation[5] = rbtneducation4.Text;
            }
            else if (rbtneducation5.Checked)
            {
                personalInformation[5] = rbtneducation5.Text;
            }
            else if (rbtneducation6.Checked)
            {
                personalInformation[5] = rbtneducation6.Text;
            }
            else if (rbtneducation7.Checked)
            {
                personalInformation[5] = rbtneducation7.Text;
            }
            else if (rbtneducation8.Checked)
            {
                personalInformation[5] = rbtneducation8.Text;
            }

            if (rbtnExercise1.Checked)
            {
                surveyDetails[0] = "1";
            }
            else if (rbtnExercise2.Checked)
            {
                surveyDetails[0] = "2";
            }
            else if (rbtnExercise3.Checked)
            {
                surveyDetails[0] = "3";
            }
            else if (rbtnExercise4.Checked)
            {
                surveyDetails[0] = "4";
            }
            else if (rbtnExercise5.Checked)
            {
                surveyDetails[0] = "5";
            }
            else if (rbtnExercise6.Checked)
            {
                surveyDetails[0] = "6";
            }
            else if (rbtnExercise7.Checked)
            {
                surveyDetails[0] = "7";
            }
            else if (rbtnExercise8.Checked)
            {
                surveyDetails[0] = "8";
            }
            else if (rbtnExercise9.Checked)
            {
                surveyDetails[0] = "9";
            }
            else if (rbtnExercise10.Checked)
            {
                surveyDetails[0] = "10";
            }

            if (rbtnSportswear1.Checked)
            {
                surveyDetails[1] = "1";
            }
            else if (rbtnSportswear2.Checked)
            {
                surveyDetails[1] = "2";
            }
            else if (rbtnSportswear3.Checked)
            {
                surveyDetails[1] = "3";
            }
            else if (rbtnSportswear4.Checked)
            {
                surveyDetails[1] = "4";
            }
            else if (rbtnSportswear5.Checked)
            {
                surveyDetails[1] = "5";
            }
            else if (rbtnSportswear6.Checked)
            {
                surveyDetails[1] = "6";
            }
            else if (rbtnSportswear7.Checked)
            {
                surveyDetails[1] = "7";
            }
            else if (rbtnSportswear8.Checked)
            {
                surveyDetails[1] = "8";
            }
            else if (rbtnSportswear9.Checked)
            {
                surveyDetails[1] = "9";
            }
            else if (rbtnSportswear10.Checked)
            {
                surveyDetails[1] = "10";
            }

            if (rbtnBought1.Checked)
            {
                surveyDetails[2] = rbtnBought1.Text;
            }
            else if (rbtnBought2.Checked)
            {
                surveyDetails[2] = rbtnBought2.Text;
            }
            else if (rbtnBought3.Checked)
            {
                surveyDetails[2] = rbtnBought3.Text;
            }
            else if (rbtnBought4.Checked)
            {
                surveyDetails[2] = rbtnBought4.Text;
            }
            else if (rbtnBought5.Checked)
            {
                surveyDetails[2] = rbtnBought5.Text;
            }

            if (rbtnPurpose1.Checked)
            {
                surveyDetails[3] = rbtnPurpose1.Text;
            }
            else if (rbtnPurpose2.Checked)
            {
                surveyDetails[3] = rbtnPurpose2.Text;
            }
            else if (rbtnPurpose3.Checked)
            {
                surveyDetails[3] = rbtnPurpose3.Text;
            }
            else if (rbtnPurpose4.Checked)
            {
                surveyDetails[3] = rbtnPurpose4.Text;
            }
            else if (rbtnPurpose5.Checked)
            {
                surveyDetails[3] = rbtnPurpose5.Text;
            }
            else if (rbtnPurpose6.Checked)
            {
                surveyDetails[3] = rbtnPurpose6.Text;
            }

            if (rbtnStore1.Checked)
            {
                surveyDetails[4] = rbtnStore1.Text;
            }
            else if (rbtnStore2.Checked)
            {
                surveyDetails[4] = rbtnStore2.Text;
            }
            else if (rbtnStore3.Checked)
            {
                surveyDetails[4] = rbtnStore3.Text;
            }
            else if (rbtnStore4.Checked)
            {
                surveyDetails[4] = rbtnStore4.Text;
            }
            else if (rbtnStore5.Checked)
            {
                surveyDetails[4] = rbtnStore5.Text;
            }

            if (rbtnDesign1.Checked)
            {
                surveyDetails[5] = rbtnDesign1.Text;
            }
            else if (rbtnDesign2.Checked)
            {
                surveyDetails[5] = rbtnDesign2.Text;
            }
            else if (rbtnDesign3.Checked)
            {
                surveyDetails[5] = rbtnDesign3.Text;
            }
            else if (rbtnDesign4.Checked)
            {
                surveyDetails[5] = rbtnDesign4.Text;
            }

            if (rbtnInfluence1.Checked)
            {
                surveyDetails[6] = rbtnInfluence1.Text;
            }
            else if (rbtnInfluence2.Checked)
            {
                surveyDetails[6] = rbtnInfluence2.Text;
            }
            else if (rbtnInfluence3.Checked)
            {
                surveyDetails[6] = rbtnInfluence3.Text;
            }
            else if (rbtnInfluence4.Checked)
            {
                surveyDetails[6] = rbtnInfluence4.Text;
            }
            else if (rbtnInfluence5.Checked)
            {
                surveyDetails[6] = rbtnInfluence5.Text;
            }

            if (cbxAttribute1.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute1.Text;
            }
            if (cbxAttribute2.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute2.Text;
            }
            if (cbxAttribute3.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute3.Text;
            }
            if (cbxAttribute4.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute4.Text;
            }
            if (cbxAttribute5.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute5.Text;
            }
            if (cbxAttribute6.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute6.Text;
            }
            if (cbxAttribute7.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute7.Text;
            }
            if (cbxAttribute8.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute8.Text;
            }
            if (cbxAttribute9.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute9.Text;
            }
            if (cbxAttribute10.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute10.Text;
            }
            if (cbxAttribute11.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute11.Text;
            }
            if (cbxAttribute12.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute12.Text;
            }
            if (cbxAttribute13.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute13.Text;
            }
            if (cbxAttribute14.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute14.Text;
            }
            if (cbxAttribute15.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute15.Text;
            }
            if (cbxAttribute16.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute16.Text;
            }
            if (cbxAttribute17.Checked == true)
            {
                surveyDetails[14] = surveyDetails[14] + "\n" + cbxAttribute17.Text;
            }

            if (cbxInterest1.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest1.Text;
            }
            if (cbxInterest2.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest2.Text;
            }
            if (cbxInterest3.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n " + cbxInterest3.Text;
            }
            if (cbxInterest4.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest4.Text;
            }
            if (cbxInterest5.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest5.Text;
            }
            if (cbxInterest6.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest6.Text;
            }
            if (cbxInterest7.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest7.Text;
            }
            if (cbxInterest8.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest8.Text;
            }
            if (cbxInterest9.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest9.Text;
            }
            if (cbxInterest10.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest10.Text;
            }
            if (cbxInterest11.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest11.Text;
            }
            if (cbxInterest12.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest12.Text;
            }
            if (cbxInterest13.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest13.Text;
            }
            if (cbxInterest14.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest14.Text;
            }
            if (cbxInterest15.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest15.Text;
            }
            if (cbxInterest16.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest16.Text;
            }
            if (cbxInterest17.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest17.Text;
            }
            if (cbxInterest18.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest18.Text;
            }
            if (cbxInterest19.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest19.Text;
            }
            if (cbxInterest20.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest20.Text;
            }
            if (cbxInterest21.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest21.Text;
            }
            if (cbxInterest22.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest22.Text;
            }
            if (cbxInterest23.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest23.Text;
            }
            if (cbxInterest24.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest24.Text;
            }
            if (cbxInterest25.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest25.Text;
            }
            if (cbxInterest26.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest26.Text;
            }
            if (cbxInterest27.Checked == true)
            {
                surveyDetails[15] = surveyDetails[15] + "\n" + cbxInterest27.Text;
            }

            personalInformation[6] = tbxEmail.Text;

            MessageBox.Show("Successfully Submitted!" + Environment.NewLine + Environment.NewLine + "Thank you for filling out this preference survey. Here are the summary of responses: "
                + Environment.NewLine + Environment.NewLine + "Personal Infomation" + Environment.NewLine + "Gender: " + personalInformation[0] + Environment.NewLine + "Age Range: "
                + personalInformation[1] + Environment.NewLine + "Marital Status: " + personalInformation[2] + Environment.NewLine + "Annual Income Range: " + personalInformation[3] + Environment.NewLine + "Employment Status: "
                + personalInformation[4] + Environment.NewLine + "Highest Educational Attainment: " + personalInformation[5] + Environment.NewLine + "Survey Details" + Environment.NewLine + "Frequency of Exercise: "
                + surveyDetails[0] + Environment.NewLine + "Frequency on the Usage of Sportswear Products: " + surveyDetails[1] + Environment.NewLine + "Recent bought a sportswear: " + surveyDetails[2] + Environment.NewLine
                + "Purpose in buying a sportswear: " + surveyDetails[3] + Environment.NewLine + "Go-to store in buying a sportswear: " + surveyDetails[4] + Environment.NewLine + "Preferred Design: " + surveyDetails[5]
                + Environment.NewLine + "Influence: " + surveyDetails[6] + Environment.NewLine + Environment.NewLine + "Preference Regarding the Materials" + Environment.NewLine + "Water Resistant: " + surveyDetails[7] + Environment.NewLine
                + "Anti Bacteria: " + surveyDetails[8] + Environment.NewLine + "Soft and Smooth Material: " + surveyDetails[9] + Environment.NewLine + "Endurance: " + surveyDetails[10] + Environment.NewLine + "Cooling: "
                + surveyDetails[11] + Environment.NewLine + "Anti Odour: " + surveyDetails[12] + Environment.NewLine + "Elasticity: " + surveyDetails[13] + Environment.NewLine + Environment.NewLine
                + "If the responder's favorite sports brand was a person, it would be: " + surveyDetails[14] + Environment.NewLine + Environment.NewLine + "The responder's areas of interests are: " + surveyDetails[15]
                + Environment.NewLine + Environment.NewLine + "Responder's Email Address: " + personalInformation[6]);

        }

        private void WaterStarRated5(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.image_removebg_preview__5_;
            pbStar2.Image = Resources.image_removebg_preview__5_;
            pbStar3.Image = Resources.image_removebg_preview__5_;
            pbStar4.Image = Resources.image_removebg_preview__5_;
            pbStar5.Image = Resources.image_removebg_preview__5_;
            surveyDetails[7] = "5";
        }

        private void WaterStarRated4(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.image_removebg_preview__5_;
            pbStar2.Image = Resources.image_removebg_preview__5_;
            pbStar3.Image = Resources.image_removebg_preview__5_;
            pbStar4.Image = Resources.image_removebg_preview__5_;
            pbStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[7] = "4";
        }

        private void WaterStarRated3(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.image_removebg_preview__5_;
            pbStar2.Image = Resources.image_removebg_preview__5_;
            pbStar3.Image = Resources.image_removebg_preview__5_;
            pbStar4.Image = Resources.image_removebg_preview__4_;
            pbStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[7] = "3";
        }

        private void WaterStarRated2(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.image_removebg_preview__5_;
            pbStar2.Image = Resources.image_removebg_preview__5_;
            pbStar3.Image = Resources.image_removebg_preview__4_;
            pbStar4.Image = Resources.image_removebg_preview__4_;
            pbStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[7] = "2";
        }

        private void WaterStarRated1(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.image_removebg_preview__5_;
            pbStar2.Image = Resources.image_removebg_preview__4_;
            pbStar3.Image = Resources.image_removebg_preview__4_;
            pbStar4.Image = Resources.image_removebg_preview__4_;
            pbStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[7] = "1";
        }

        private void ABStarRated5(object sender, EventArgs e)
        {
            ABStar1.Image = Resources.image_removebg_preview__5_;
            ABStar2.Image = Resources.image_removebg_preview__5_;
            ABStar3.Image = Resources.image_removebg_preview__5_;
            ABStar4.Image = Resources.image_removebg_preview__5_;
            ABStar5.Image = Resources.image_removebg_preview__5_;
            surveyDetails[8] = "5";
        }

        private void ABStarRated4(object sender, EventArgs e)
        {
            ABStar1.Image = Resources.image_removebg_preview__5_;
            ABStar2.Image = Resources.image_removebg_preview__5_;
            ABStar3.Image = Resources.image_removebg_preview__5_;
            ABStar4.Image = Resources.image_removebg_preview__5_;
            ABStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[8] = "4";
        }

        private void ABStarRated3(object sender, EventArgs e)
        {
            ABStar1.Image = Resources.image_removebg_preview__5_;
            ABStar2.Image = Resources.image_removebg_preview__5_;
            ABStar3.Image = Resources.image_removebg_preview__5_;
            ABStar4.Image = Resources.image_removebg_preview__4_;
            ABStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[8] = "3";
        }

        private void ABStarRated2(object sender, EventArgs e)
        {
            ABStar1.Image = Resources.image_removebg_preview__5_;
            ABStar2.Image = Resources.image_removebg_preview__5_;
            ABStar3.Image = Resources.image_removebg_preview__4_;
            ABStar4.Image = Resources.image_removebg_preview__4_;
            ABStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[8] = "2";
        }

        private void ABStarRated1(object sender, EventArgs e)
        {
            ABStar1.Image = Resources.image_removebg_preview__5_;
            ABStar2.Image = Resources.image_removebg_preview__4_;
            ABStar3.Image = Resources.image_removebg_preview__4_;
            ABStar4.Image = Resources.image_removebg_preview__4_;
            ABStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[8] = "1";
        }

        private void SMStarRated5(object sender, EventArgs e)
        {
            SMStar1.Image = Resources.image_removebg_preview__5_;
            SMStar2.Image = Resources.image_removebg_preview__5_;
            SMStar3.Image = Resources.image_removebg_preview__5_;
            SMStar4.Image = Resources.image_removebg_preview__5_;
            SMStar5.Image = Resources.image_removebg_preview__5_;
            surveyDetails[9] = "5";
        }

        private void SMStarRated4(object sender, EventArgs e)
        {
            SMStar1.Image = Resources.image_removebg_preview__5_;
            SMStar2.Image = Resources.image_removebg_preview__5_;
            SMStar3.Image = Resources.image_removebg_preview__5_;
            SMStar4.Image = Resources.image_removebg_preview__5_;
            SMStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[9] = "4";
        }

        private void SMStarRated3(object sender, EventArgs e)
        {
            SMStar1.Image = Resources.image_removebg_preview__5_;
            SMStar2.Image = Resources.image_removebg_preview__5_;
            SMStar3.Image = Resources.image_removebg_preview__5_;
            SMStar4.Image = Resources.image_removebg_preview__4_;
            SMStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[9] = "3";
        }

        private void SMStarRated2(object sender, EventArgs e)
        {
            SMStar1.Image = Resources.image_removebg_preview__5_;
            SMStar2.Image = Resources.image_removebg_preview__5_;
            SMStar3.Image = Resources.image_removebg_preview__4_;
            SMStar4.Image = Resources.image_removebg_preview__4_;
            SMStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[9] = "2";
        }

        private void SMStarRated1(object sender, EventArgs e)
        {
            SMStar1.Image = Resources.image_removebg_preview__5_;
            SMStar2.Image = Resources.image_removebg_preview__4_;
            SMStar3.Image = Resources.image_removebg_preview__4_;
            SMStar4.Image = Resources.image_removebg_preview__4_;
            SMStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[9] = "1";
        }

        private void ENStarRated5(object sender, EventArgs e)
        {
            ENStar1.Image = Resources.image_removebg_preview__5_;
            ENStar2.Image = Resources.image_removebg_preview__5_;
            ENStar3.Image = Resources.image_removebg_preview__5_;
            ENStar4.Image = Resources.image_removebg_preview__5_;
            ENStar5.Image = Resources.image_removebg_preview__5_;
            surveyDetails[10] = "5";
        }

        private void ENStarRated4(object sender, EventArgs e)
        {
            ENStar1.Image = Resources.image_removebg_preview__5_;
            ENStar2.Image = Resources.image_removebg_preview__5_;
            ENStar3.Image = Resources.image_removebg_preview__5_;
            ENStar4.Image = Resources.image_removebg_preview__5_;
            ENStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[10] = "4";
        }

        private void ENStarRated3(object sender, EventArgs e)
        {
            ENStar1.Image = Resources.image_removebg_preview__5_;
            ENStar2.Image = Resources.image_removebg_preview__5_;
            ENStar3.Image = Resources.image_removebg_preview__5_;
            ENStar4.Image = Resources.image_removebg_preview__4_;
            ENStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[10] = "3";
        }

        private void ENStarRated2(object sender, EventArgs e)
        {
            ENStar1.Image = Resources.image_removebg_preview__5_;
            ENStar2.Image = Resources.image_removebg_preview__5_;
            ENStar3.Image = Resources.image_removebg_preview__4_;
            ENStar4.Image = Resources.image_removebg_preview__4_;
            ENStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[10] = "2";
        }

        private void ENStarRated1(object sender, EventArgs e)
        {
            ENStar1.Image = Resources.image_removebg_preview__5_;
            ENStar2.Image = Resources.image_removebg_preview__4_;
            ENStar3.Image = Resources.image_removebg_preview__4_;
            ENStar4.Image = Resources.image_removebg_preview__4_;
            ENStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[10] = "1";
        }

        private void CStarRated5(object sender, EventArgs e)
        {
            CStar1.Image = Resources.image_removebg_preview__5_;
            CStar2.Image = Resources.image_removebg_preview__5_;
            CStar3.Image = Resources.image_removebg_preview__5_;
            CStar4.Image = Resources.image_removebg_preview__5_;
            CStar5.Image = Resources.image_removebg_preview__5_;
            surveyDetails[11] = "5";
        }

        private void CStarRated4(object sender, EventArgs e)
        {
            CStar1.Image = Resources.image_removebg_preview__5_;
            CStar2.Image = Resources.image_removebg_preview__5_;
            CStar3.Image = Resources.image_removebg_preview__5_;
            CStar4.Image = Resources.image_removebg_preview__5_;
            CStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[11] = "4";
        }

        private void CStarRated3(object sender, EventArgs e)
        {
            CStar1.Image = Resources.image_removebg_preview__5_;
            CStar2.Image = Resources.image_removebg_preview__5_;
            CStar3.Image = Resources.image_removebg_preview__5_;
            CStar4.Image = Resources.image_removebg_preview__4_;
            CStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[11] = "3";
        }

        private void CStarRated2(object sender, EventArgs e)
        {
            CStar1.Image = Resources.image_removebg_preview__5_;
            CStar2.Image = Resources.image_removebg_preview__5_;
            CStar3.Image = Resources.image_removebg_preview__4_;
            CStar4.Image = Resources.image_removebg_preview__4_;
            CStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[11] = "2";
        }

        private void CStarRated1(object sender, EventArgs e)
        {
            CStar1.Image = Resources.image_removebg_preview__5_;
            CStar2.Image = Resources.image_removebg_preview__4_;
            CStar3.Image = Resources.image_removebg_preview__4_;
            CStar4.Image = Resources.image_removebg_preview__4_;
            CStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[11] = "1";
        }

        private void AOStarRated5(object sender, EventArgs e)
        {
            AOStar1.Image = Resources.image_removebg_preview__5_;
            AOStar2.Image = Resources.image_removebg_preview__5_;
            AOStar3.Image = Resources.image_removebg_preview__5_;
            AOStar4.Image = Resources.image_removebg_preview__5_;
            AOStar5.Image = Resources.image_removebg_preview__5_;
            surveyDetails[12] = "5";
        }

        private void AOStarRated4(object sender, EventArgs e)
        {
            AOStar1.Image = Resources.image_removebg_preview__5_;
            AOStar2.Image = Resources.image_removebg_preview__5_;
            AOStar3.Image = Resources.image_removebg_preview__5_;
            AOStar4.Image = Resources.image_removebg_preview__5_;
            AOStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[12] = "4";
        }

        private void AOStarRated3(object sender, EventArgs e)
        {
            AOStar1.Image = Resources.image_removebg_preview__5_;
            AOStar2.Image = Resources.image_removebg_preview__5_;
            AOStar3.Image = Resources.image_removebg_preview__5_;
            AOStar4.Image = Resources.image_removebg_preview__4_;
            AOStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[12] = "3";
        }

        private void AOStarRated2(object sender, EventArgs e)
        {
            AOStar1.Image = Resources.image_removebg_preview__5_;
            AOStar2.Image = Resources.image_removebg_preview__5_;
            AOStar3.Image = Resources.image_removebg_preview__4_;
            AOStar4.Image = Resources.image_removebg_preview__4_;
            AOStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[12] = "2";
        }

        private void AOStarRated1(object sender, EventArgs e)
        {
            AOStar1.Image = Resources.image_removebg_preview__5_;
            AOStar2.Image = Resources.image_removebg_preview__4_;
            AOStar3.Image = Resources.image_removebg_preview__4_;
            AOStar4.Image = Resources.image_removebg_preview__4_;
            AOStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[12] = "1";
        }

        private void EStarRated5(object sender, EventArgs e)
        {
            EStar1.Image = Resources.image_removebg_preview__5_;
            EStar2.Image = Resources.image_removebg_preview__5_;
            EStar3.Image = Resources.image_removebg_preview__5_;
            EStar4.Image = Resources.image_removebg_preview__5_;
            EStar5.Image = Resources.image_removebg_preview__5_;
            surveyDetails[13] = "5";
        }

        private void EStarRated4(object sender, EventArgs e)
        {
            EStar1.Image = Resources.image_removebg_preview__5_;
            EStar2.Image = Resources.image_removebg_preview__5_;
            EStar3.Image = Resources.image_removebg_preview__5_;
            EStar4.Image = Resources.image_removebg_preview__5_;
            EStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[13] = "4";
        }

        private void EStarRated3(object sender, EventArgs e)
        {
            EStar1.Image = Resources.image_removebg_preview__5_;
            EStar2.Image = Resources.image_removebg_preview__5_;
            EStar3.Image = Resources.image_removebg_preview__5_;
            EStar4.Image = Resources.image_removebg_preview__4_;
            EStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[13] = "3";
        }

        private void EStarRated2(object sender, EventArgs e)
        {
            EStar1.Image = Resources.image_removebg_preview__5_;
            EStar2.Image = Resources.image_removebg_preview__5_;
            EStar3.Image = Resources.image_removebg_preview__4_;
            EStar4.Image = Resources.image_removebg_preview__4_;
            EStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[13] = "2";
        }

        private void EStarRated1(object sender, EventArgs e)
        {
            EStar1.Image = Resources.image_removebg_preview__5_;
            EStar2.Image = Resources.image_removebg_preview__4_;
            EStar3.Image = Resources.image_removebg_preview__4_;
            EStar4.Image = Resources.image_removebg_preview__4_;
            EStar5.Image = Resources.image_removebg_preview__4_;
            surveyDetails[13] = "1";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}