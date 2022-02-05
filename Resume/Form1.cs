using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume
{
    public partial class Form1 : Form
    {
        // Form Layout front end
        public TextBox[] allTxtBox;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            allTxtBox = new[] { fName, lName, address, cpNumber, llNumber, emailAddress,
            jobTitle1, companyName1, yearsWorked1, jobTitle2, companyName2, yearsWorked2,
            jobTitle3, companyName3, yearsWorked3, summary};
        }

        private void cpNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '(' && e.KeyChar != ')'
                && e.KeyChar != '-' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void llNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '(' && e.KeyChar != ')'
                && e.KeyChar != '-' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void yGHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void yearClgGraduated_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void yearsWorked1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void yearsWorked2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void yearsWorked3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private bool RequiredNeed()
        {
            // will check if the needed information is blank.
            if(summary.Text.Trim() == "" || fName.Text.Trim() == "" || lName.Text.Trim() == "" || address.Text.Trim() == ""
                || emailAddress.Text.Trim() == "" || (cpNumber.Text.Trim() == "" && llNumber.Text.Trim() == "")
                || (jobTitle1.Text.Trim() == "" && (companyName1.Text.Trim().Length > 0 || yearsWorked1.Text.Trim().Length > 0))
                || (jobTitle2.Text.Trim() == "" && (companyName2.Text.Trim().Length > 0 || yearsWorked2.Text.Trim().Length > 0))
                || (jobTitle3.Text.Trim() == "" && (companyName3.Text.Trim().Length > 0 || yearsWorked3.Text.Trim().Length > 0))
                || (companyName1.Text.Trim() == "" && (jobTitle1.Text.Trim().Length > 0 || yearsWorked1.Text.Trim().Length > 0))
                || (companyName2.Text.Trim() == "" && (jobTitle2.Text.Trim().Length > 0 || yearsWorked2.Text.Trim().Length > 0))
                || (companyName3.Text.Trim() == "" && (jobTitle3.Text.Trim().Length > 0 || yearsWorked3.Text.Trim().Length > 0))
                || (yearsWorked1.Text.Trim() == "" && (jobTitle1.Text.Trim().Length > 0 || companyName1.Text.Trim().Length > 0))
                || (yearsWorked2.Text.Trim() == "" && (jobTitle2.Text.Trim().Length > 0 || companyName2.Text.Trim().Length > 0))
                || (yearsWorked3.Text.Trim() == "" && (jobTitle3.Text.Trim().Length > 0 || companyName3.Text.Trim().Length > 0)))
            {
                return true;
            }
            return false;
        }

        private void RequiredCouple(int i)
        {
            if (allTxtBox[i].Text.Trim() == "" && (allTxtBox[i + 1].Text.Trim().Length > 0 || allTxtBox[i + 2].Text.Trim().Length > 0)
                        || allTxtBox[i + 1].Text.Trim() == "" && (allTxtBox[i].Text.Trim().Length > 0 || allTxtBox[i + 2].Text.Trim().Length > 0)
                        || allTxtBox[i + 2].Text.Trim() == "" && (allTxtBox[i].Text.Trim().Length > 0 || allTxtBox[i + 1].Text.Trim().Length > 0))
            {
                allTxtBox[i].BackColor = Color.Red;
                allTxtBox[i + 1].BackColor = Color.Red;
                allTxtBox[i + 2].BackColor = Color.Red;
            }
        }

        private void RedRequired()
        {
            for(int i = 0; i < allTxtBox.Length; i++)
            {
                if(i == 3)
                {
                    if (allTxtBox[i].Text.Trim() == "" && allTxtBox[i+1].Text.Trim() == "")
                    {
                        allTxtBox[i].BackColor = Color.Red;
                        allTxtBox[i + 1].BackColor = Color.Red;
                    }
                }
                else if(i == 4)
                {
                    continue;
                }
                else if(i == 6)
                {
                    if(allTxtBox[i].Text.Trim() == "" && (allTxtBox[i+1].Text.Trim().Length > 0 || allTxtBox[i+2].Text.Trim().Length > 0)
                        || allTxtBox[i + 1].Text.Trim() == "" && (allTxtBox[i].Text.Trim().Length > 0 || allTxtBox[i + 2].Text.Trim().Length > 0)
                        || allTxtBox[i + 2].Text.Trim() == "" && (allTxtBox[i].Text.Trim().Length > 0 || allTxtBox[i + 1].Text.Trim().Length > 0))
                    {
                        allTxtBox[i].BackColor = Color.Red;
                        allTxtBox[i + 1].BackColor = Color.Red;
                        allTxtBox[i + 2].BackColor = Color.Red;
                    }
                }
                else if(i == 7)
                {
                    continue;
                }
                else if (i == 8)
                {
                    continue;
                }
                else if(i == 9)
                {
                    RequiredCouple(i);
                }
                else if(i == 10)
                {
                    continue;
                }
                else if(i == 11)
                {
                    continue;
                }
                else if(i == 12)
                {
                    RequiredCouple(i);
                }
                else if(i == 13 || i == 14)
                {
                    continue;
                }
                else
                {
                    if(allTxtBox[i].Text.Trim() == "")
                    {
                        allTxtBox[i].BackColor = Color.Red;
                    }
                }
            }
        }

        private void loadJsonButton_Click(object sender, EventArgs e)
        {
            if(RequiredNeed())
            {
                RedRequired();
            }
        }

        private void fName_Click(object sender, EventArgs e)
        {
            fName.BackColor = Color.White;
        }

        private void lName_Click(object sender, EventArgs e)
        {
            lName.BackColor = Color.White;
        }

        private void address_Click(object sender, EventArgs e)
        {
            address.BackColor = Color.White;
        }

        private void cpNumber_Click(object sender, EventArgs e)
        {
            cpNumber.BackColor = Color.White;
            llNumber.BackColor = Color.White;
        }

        private void llNumber_Click(object sender, EventArgs e)
        {
            llNumber.BackColor = Color.White;
            cpNumber.BackColor = Color.White;
        }

        private void emailAddress_Click(object sender, EventArgs e)
        {
            emailAddress.BackColor = Color.White;
        }

        private void jobTitle1_Click(object sender, EventArgs e)
        {
            jobTitle1.BackColor = Color.White;
            companyName1.BackColor = Color.White;
            yearsWorked1.BackColor = Color.White;
        }

        private void companyName1_Click(object sender, EventArgs e)
        {
            jobTitle1.BackColor = Color.White;
            companyName1.BackColor = Color.White;
            yearsWorked1.BackColor = Color.White;
        }

        private void yearsWorked1_Click(object sender, EventArgs e)
        {
            jobTitle1.BackColor = Color.White;
            companyName1.BackColor = Color.White;
            yearsWorked1.BackColor = Color.White;
        }

        private void jobTitle2_Click(object sender, EventArgs e)
        {
            jobTitle2.BackColor = Color.White;
            companyName2.BackColor = Color.White;
            yearsWorked2.BackColor = Color.White;
        }

        private void companyName2_Click(object sender, EventArgs e)
        {
            jobTitle2.BackColor = Color.White;
            companyName2.BackColor = Color.White;
            yearsWorked2.BackColor = Color.White;
        }

        private void yearsWorked2_Click(object sender, EventArgs e)
        {
            jobTitle2.BackColor = Color.White;
            companyName2.BackColor = Color.White;
            yearsWorked2.BackColor = Color.White;
        }

        private void jobTitle3_Click(object sender, EventArgs e)
        {
            jobTitle3.BackColor = Color.White;
            companyName3.BackColor = Color.White;
            yearsWorked3.BackColor = Color.White;
        }

        private void companyName3_Click(object sender, EventArgs e)
        {
            jobTitle3.BackColor = Color.White;
            companyName3.BackColor = Color.White;
            yearsWorked3.BackColor = Color.White;
        }

        private void yearsWorked3_Click(object sender, EventArgs e)
        {
            jobTitle3.BackColor = Color.White;
            companyName3.BackColor = Color.White;
            yearsWorked3.BackColor = Color.White;
        }

        private void summary_Click(object sender, EventArgs e)
        {
            summary.BackColor = Color.White;
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            if (RequiredNeed())
            {
                RedRequired();
            }
        }


        // Developing backend not started
    }
}
