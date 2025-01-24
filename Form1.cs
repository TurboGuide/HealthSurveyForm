using Health_Survey_Form.Properties;
using Microsoft.VisualBasic.Devices;
using System.Net;
using System.Xml.Linq;

namespace Health_Survey_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.DrawItem += (s, e) => { };
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //Submit Button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TextBox
            string Fname, Mname, Lname, Email, PNum,
                    Province, CityMun, Postal, Street, BirthDate,
                    Age, Gender, Date, HaveAllergies, Height1,
                    Weight1, CurrBMI, TargBMI, Question6, Question7,
                    Question8, Question10, Question11, Question12, Question13,
                    Question14, Question15, Question16, Question17, Question18,
                    Question19, Question20, Question21, Question22, Question23,
                    Question24, Question25, Question27, CurrWeight, GoalWeight,
                    Height2, Question28;
            //CheckBox
            string PrefCont = "", Question1 = "", Question2 = "";
            //Radio Button
            string Question3, Question4, Question5, Question9, Question26,
                    Question29, Question30, Question31, Question32;

            //Page 1
            Fname = tbxFName.Text;
            Mname = tbxMName.Text;
            Lname = tbxLName.Text;
            Email = tbxEmail.Text;
            PNum = tbxPhoneNum.Text;
            Province = tbxProvince.Text;
            CityMun = tbxCityMun.Text;
            Postal = tbxPostal.Text;
            Street = tbxStreet.Text;
            BirthDate = dtpBrthDt.Text;
            Age = tbxAge.Text;
            Gender = cbxGender.GetItemText(cbxGender.SelectedItem);
            Date = dtpDate.Text;
            HaveAllergies = tbxQ5Yes.Text;
            Height1 = tbxHeight1.Text;
            Weight1 = tbxWeight1.Text;
            CurrBMI = tbxCurrBMI.Text;
            TargBMI = tbxTargetBMI.Text;
            Question6 = tbxQ6Answer.Text;
            Question7 = tbxQ7Answer.Text;
            Question8 = tbxQ8Answer.Text;
            Question10 = tbxQ10Answer.Text;
            Question11 = tbxQ11Answer.Text;
            Question12 = tbxQ12Answer.Text;
            Question13 = tbxQ13Answer.Text;
            Question14 = tbxQ14Answer.Text;
            Question15 = tbxQ15Answer.Text;
            Question16 = tbxQ16Answer.Text;
            Question17 = tbxQ17Answer.Text;
            Question18 = tbxQ18Answer.Text;
            Question19 = tbxQ19Answer.Text;
            Question20 = tbxQ20Answer.Text;
            Question21 = tbxQ21Answer.Text;
            Question22 = tbxQ22Answer.Text;
            Question23 = tbxQ23Answer.Text;
            Question24 = tbxQ24Answer.Text;
            Question25 = tbxQ25Answer.Text;
            Question27 = tbxQ27Answer.Text;
            CurrWeight = tbxCurrWeight.Text;
            GoalWeight = tbxGoalWeight.Text;
            Height2 = tbxHeight2.Text;
            Question29 = tbxQ29Answer.Text;

            if (cbxEmail.Checked == true)
            {
                PrefCont = PrefCont + " " + cbxEmail.Text;
            }
            if (cbxPhoneCall.Checked == true)
            {
                PrefCont = PrefCont + " " + cbxPhoneCall.Text;
            }
            if (cbxPhoneMsg.Checked == true)
            {
                PrefCont = PrefCont + " " + cbxPhoneMsg.Text;
            }

            //Page 2
            //Question 1
            if (cbxQ1Choice1.Checked == true)
            {
                Question1 = Question1 + " " + cbxQ1Choice1.Text;
            }
            if (cbxQ1Choice2.Checked == true)
            {
                Question1 = Question1 + " " + cbxQ1Choice2.Text;
            }
            if (cbxQ1Choice3.Checked == true)
            {
                Question1 = Question1 + " " + cbxQ1Choice3.Text;
            }
            if (cbxQ1Choice4.Checked == true)
            {
                Question1 = Question1 + " " + cbxQ1Choice4.Text;
            }

            //Question 2
            if (cbxQ2Choice1.Checked == true)
            {
                Question2 = Question2 + " " + cbxQ2Choice1.Text;
            }
            if (cbxQ2Choice2.Checked == true)
            {
                Question2 = Question2 + " " + cbxQ2Choice2.Text;
            }
            if (cbxQ2Choice3.Checked == true)
            {
                Question2 = Question2 + " " + cbxQ2Choice3.Text;
            }
            if (cbxQ2Choice4.Checked == true)
            {
                Question2 = Question2 + " " + cbxQ2Choice4.Text;
            }
            if (cbxQ2Choice5.Checked == true)
            {
                Question2 = Question2 + " " + cbxQ2Choice5.Text;
            }
            if (cbxQ2Choice6.Checked == true)
            {
                Question2 = Question2 + " " + cbxQ2Choice6.Text;
            }

            //Question 3
            if (rbtnQ3Choice1.Checked)
            {
                Question3 = rbtnQ3Choice1.Text;
            }
            else
            {
                Question3 = rbtnQ3Choice2.Text;
            }

            //Question 4
            if (rbtnQ4Choice1.Checked)
            {
                Question4 = rbtnQ4Choice1.Text;
            }
            else
            {
                Question4 = rbtnQ4Choice2.Text;
            }

            //Question 5
            if (rbtnQ5Choice1.Checked)
            {
                Question5 = rbtnQ5Choice1.Text;
            }
            else
            {
                Question5 = rbtnQ5Choice2.Text;
            }

            //Question 9
            if (rbtnQ9Choice1.Checked)
            {
                Question9 = rbtnQ9Choice1.Text;
            }
            else
            {
                Question9 = rbtnQ9Choice2.Text;
            }

            //Question 26
            if (rbtnQ26Choice1.Checked)
            {
                Question26 = rbtnQ26Choice1.Text;
            }
            else if (rbtnQ26Choice2.Checked)
            {
                Question26 = rbtnQ26Choice2.Text;
            }
            else if (rbtnQ26Choice3.Checked)
            {
                Question26 = rbtnQ26Choice3.Text;
            }
            else if (rbtnQ26Choice4.Checked)
            {
                Question26 = rbtnQ26Choice4.Text;
            }
            else
            {
                Question26 = rbtnQ26Choice5.Text;
            }

            //Question 28
            if (rbtnQ28Choice1.Checked)
            {
                Question28 = rbtnQ28Choice1.Text;
            }
            else
            {
                Question28 = rbtnQ28Choice2.Text;
            }

            //Question 30
            if (rbtnQ30Choice1.Checked)
            {
                Question30 = rbtnQ30Choice1.Text;
            }
            else if (rbtnQ30Choice2.Checked)
            {
                Question30 = rbtnQ30Choice2.Text;
            }
            else if (rbtnQ30Choice3.Checked)
            {
                Question30 = rbtnQ30Choice3.Text;
            }
            else
            {
                Question30 = rbtnQ30Choice4.Text;
            }

            //Question 31
            if (rbtnQ31Choice1.Checked)
            {
                Question31 = rbtnQ31Choice1.Text;
            }
            else if (rbtnQ31Choice2.Checked)
            {
                Question31 = rbtnQ31Choice2.Text;
            }
            else if (rbtnQ31Choice3.Checked)
            {
                Question31 = rbtnQ31Choice3.Text;
            }
            else
            {
                Question31 = rbtnQ31Choice4.Text;
            }

            //Question 32
            if (rbtnQ32Choice1.Checked)
            {
                Question32 = rbtnQ32Choice1.Text;
            }
            else if (rbtnQ32Choice2.Checked)
            {
                Question32 = rbtnQ32Choice2.Text;
            }
            else if (rbtnQ32Choice3.Checked)
            {
                Question32 = rbtnQ32Choice3.Text;
            }
            else if (rbtnQ32Choice4.Checked)
            {
                Question32 = rbtnQ32Choice4.Text;
            }
            else
            {
                Question32 = rbtnQ32Choice5.Text;
            }

            //Message
            string message = "Successfully submitted!" + Environment.NewLine +
                Environment.NewLine + "Date Submitted: " + Date +
                Environment.NewLine + "\nPersonal Information:" +
                Environment.NewLine + "Name: " + Fname + " " + Mname + " " + Lname +
                Environment.NewLine + "Email: " + Email +
                Environment.NewLine + "Phone Number: " + PNum +
                Environment.NewLine + "Address: " + Street + ", " + CityMun + ", " + Province + ", " + Postal +
                Environment.NewLine + "Birthday: " + BirthDate +
                Environment.NewLine + "Gender: " + Gender +
                Environment.NewLine + "Preferred Contacts: " + PrefCont +
                Environment.NewLine + "\nMedical Information:" +
                Environment.NewLine + "Health Issue: " + Question1 +
                Environment.NewLine + "Taking Medications: " + Question2 +
                Environment.NewLine + "Pregnant: " + Question3 +
                Environment.NewLine + "Nursing: " + Question4 +
                Environment.NewLine + "Food Allergies: " + Question5 +
                Environment.NewLine + "Allergies: " + HaveAllergies +
                Environment.NewLine + "\nBody Mass Index:" +
                Environment.NewLine + "Height:" + Height1 +
                Environment.NewLine + "Weight:" + Weight1 +
                Environment.NewLine + "Current BMI:" + CurrBMI +
                Environment.NewLine + "Target BMI:" + TargBMI +
                Environment.NewLine + "\nSleep Information:" +
                Environment.NewLine + "Bed Time:" + Question6 +
                Environment.NewLine + "Wake Time:" + Question7 +
                Environment.NewLine + "Hours of Sleep:" + Question8 +
                Environment.NewLine + "Wake-up Rested:" + Question9 +
                Environment.NewLine + "Sleep Quality:" + Question10 +
                Environment.NewLine + "\nHydration Information:" +
                Environment.NewLine + "Water Intake:" + Question11 +
                Environment.NewLine + "Coffee Intake:" + Question12 +
                Environment.NewLine + "Alcohol Intake:" + Question13 +
                Environment.NewLine + "\nMovement Information:" +
                Environment.NewLine + "Exercise/week:" + Question11 +
                Environment.NewLine + "Kind of Exercise:" + Question12 +
                Environment.NewLine + "Currently Unable To Do:" + Question13 +
                Environment.NewLine + "Daily Energy Level Rating:" + Question17 +
                Environment.NewLine + "\nStress Information:" +
                Environment.NewLine + "Work:" + Question18 +
                Environment.NewLine + "Enjoying:" + Question19 +
                Environment.NewLine + "Stress in Life:" + Question20 +
                Environment.NewLine + "Overall Stress Level Rating:" + Question21 +
                Environment.NewLine + "\nEating Habits:" +
                Environment.NewLine + "First Meal:" + Question22 +
                Environment.NewLine + "Last Meal:" + Question23 +
                Environment.NewLine + "Meals/day:" + Question24 +
                Environment.NewLine + "Snacks:" + Question25 +
                Environment.NewLine + "Eat Out in a Week:" + Question26 +
                Environment.NewLine + "Location:" + Question27 +
                Environment.NewLine + "\nWeight Information:" +
                Environment.NewLine + "Current Weight:" + CurrWeight +
                Environment.NewLine + "Goal Weight:" + GoalWeight +
                Environment.NewLine + "Height:" + Height2 +
                Environment.NewLine + "Loosing Weight:" + Question28 +
                Environment.NewLine + "Difficulty Loosing Weight:" + Question29 +
                Environment.NewLine + "Smoke:" + Question30 +
                Environment.NewLine + "Exercising:" + Question31 +
                Environment.NewLine + "Sleeping Hours:" + Question32;

            CustomMessageBox customMessageBox = new CustomMessageBox(message, "Submission Successful");
            customMessageBox.ShowDialog();
        }

        //Next Page Buttons
        private void btnNxtPg2nd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void btnNxtPg3rd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void btnNxtPg4th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }
        private void btnNxtPg5th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }
        private void btnNxtPg6th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }
        private void btnNxtPg7th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
        }
        private void btnNxtPg8th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;
        }
        private void btnNxtPg9th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 8;
        }

        //Previous Page Buttons
        private void btnPrvPg8th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;
        }
        private void btnPrvPg7th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
        }
        private void btnPrvPg6th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }
        private void btnPrvPg5th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }
        private void btnPrvPg4th_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }
        private void btnPrvPg3rd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void btnPrvPg2nd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void btnPrvPg1st_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        //Question 17 Rating
        private void pbxQ17Rate1_Click(object sender, EventArgs e)
        {
            pbxQ17Rate1.Image = Resources.number_1;
            pbxQ17Rate2.Image = Resources.two__1_;
            pbxQ17Rate3.Image = Resources.three;
            pbxQ17Rate4.Image = Resources.four;
            pbxQ17Rate5.Image = Resources.five;
            pbxQ17Rate6.Image = Resources.six;
            pbxQ17Rate7.Image = Resources.seven;
            pbxQ17Rate8.Image = Resources.eight;
            pbxQ17Rate9.Image = Resources.nine;
            pbxQ17Rate10.Image = Resources.ten;
            tbxQ17Answer.Text = "1";
        }
        private void pbxQ17Rate2_Click(object sender, EventArgs e)
        {
            pbxQ17Rate1.Image = Resources.one;
            pbxQ17Rate2.Image = Resources.number_2;
            pbxQ17Rate3.Image = Resources.three;
            pbxQ17Rate4.Image = Resources.four;
            pbxQ17Rate5.Image = Resources.five;
            pbxQ17Rate6.Image = Resources.six;
            pbxQ17Rate7.Image = Resources.seven;
            pbxQ17Rate8.Image = Resources.eight;
            pbxQ17Rate9.Image = Resources.nine;
            pbxQ17Rate10.Image = Resources.ten;
            tbxQ17Answer.Text = "2";
        }
        private void pbxQ17Rate3_Click(object sender, EventArgs e)
        {
            pbxQ17Rate1.Image = Resources.one;
            pbxQ17Rate2.Image = Resources.two__1_;
            pbxQ17Rate3.Image = Resources.number_3;
            pbxQ17Rate4.Image = Resources.four;
            pbxQ17Rate5.Image = Resources.five;
            pbxQ17Rate6.Image = Resources.six;
            pbxQ17Rate7.Image = Resources.seven;
            pbxQ17Rate8.Image = Resources.eight;
            pbxQ17Rate9.Image = Resources.nine;
            pbxQ17Rate10.Image = Resources.ten;
            tbxQ17Answer.Text = "3";
        }
        private void pbxQ17Rate4_Click(object sender, EventArgs e)
        {
            pbxQ17Rate4.Image = Resources.number_4;
            pbxQ17Rate1.Image = Resources.one;
            pbxQ17Rate2.Image = Resources.two__1_;
            pbxQ17Rate3.Image = Resources.three;
            pbxQ17Rate5.Image = Resources.five;
            pbxQ17Rate6.Image = Resources.six;
            pbxQ17Rate7.Image = Resources.seven;
            pbxQ17Rate8.Image = Resources.eight;
            pbxQ17Rate9.Image = Resources.nine;
            pbxQ17Rate10.Image = Resources.ten;
            tbxQ17Answer.Text = "4";
        }
        private void pbxQ17Rate5_Click(object sender, EventArgs e)
        {
            pbxQ17Rate5.Image = Resources.number_5;
            pbxQ17Rate1.Image = Resources.one;
            pbxQ17Rate2.Image = Resources.two__1_;
            pbxQ17Rate3.Image = Resources.three;
            pbxQ17Rate4.Image = Resources.four;
            pbxQ17Rate6.Image = Resources.six;
            pbxQ17Rate7.Image = Resources.seven;
            pbxQ17Rate8.Image = Resources.eight;
            pbxQ17Rate9.Image = Resources.nine;
            pbxQ17Rate10.Image = Resources.ten;
            tbxQ17Answer.Text = "5";
        }
        private void pbxQ17Rate6_Click(object sender, EventArgs e)
        {
            pbxQ17Rate6.Image = Resources.number_6;
            pbxQ17Rate1.Image = Resources.one;
            pbxQ17Rate2.Image = Resources.two__1_;
            pbxQ17Rate3.Image = Resources.three;
            pbxQ17Rate4.Image = Resources.four;
            pbxQ17Rate5.Image = Resources.five;
            pbxQ17Rate7.Image = Resources.seven;
            pbxQ17Rate8.Image = Resources.eight;
            pbxQ17Rate9.Image = Resources.nine;
            pbxQ17Rate10.Image = Resources.ten;
            tbxQ17Answer.Text = "6";
        }
        private void pbxQ17Rate7_Click(object sender, EventArgs e)
        {
            pbxQ17Rate7.Image = Resources.number_7;
            pbxQ17Rate1.Image = Resources.one;
            pbxQ17Rate2.Image = Resources.two__1_;
            pbxQ17Rate3.Image = Resources.three;
            pbxQ17Rate4.Image = Resources.four;
            pbxQ17Rate5.Image = Resources.five;
            pbxQ17Rate6.Image = Resources.six;
            pbxQ17Rate8.Image = Resources.eight;
            pbxQ17Rate9.Image = Resources.nine;
            pbxQ17Rate10.Image = Resources.ten;
            tbxQ17Answer.Text = "7";
        }
        private void pbxQ17Rate8_Click(object sender, EventArgs e)
        {
            pbxQ17Rate8.Image = Resources.number_8;
            pbxQ17Rate1.Image = Resources.one;
            pbxQ17Rate2.Image = Resources.two__1_;
            pbxQ17Rate3.Image = Resources.three;
            pbxQ17Rate4.Image = Resources.four;
            pbxQ17Rate5.Image = Resources.five;
            pbxQ17Rate6.Image = Resources.six;
            pbxQ17Rate7.Image = Resources.seven;
            pbxQ17Rate9.Image = Resources.nine;
            pbxQ17Rate10.Image = Resources.ten;
            tbxQ17Answer.Text = "8";
        }
        private void pbxQ17Rate9_Click(object sender, EventArgs e)
        {
            pbxQ17Rate9.Image = Resources.number_9;
            pbxQ17Rate1.Image = Resources.one;
            pbxQ17Rate2.Image = Resources.two__1_;
            pbxQ17Rate3.Image = Resources.three;
            pbxQ17Rate4.Image = Resources.four;
            pbxQ17Rate5.Image = Resources.five;
            pbxQ17Rate6.Image = Resources.six;
            pbxQ17Rate7.Image = Resources.seven;
            pbxQ17Rate8.Image = Resources.eight;
            pbxQ17Rate10.Image = Resources.ten;
            tbxQ17Answer.Text = "9";
        }
        private void pbxQ17Rate10_Click(object sender, EventArgs e)
        {
            pbxQ17Rate10.Image = Resources.number_10;
            pbxQ17Rate1.Image = Resources.one;
            pbxQ17Rate2.Image = Resources.two__1_;
            pbxQ17Rate3.Image = Resources.three;
            pbxQ17Rate4.Image = Resources.four;
            pbxQ17Rate5.Image = Resources.five;
            pbxQ17Rate6.Image = Resources.six;
            pbxQ17Rate7.Image = Resources.seven;
            pbxQ17Rate8.Image = Resources.eight;
            pbxQ17Rate9.Image = Resources.nine;
            tbxQ17Answer.Text = "10";
        }

        //Question 21 Rating
        private void pbxQ21Rate1_Click_1(object sender, EventArgs e)
        {
            pbxQ21Rate1.Image = Resources.number_1;
            pbxQ21Rate2.Image = Resources.two__1_;
            pbxQ21Rate3.Image = Resources.three;
            pbxQ21Rate4.Image = Resources.four;
            pbxQ21Rate5.Image = Resources.five;
            tbxQ21Answer.Text = "1";
        }
        private void pbxQ21Rate2_Click(object sender, EventArgs e)
        {
            pbxQ21Rate1.Image = Resources.one;
            pbxQ21Rate2.Image = Resources.number_2;
            pbxQ21Rate3.Image = Resources.three;
            pbxQ21Rate4.Image = Resources.four;
            pbxQ21Rate5.Image = Resources.five;
            tbxQ21Answer.Text = "2";
        }
        private void pbxQ21Rate3_Click(object sender, EventArgs e)
        {
            pbxQ21Rate1.Image = Resources.one;
            pbxQ21Rate2.Image = Resources.two__1_;
            pbxQ21Rate3.Image = Resources.number_3;
            pbxQ21Rate4.Image = Resources.four;
            pbxQ21Rate5.Image = Resources.five;
            tbxQ21Answer.Text = "3";
        }
        private void pbxQ21Rate4_Click(object sender, EventArgs e)
        {
            pbxQ21Rate4.Image = Resources.number_4;
            pbxQ21Rate1.Image = Resources.one;
            pbxQ21Rate2.Image = Resources.two__1_;
            pbxQ21Rate3.Image = Resources.three;
            pbxQ21Rate5.Image = Resources.five;
            tbxQ21Answer.Text = "4";
        }
        private void pbxQ21Rate5_Click(object sender, EventArgs e)
        {
            pbxQ21Rate5.Image = Resources.number_5;
            pbxQ21Rate1.Image = Resources.one;
            pbxQ21Rate2.Image = Resources.two__1_;
            pbxQ21Rate3.Image = Resources.three;
            pbxQ21Rate4.Image = Resources.four;
            tbxQ21Answer.Text = "5";
        }


        private void panelQ17_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
