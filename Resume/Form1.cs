using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resume.Models;
using Newtonsoft.Json;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Resume
{
    public partial class Form1 : Form
    {
        // Form Layout front end
        public string jsonPath;
        public string jsonFromFile;
        public TextBox[] allTxtBox;
        public string tFName;
        public string tLName;
        public string tFullName;
        public string tAddress;
        public string tCpNumber;
        public string tLlNumber;
        public string tEmailAddress;
        public string tSummary;
        public List<string> tHighSchool = new List<string>();
        public List<string> tCollege = new List<string>();
        public List<string> tSkills = new List<string>();
        public List<string> tJobTitle = new List<string>();
        public List<string> tCompanyName = new List<string>();
        public List<string> tDuration = new List<string>();
        PersonalDetails.Personal personal;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            allTxtBox = new[] { fName, lName, address, cpNumber, llNumber, emailAddress, summary};
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

        private static string Ordinal(int num)
        {
            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }
            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }
        }

        private bool RequiredNeed()
        {
            // will check if the needed information is blank.
            if(summary.Text.Trim() == "" || fName.Text.Trim() == "" || lName.Text.Trim() == "" || address.Text.Trim() == ""
                || emailAddress.Text.Trim() == "" || (cpNumber.Text.Trim() == "" && llNumber.Text.Trim() == ""))
            {
                return true;
            }
            for(int i = 0; i < workExperience.RowCount; i++)
            {
                if ((workExperience.Rows[i].Cells[0].Value != null && (workExperience.Rows[i].Cells[1].Value == null ||
                    workExperience.Rows[i].Cells[2].Value == null)) || (workExperience.Rows[i].Cells[1].Value != null &&
                    (workExperience.Rows[i].Cells[0].Value == null || workExperience.Rows[i].Cells[2].Value == null)) ||
                    (workExperience.Rows[i].Cells[2].Value != null && (workExperience.Rows[i].Cells[1].Value == null ||
                    workExperience.Rows[i].Cells[0].Value == null)))
                {
                    return true;
                }
            }
            if((hsName.Text.Trim() == "" && yGHS.Text.Trim().Length > 0) ||
                (yGHS.Text.Trim() == "" && hsName.Text.Trim().Length > 0 ))
            {
                return true;
            }
            if((clgUnivName.Text.Trim() == "" && (course.Text.Trim() != "" || yearClgGraduated.Text.Trim() != ""))||
                (course.Text.Trim() == "" && (clgUnivName.Text.Trim() != "" || yearClgGraduated.Text.Trim() != ""))||
                (yearClgGraduated.Text.Trim() == "" && (course.Text.Trim() != "" || clgUnivName.Text.Trim() != "")))
            {
                return true;
            }
            return false;
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
                else
                {
                    if(allTxtBox[i].Text.Trim() == "")
                    {
                        allTxtBox[i].BackColor = Color.Red;
                    }
                }
            }
            for (int i = 0; i < workExperience.RowCount; i++)
            {
                if ((workExperience.Rows[i].Cells[0].Value != null && (workExperience.Rows[i].Cells[1].Value == null ||
                    workExperience.Rows[i].Cells[2].Value == null)) || (workExperience.Rows[i].Cells[1].Value != null &&
                    (workExperience.Rows[i].Cells[0].Value == null || workExperience.Rows[i].Cells[2].Value == null)) ||
                    (workExperience.Rows[i].Cells[2].Value != null && (workExperience.Rows[i].Cells[1].Value == null ||
                    workExperience.Rows[i].Cells[0].Value == null)))
                {
                    string order = Ordinal(i + 1);
                    requiredWorkExperience.Text = $"{order} row is not completed.";
                }
            }
            if ((hsName.Text.Trim() == "" && yGHS.Text.Trim().Length > 0) ||
                (yGHS.Text.Trim() == "" && hsName.Text.Trim().Length > 0))
            {
                hsName.BackColor = Color.Red;
                yGHS.BackColor = Color.Red;
            }
            if ((clgUnivName.Text.Trim() == "" && (course.Text.Trim() != "" || yearClgGraduated.Text.Trim() != "")) ||
                (course.Text.Trim() == "" && (clgUnivName.Text.Trim() != "" || yearClgGraduated.Text.Trim() != "")) ||
                (yearClgGraduated.Text.Trim() == "" && (course.Text.Trim() != "" || clgUnivName.Text.Trim() != "")))
            {
                clgUnivName.BackColor = Color.Red;
                course.BackColor = Color.Red;
                yearClgGraduated.BackColor = Color.Red;
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

        private void summary_Click(object sender, EventArgs e)
        {
            summary.BackColor = Color.White;
        }
        private void workExperience_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            requiredWorkExperience.Text = "";
        }
        private void hsName_Click(object sender, EventArgs e)
        {
            hsName.BackColor = SystemColors.Window;
            yGHS.BackColor = SystemColors.Window;
        }

        private void yGHS_Click(object sender, EventArgs e)
        {
            hsName.BackColor = SystemColors.Window;
            yGHS.BackColor = SystemColors.Window;
        }

        private void clgUnivName_Click(object sender, EventArgs e)
        {
            clgUnivName.BackColor = SystemColors.Window;
            yearClgGraduated.BackColor = SystemColors.Window;
            course.BackColor = SystemColors.Window;
        }
        private void course_Click(object sender, EventArgs e)
        {
            clgUnivName.BackColor = SystemColors.Window;
            yearClgGraduated.BackColor = SystemColors.Window;
            course.BackColor = SystemColors.Window;
        }
        private void yearClgGraduated_Click(object sender, EventArgs e)
        {
            clgUnivName.BackColor = SystemColors.Window;
            yearClgGraduated.BackColor = SystemColors.Window;
            course.BackColor = SystemColors.Window;
        }
        private void fName_TextChanged(object sender, EventArgs e)
        {
            fullName.Text = $"{fName.Text} {lName.Text}";
        }

        private void lName_TextChanged(object sender, EventArgs e)
        {
            fullName.Text = $"{fName.Text} {lName.Text}";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ResetData();
            fullName.Text = string.Empty;
            summary.Text = string.Empty;
            fName.Text = string.Empty;
            lName.Text = string.Empty;
            address.Text = string.Empty;
            skills.Text = string.Empty;
            cpNumber.Text = string.Empty;
            llNumber.Text = string.Empty;
            hsName.Text = string.Empty;
            yGHS.Text = string.Empty;
            clgUnivName.Text = string.Empty;
            yearClgGraduated.Text = string.Empty;
            course.Text = string.Empty;
            workExperience.Rows.Clear();
            workExperience.Refresh();
        }

        private void GenerateJSON_Click(object sender, EventArgs e)
        {
            if (RequiredNeed())
            {
                RedRequired();
            }
            else
            {
                TempSaveData();
                ParseJSON();
                CreateJsonFile();
                ResetData();
            }
        }

        private void loadJsonButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON File (*.json)|*.json";
            openFileDialog1.FileName = "";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                jsonPath = $"{openFileDialog1.FileName}";
            }
            if(jsonPath != string.Empty)
            {
                GetJson();
            }
        }
        private void pdfButton_Click(object sender, EventArgs e)
        {
            if (RequiredNeed())
            {
                RedRequired();
            }
            else
            {
                TempSaveData();
            }
        }
        // functionality
        private void TempSaveData()
        {
            string tempSkill;
            tFName = fName.Text;
            tLName = lName.Text;
            tFullName = $"{tFName} {tLName}";
            tAddress = address.Text;
            tCpNumber = cpNumber.Text;
            tLlNumber = llNumber.Text;
            tEmailAddress = emailAddress.Text;
            tSummary = summary.Text;
            if (skills.Text.Trim() != "")
            {
                tempSkill = skills.Text.Replace(" ", string.Empty);
                tSkills.AddRange(tempSkill.Split(","));
            }
            if(hsName.Text.Trim() != "")
            {
                tHighSchool.Add(hsName.Text);
                tHighSchool.Add(yGHS.Text);
            }
            if(clgUnivName.Text.Trim() != "")
            {
                tCollege.Add(clgUnivName.Text);
                tCollege.Add(course.Text);
                tCollege.Add(yearClgGraduated.Text);
            }
            for(int i = 0; i < workExperience.RowCount; i++)
            {
                if (workExperience.Rows[i].Cells[0].Value == null)
                {
                    continue;
                }
                else
                {
                    tJobTitle.Add(workExperience.Rows[i].Cells[0].Value.ToString());
                    tCompanyName.Add(workExperience.Rows[i].Cells[1].Value.ToString());
                    tDuration.Add(workExperience.Rows[i].Cells[2].Value.ToString());
                }
            }
        }

        private void ParseJSON()
        {
            personal = new PersonalDetails.Personal();
            personal.Skills = new List<string>();
            personal.HighSchool = new List<string>();
            personal.College = new List<string>();
            personal.JobTitle = new List<string>();
            personal.CompanyName = new List<string>();
            personal.YearDuration = new List<string>();
            personal.FirstName = tFName;
            personal.LastName = tLName;
            personal.FullName = tFullName;
            personal.Address = tAddress;
            personal.EmailAddress = tEmailAddress;
            personal.Summary = tSummary;
            if(tCpNumber.Trim() != "")
            {
                personal.CpNumber = tCpNumber;
            }
            if(tLlNumber.Trim() != "")
            {
                personal.LlNumber = tLlNumber;
            }
            if(tSkills.Count > 0)
            {
                personal.Skills.AddRange(tSkills);
            }
            if(tHighSchool.Count > 0)
            {
                personal.HighSchool.AddRange(tHighSchool);
            }
            if(tCollege.Count > 0)
            {
                personal.College.AddRange(tCollege);
            }
            if(tJobTitle.Count > 0)
            {
                personal.JobTitle.AddRange(tJobTitle);
                personal.CompanyName.AddRange(tCompanyName);
                personal.YearDuration.AddRange(tDuration);
            }
        }

        private void CreateJsonFile()
        {
            File.WriteAllText(@$"save\{tFName}_{tLName}.json", JsonConvert.SerializeObject(personal));
            update.Text = "JSON Saved!";
        }

        private void ResetData()
        {
            tFName = "";
            tLName = "";
            tFullName = "";
            tAddress = "";
            tCpNumber = "";
            tLlNumber = "";
            tEmailAddress = "";
            tSummary = "";
            tHighSchool.Clear();
            tCollege.Clear();
            tSkills.Clear();
            tJobTitle.Clear();
            tCompanyName.Clear();
            tDuration.Clear();
        }
        private void GetJson()
        {
            PersonalDetails.Personal loadPersonal = JsonConvert.DeserializeObject<PersonalDetails.Personal>
                (File.ReadAllText(@$"{jsonPath}"));
            personal = new PersonalDetails.Personal();
            personal = loadPersonal;
            fullName.Text = personal.FullName;
            fName.Text = personal.FirstName;
            lName.Text = personal.LastName;
            address.Text = personal.Address;
            if(personal.CpNumber != string.Empty || personal.CpNumber != null)
            {
                cpNumber.Text = personal.CpNumber;
            }
            if (personal.LlNumber != string.Empty || personal.LlNumber != null)
            {
                llNumber.Text = personal.LlNumber;
            }
            emailAddress.Text = personal.EmailAddress;
            if (personal.Skills.Count > 0)
            {
                skills.Text = string.Join(", ", personal.Skills);
            }
            summary.Text = personal.Summary;
            if (personal.HighSchool.Count > 0)
            {
                hsName.Text = personal.HighSchool[0];
                yGHS.Text = personal.HighSchool[1];
            }
            if (personal.College.Count > 0)
            {
                clgUnivName.Text = personal.College[0];
                course.Text = personal.College[1];
                yearClgGraduated.Text = personal.College[2];
            }
            for (int i = 0; i < personal.JobTitle.Count; i++)
            {
                workExperience.Rows[i].Cells[0].Value = personal.JobTitle[i];
                workExperience.Rows[i].Cells[1].Value = personal.CompanyName[i];
                workExperience.Rows[i].Cells[2].Value = personal.YearDuration[i];
            }
            update.Text = "JSON Loaded!";
            ResetData();
        }
    }
}
