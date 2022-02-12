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
        private void update_MouseDown(object sender, MouseEventArgs e)
        {
            update.Text = "";
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
            emailAddress.Text = string.Empty;
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
                CreatePDF();
                ResetData();
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
            workExperience.Rows.Insert(0);
            for (int i = 0; i < personal.JobTitle.Count; i++)
            {
                if (i == 0)
                {
                    workExperience.Rows[i].Cells[0].Value = personal.JobTitle[i];
                    workExperience.Rows[i].Cells[1].Value = personal.CompanyName[i];
                    workExperience.Rows[i].Cells[2].Value = personal.YearDuration[i];
                }
                else
                {
                    string[] row = new string[] {personal.JobTitle[i], personal.CompanyName[i],
                    personal.YearDuration[i]};
                    workExperience.Rows.Insert(i, row);
                }
            }
            update.Text = "JSON Loaded!";
            ResetData();
        }
        private void CreatePDF()
        {
            bool withll = false, withcp = false;
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 72, 72, 72, 72);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@$"save\{tFName}_{tLName}.pdf", FileMode.Create));
            BaseFont bDefault = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            iTextSharp.text.Font fDefault = new iTextSharp.text.Font(bDefault, 12);
            Chunk linebreak = new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(2f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1));
            Paragraph endLine = new Paragraph("\n");

            //for Full Name
            BaseFont bfFullName = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, false);
            iTextSharp.text.Font fFullName = new iTextSharp.text.Font(bfFullName, 16);
            Paragraph pFullName = new Paragraph($"{tFullName.ToUpper()}", fFullName);

            // For Contact Details
            Paragraph pContactDetails1 = new Paragraph($"Address: {tAddress}", fDefault);
            Paragraph pContactDetails2 = new Paragraph("");
            if (tLlNumber != "" && tCpNumber != "")
            {
                withll = true;
                withcp = true;
                pContactDetails2 = new Paragraph($"Landline Number: {tLlNumber}\n" +
                    $"Cellphone Number: {tCpNumber}\n" +
                    $"Email Address: {tEmailAddress}", fDefault);
            }
            else if (tLlNumber != "")
            {
                withll = true;
                pContactDetails2 = new Paragraph($"Landline Number: {tLlNumber}\n" +
                    $"Email Address: {tEmailAddress}", fDefault);
            }
            else if (tCpNumber != "")
            {
                withcp = true;
                pContactDetails2 = new Paragraph($"Cellphone Number: {tCpNumber}\n" +
                    $"Email Address: {tEmailAddress}", fDefault);
            }

            // for table header & summary
            iTextSharp.text.Font fDefaultBold = new iTextSharp.text.Font(bfFullName, 12);
            PdfPTable taSummary = new PdfPTable(1);
            PdfPCell cSummary = new PdfPCell(new Phrase("SUMMARY", fDefaultBold));
            cSummary.BackgroundColor = BaseColor.LIGHT_GRAY;
            cSummary.VerticalAlignment = 1;
            taSummary.AddCell(cSummary);
            taSummary.WidthPercentage = 100;
            Paragraph pSummary = new Paragraph($"{tSummary}",fDefault);

            // for educational background
            PdfPTable taEduc = new PdfPTable(1);
            PdfPCell cEduc = new PdfPCell(new Phrase("EDUCATIONAL BACKGROUND", fDefaultBold));
            cEduc.BackgroundColor = BaseColor.LIGHT_GRAY;
            cEduc.VerticalAlignment = 1;
            taEduc.AddCell(cEduc);
            taEduc.WidthPercentage = 100;
            PdfPTable taEducB = new PdfPTable(3);
            PdfPCell cName = new PdfPCell(new Phrase("School Name", fDefaultBold));
            PdfPCell cCourseLevel = new PdfPCell(new Phrase("Degree/Level", fDefaultBold));
            PdfPCell cYear = new PdfPCell(new Phrase("Year Graduated", fDefaultBold));
            cName.VerticalAlignment = 1; cName.HorizontalAlignment = 1;
            cCourseLevel.VerticalAlignment = 1; cCourseLevel.HorizontalAlignment = 1;
            cYear.VerticalAlignment = 1; cYear.HorizontalAlignment = 1;
            taEducB.AddCell(cName);
            taEducB.AddCell(cCourseLevel);
            taEducB.AddCell(cYear);
            for(int i = 0; i < tCollege.Count; i++)
            {
                if (i == 1)
                {
                    PdfPCell educHolder = new PdfPCell(new Phrase($"Tertiary\n{tCollege[i]}", fDefault));
                    educHolder.VerticalAlignment = 1;
                    educHolder.HorizontalAlignment = 1;
                    taEducB.AddCell(educHolder);
                }
                else
                {
                    PdfPCell educHolder = new PdfPCell(new Phrase($"{tCollege[i]}", fDefault));
                    educHolder.VerticalAlignment = 1;
                    educHolder.HorizontalAlignment = 1;
                    taEducB.AddCell(educHolder);
                }
            }
            for(int i = 0; i < tHighSchool.Count; i++)
            {
                if(i==0)
                {
                    PdfPCell educHolder = new PdfPCell(new Phrase($"{tHighSchool[i]}", fDefault));
                    PdfPCell educHolder2 = new PdfPCell(new Phrase($"Secondary Level", fDefault));
                    educHolder.VerticalAlignment = 1; educHolder2.VerticalAlignment = 1;
                    educHolder.HorizontalAlignment = 1; educHolder2.HorizontalAlignment = 1;
                    taEducB.AddCell(educHolder); taEducB.AddCell(educHolder2);
                }
                else
                {
                    PdfPCell educHolder = new PdfPCell(new Phrase($"{tHighSchool[i]}", fDefault));
                    educHolder.VerticalAlignment = 1;
                    educHolder.HorizontalAlignment = 1;
                    taEducB.AddCell(educHolder);
                }
            }
            taEducB.WidthPercentage = 100;

            // for skills
            PdfPTable taSkills = new PdfPTable(1);
            PdfPCell cSkills = new PdfPCell(new Phrase("SKILLS", fDefaultBold));
            cSkills.BackgroundColor = BaseColor.LIGHT_GRAY;
            cSkills.VerticalAlignment = 1;
            taSkills.AddCell(cSkills);
            taSkills.WidthPercentage = 100;
            iTextSharp.text.List skillset = new iTextSharp.text.List(iTextSharp.text.List.UNORDERED);
            for(int i = 0; i < tSkills.Count; i++)
            {
                var holder = new Phrase(tSkills[i], fDefault);
                skillset.Add(new iTextSharp.text.ListItem(holder));
            }

            // for working experience
            PdfPTable taWorkExp = new PdfPTable(1);
            PdfPCell cWorkExp = new PdfPCell(new Phrase("WORKING EXPERIENCE", fDefaultBold));
            cWorkExp.BackgroundColor = BaseColor.LIGHT_GRAY;
            cWorkExp.VerticalAlignment = 1;
            taWorkExp.AddCell(cWorkExp);
            taWorkExp.WidthPercentage = 100;
            PdfPTable taWE = new PdfPTable(3);
            taWE.WidthPercentage = 100;
            PdfPCell cJobTitleL = new PdfPCell(new Phrase("Job Title", fDefaultBold));
            cJobTitleL.VerticalAlignment = 1; cJobTitleL.HorizontalAlignment = 1;
            PdfPCell cCompanyNameL = new PdfPCell(new Phrase("Company Name", fDefaultBold));
            cCompanyNameL.VerticalAlignment = 1; cCompanyNameL.HorizontalAlignment = 1;
            PdfPCell cDurationL = new PdfPCell(new Phrase("Duration", fDefaultBold));
            cDurationL.VerticalAlignment = 1; cDurationL.HorizontalAlignment = 1;
            taWE.AddCell(cJobTitleL);
            taWE.AddCell(cCompanyNameL);
            taWE.AddCell(cDurationL);
            for (int i = 0; i < tJobTitle.Count; i++)
            {
                PdfPCell cJobTitle = new PdfPCell(new Phrase(tJobTitle[i], fDefault));
                cJobTitle.VerticalAlignment = 1; cJobTitle.HorizontalAlignment = 1;
                PdfPCell cCompanyName = new PdfPCell(new Phrase(tCompanyName[i], fDefault));
                cCompanyName.VerticalAlignment = 1; cCompanyName.HorizontalAlignment = 1;
                PdfPCell cDuration = new PdfPCell(new Phrase(tDuration[i], fDefault));
                cDuration.VerticalAlignment = 1; cDuration.HorizontalAlignment = 1;
                taWE.AddCell(cJobTitle);
                taWE.AddCell(cCompanyName);
                taWE.AddCell(cDuration);
            }

            // creating PDF
            doc.Open();

            // for Full Name
            doc.Add(pFullName);

            // for contact details
            doc.Add(pContactDetails1);
            doc.Add(pContactDetails2);
            doc.Add(linebreak);

            //summary
            doc.Add(taSummary);
            doc.Add(pSummary);

            //educ
            doc.Add(endLine);
            doc.Add(taEduc);
            doc.Add(endLine);
            doc.Add(taEducB);

            //skills
            doc.Add(endLine);
            doc.Add(taSkills);
            doc.Add(skillset);

            //for working experience
            doc.Add(endLine);
            doc.Add(taWorkExp);
            doc.Add(endLine);
            doc.Add(taWE);

            doc.Close();
            update.Text = "PDF Generated";
        }
    }
}
