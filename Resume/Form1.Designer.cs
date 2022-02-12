
namespace Resume
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cpnLabel = new System.Windows.Forms.Label();
            this.llnLabel = new System.Windows.Forms.Label();
            this.emailaLabel = new System.Windows.Forms.Label();
            this.titleContactLabel = new System.Windows.Forms.Label();
            this.cpNumber = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.llNumber = new System.Windows.Forms.TextBox();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.educTitleLabel = new System.Windows.Forms.Label();
            this.highSchoolTitleLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.hsLabel = new System.Windows.Forms.Label();
            this.yrhsEnd = new System.Windows.Forms.Label();
            this.hsName = new System.Windows.Forms.TextBox();
            this.yGHS = new System.Windows.Forms.TextBox();
            this.collegeTitleLabel = new System.Windows.Forms.Label();
            this.yearClgGraduated = new System.Windows.Forms.TextBox();
            this.clgUnivName = new System.Windows.Forms.TextBox();
            this.yrClgGraduatedLabel = new System.Windows.Forms.Label();
            this.clgName = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.skillLabel = new System.Windows.Forms.Label();
            this.skills = new System.Windows.Forms.TextBox();
            this.workingExperienceLabel = new System.Windows.Forms.Label();
            this.summaryLabeel = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.TextBox();
            this.loadJsonButton = new System.Windows.Forms.Button();
            this.pdfButton = new System.Windows.Forms.Button();
            this.workExperience = new System.Windows.Forms.DataGridView();
            this.jobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredWorkExperience = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.TextBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.GenerateJSON = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(11, 60);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(67, 15);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "First Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(11, 116);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(52, 15);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // cpnLabel
            // 
            this.cpnLabel.AutoSize = true;
            this.cpnLabel.Location = new System.Drawing.Point(11, 145);
            this.cpnLabel.Name = "cpnLabel";
            this.cpnLabel.Size = new System.Drawing.Size(111, 15);
            this.cpnLabel.TabIndex = 2;
            this.cpnLabel.Text = "Cellphone Number:";
            // 
            // llnLabel
            // 
            this.llnLabel.AutoSize = true;
            this.llnLabel.Location = new System.Drawing.Point(11, 176);
            this.llnLabel.Name = "llnLabel";
            this.llnLabel.Size = new System.Drawing.Size(102, 15);
            this.llnLabel.TabIndex = 3;
            this.llnLabel.Text = "Landline Number:";
            // 
            // emailaLabel
            // 
            this.emailaLabel.AutoSize = true;
            this.emailaLabel.Location = new System.Drawing.Point(11, 208);
            this.emailaLabel.Name = "emailaLabel";
            this.emailaLabel.Size = new System.Drawing.Size(84, 15);
            this.emailaLabel.TabIndex = 4;
            this.emailaLabel.Text = "Email Address:";
            // 
            // titleContactLabel
            // 
            this.titleContactLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleContactLabel.AutoSize = true;
            this.titleContactLabel.Location = new System.Drawing.Point(158, 9);
            this.titleContactLabel.Name = "titleContactLabel";
            this.titleContactLabel.Size = new System.Drawing.Size(105, 15);
            this.titleContactLabel.TabIndex = 5;
            this.titleContactLabel.Text = "CONTACT DETAILS";
            // 
            // cpNumber
            // 
            this.cpNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpNumber.Location = new System.Drawing.Point(128, 142);
            this.cpNumber.Name = "cpNumber";
            this.cpNumber.Size = new System.Drawing.Size(437, 23);
            this.cpNumber.TabIndex = 4;
            this.cpNumber.Click += new System.EventHandler(this.cpNumber_Click);
            this.cpNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpNumber_KeyPress);
            // 
            // address
            // 
            this.address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address.Location = new System.Drawing.Point(128, 113);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(437, 23);
            this.address.TabIndex = 3;
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // fName
            // 
            this.fName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fName.Location = new System.Drawing.Point(128, 57);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(437, 23);
            this.fName.TabIndex = 1;
            this.fName.Click += new System.EventHandler(this.fName_Click);
            this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
            // 
            // llNumber
            // 
            this.llNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llNumber.Location = new System.Drawing.Point(128, 173);
            this.llNumber.Name = "llNumber";
            this.llNumber.Size = new System.Drawing.Size(437, 23);
            this.llNumber.TabIndex = 5;
            this.llNumber.Click += new System.EventHandler(this.llNumber_Click);
            this.llNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.llNumber_KeyPress);
            // 
            // emailAddress
            // 
            this.emailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailAddress.Location = new System.Drawing.Point(128, 205);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(437, 23);
            this.emailAddress.TabIndex = 6;
            this.emailAddress.Click += new System.EventHandler(this.emailAddress_Click);
            // 
            // educTitleLabel
            // 
            this.educTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.educTitleLabel.AutoSize = true;
            this.educTitleLabel.Location = new System.Drawing.Point(323, 240);
            this.educTitleLabel.Name = "educTitleLabel";
            this.educTitleLabel.Size = new System.Drawing.Size(158, 15);
            this.educTitleLabel.TabIndex = 6;
            this.educTitleLabel.Text = "EDUCATIONAL ATTAINMENT";
            // 
            // highSchoolTitleLabel
            // 
            this.highSchoolTitleLabel.AutoSize = true;
            this.highSchoolTitleLabel.Location = new System.Drawing.Point(158, 253);
            this.highSchoolTitleLabel.Name = "highSchoolTitleLabel";
            this.highSchoolTitleLabel.Size = new System.Drawing.Size(72, 15);
            this.highSchoolTitleLabel.TabIndex = 7;
            this.highSchoolTitleLabel.Text = "High School";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(11, 89);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(66, 15);
            this.lNameLabel.TabIndex = 8;
            this.lNameLabel.Text = "Last Name:";
            // 
            // lName
            // 
            this.lName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lName.Location = new System.Drawing.Point(128, 86);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(437, 23);
            this.lName.TabIndex = 2;
            this.lName.Click += new System.EventHandler(this.lName_Click);
            this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
            // 
            // hsLabel
            // 
            this.hsLabel.AutoSize = true;
            this.hsLabel.Location = new System.Drawing.Point(11, 277);
            this.hsLabel.Name = "hsLabel";
            this.hsLabel.Size = new System.Drawing.Size(134, 15);
            this.hsLabel.TabIndex = 10;
            this.hsLabel.Text = "Last High School Name:";
            // 
            // yrhsEnd
            // 
            this.yrhsEnd.AutoSize = true;
            this.yrhsEnd.Location = new System.Drawing.Point(12, 302);
            this.yrhsEnd.Name = "yrhsEnd";
            this.yrhsEnd.Size = new System.Drawing.Size(90, 15);
            this.yrhsEnd.TabIndex = 11;
            this.yrhsEnd.Text = "Year Graduated:";
            // 
            // hsName
            // 
            this.hsName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hsName.Location = new System.Drawing.Point(146, 274);
            this.hsName.MaximumSize = new System.Drawing.Size(280, 23);
            this.hsName.Name = "hsName";
            this.hsName.Size = new System.Drawing.Size(280, 23);
            this.hsName.TabIndex = 8;
            this.hsName.Click += new System.EventHandler(this.hsName_Click);
            // 
            // yGHS
            // 
            this.yGHS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yGHS.Location = new System.Drawing.Point(146, 299);
            this.yGHS.MaximumSize = new System.Drawing.Size(130, 23);
            this.yGHS.Name = "yGHS";
            this.yGHS.PlaceholderText = "(ex: 2001)";
            this.yGHS.Size = new System.Drawing.Size(130, 23);
            this.yGHS.TabIndex = 9;
            this.yGHS.Click += new System.EventHandler(this.yGHS_Click);
            this.yGHS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yGHS_KeyPress);
            // 
            // collegeTitleLabel
            // 
            this.collegeTitleLabel.AutoSize = true;
            this.collegeTitleLabel.Location = new System.Drawing.Point(568, 253);
            this.collegeTitleLabel.Name = "collegeTitleLabel";
            this.collegeTitleLabel.Size = new System.Drawing.Size(45, 15);
            this.collegeTitleLabel.TabIndex = 14;
            this.collegeTitleLabel.Text = "Tertiary";
            // 
            // yearClgGraduated
            // 
            this.yearClgGraduated.Location = new System.Drawing.Point(569, 328);
            this.yearClgGraduated.MaximumSize = new System.Drawing.Size(150, 23);
            this.yearClgGraduated.Name = "yearClgGraduated";
            this.yearClgGraduated.PlaceholderText = "(ex: 2022 or 2017-Present)";
            this.yearClgGraduated.Size = new System.Drawing.Size(150, 23);
            this.yearClgGraduated.TabIndex = 12;
            this.yearClgGraduated.Click += new System.EventHandler(this.yearClgGraduated_Click);
            // 
            // clgUnivName
            // 
            this.clgUnivName.Location = new System.Drawing.Point(569, 274);
            this.clgUnivName.MaximumSize = new System.Drawing.Size(280, 23);
            this.clgUnivName.Name = "clgUnivName";
            this.clgUnivName.Size = new System.Drawing.Size(224, 23);
            this.clgUnivName.TabIndex = 10;
            this.clgUnivName.Click += new System.EventHandler(this.clgUnivName_Click);
            // 
            // yrClgGraduatedLabel
            // 
            this.yrClgGraduatedLabel.AutoSize = true;
            this.yrClgGraduatedLabel.Location = new System.Drawing.Point(434, 331);
            this.yrClgGraduatedLabel.Name = "yrClgGraduatedLabel";
            this.yrClgGraduatedLabel.Size = new System.Drawing.Size(90, 15);
            this.yrClgGraduatedLabel.TabIndex = 16;
            this.yrClgGraduatedLabel.Text = "Year Graduated:";
            // 
            // clgName
            // 
            this.clgName.AutoSize = true;
            this.clgName.Location = new System.Drawing.Point(434, 277);
            this.clgName.Name = "clgName";
            this.clgName.Size = new System.Drawing.Size(109, 15);
            this.clgName.TabIndex = 15;
            this.clgName.Text = "Last College Name:";
            // 
            // summaryLabel
            // 
            this.summaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(1593, 9);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(58, 15);
            this.summaryLabel.TabIndex = 19;
            this.summaryLabel.Text = "Summary";
            // 
            // textBox7
            // 
            this.textBox7.AcceptsReturn = true;
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(1346, 32);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(305, 180);
            this.textBox7.TabIndex = 20;
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.Location = new System.Drawing.Point(12, 360);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(36, 15);
            this.skillLabel.TabIndex = 21;
            this.skillLabel.Text = "Skills:";
            // 
            // skills
            // 
            this.skills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skills.Location = new System.Drawing.Point(54, 357);
            this.skills.Name = "skills";
            this.skills.PlaceholderText = "Seperated by comma (ex: C# Language Expert, Circuits Expert, Knowledgable at ardu" +
    "ino)";
            this.skills.Size = new System.Drawing.Size(739, 23);
            this.skills.TabIndex = 13;
            // 
            // workingExperienceLabel
            // 
            this.workingExperienceLabel.AutoSize = true;
            this.workingExperienceLabel.Location = new System.Drawing.Point(394, 407);
            this.workingExperienceLabel.Name = "workingExperienceLabel";
            this.workingExperienceLabel.Size = new System.Drawing.Size(112, 15);
            this.workingExperienceLabel.TabIndex = 23;
            this.workingExperienceLabel.Text = "Working Experience";
            // 
            // summaryLabeel
            // 
            this.summaryLabeel.AutoSize = true;
            this.summaryLabeel.Location = new System.Drawing.Point(609, 9);
            this.summaryLabeel.Name = "summaryLabeel";
            this.summaryLabeel.Size = new System.Drawing.Size(61, 15);
            this.summaryLabeel.TabIndex = 36;
            this.summaryLabeel.Text = "Summary:";
            // 
            // summary
            // 
            this.summary.AcceptsReturn = true;
            this.summary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.summary.Location = new System.Drawing.Point(609, 36);
            this.summary.Multiline = true;
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(302, 176);
            this.summary.TabIndex = 7;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // loadJsonButton
            // 
            this.loadJsonButton.Location = new System.Drawing.Point(12, 584);
            this.loadJsonButton.Name = "loadJsonButton";
            this.loadJsonButton.Size = new System.Drawing.Size(96, 23);
            this.loadJsonButton.TabIndex = 38;
            this.loadJsonButton.Text = "Load JSON";
            this.loadJsonButton.UseVisualStyleBackColor = true;
            this.loadJsonButton.Click += new System.EventHandler(this.loadJsonButton_Click);
            // 
            // pdfButton
            // 
            this.pdfButton.Location = new System.Drawing.Point(685, 584);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(99, 23);
            this.pdfButton.TabIndex = 39;
            this.pdfButton.Text = "Generate PDF";
            this.pdfButton.UseVisualStyleBackColor = true;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // workExperience
            // 
            this.workExperience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workExperience.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobTitle,
            this.companyName,
            this.jobDuration});
            this.workExperience.Location = new System.Drawing.Point(12, 453);
            this.workExperience.Name = "workExperience";
            this.workExperience.RowTemplate.Height = 25;
            this.workExperience.Size = new System.Drawing.Size(885, 125);
            this.workExperience.TabIndex = 40;
            this.workExperience.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workExperience_CellClick);
            // 
            // jobTitle
            // 
            this.jobTitle.HeaderText = "Job Title";
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Width = 280;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            this.companyName.Width = 280;
            // 
            // jobDuration
            // 
            this.jobDuration.HeaderText = "Job Duration";
            this.jobDuration.Name = "jobDuration";
            this.jobDuration.Width = 280;
            // 
            // requiredWorkExperience
            // 
            this.requiredWorkExperience.AutoSize = true;
            this.requiredWorkExperience.ForeColor = System.Drawing.Color.Red;
            this.requiredWorkExperience.Location = new System.Drawing.Point(12, 435);
            this.requiredWorkExperience.Name = "requiredWorkExperience";
            this.requiredWorkExperience.Size = new System.Drawing.Size(0, 15);
            this.requiredWorkExperience.TabIndex = 41;
            this.requiredWorkExperience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(569, 299);
            this.course.MaximumSize = new System.Drawing.Size(280, 23);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(224, 23);
            this.course.TabIndex = 11;
            this.course.Click += new System.EventHandler(this.course_Click);
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(434, 307);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(47, 15);
            this.courseLabel.TabIndex = 43;
            this.courseLabel.Text = "Course:";
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.ForeColor = System.Drawing.Color.Red;
            this.update.Location = new System.Drawing.Point(12, 626);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(0, 15);
            this.update.TabIndex = 44;
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update.MouseDown += new System.Windows.Forms.MouseEventHandler(this.update_MouseDown);
            // 
            // GenerateJSON
            // 
            this.GenerateJSON.Location = new System.Drawing.Point(583, 584);
            this.GenerateJSON.Name = "GenerateJSON";
            this.GenerateJSON.Size = new System.Drawing.Size(96, 23);
            this.GenerateJSON.TabIndex = 45;
            this.GenerateJSON.Text = "Generate JSON";
            this.GenerateJSON.UseVisualStyleBackColor = true;
            this.GenerateJSON.Click += new System.EventHandler(this.GenerateJSON_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(10, 36);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.fullNameLabel.TabIndex = 46;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Location = new System.Drawing.Point(128, 36);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(0, 15);
            this.fullName.TabIndex = 47;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(323, 584);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(96, 23);
            this.reset.TabIndex = 48;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 650);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.GenerateJSON);
            this.Controls.Add(this.update);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.course);
            this.Controls.Add(this.requiredWorkExperience);
            this.Controls.Add(this.workExperience);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.loadJsonButton);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.summaryLabeel);
            this.Controls.Add(this.workingExperienceLabel);
            this.Controls.Add(this.skills);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.yearClgGraduated);
            this.Controls.Add(this.clgUnivName);
            this.Controls.Add(this.yrClgGraduatedLabel);
            this.Controls.Add(this.clgName);
            this.Controls.Add(this.collegeTitleLabel);
            this.Controls.Add(this.yGHS);
            this.Controls.Add(this.hsName);
            this.Controls.Add(this.yrhsEnd);
            this.Controls.Add(this.hsLabel);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.highSchoolTitleLabel);
            this.Controls.Add(this.educTitleLabel);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.llNumber);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.address);
            this.Controls.Add(this.cpNumber);
            this.Controls.Add(this.titleContactLabel);
            this.Controls.Add(this.emailaLabel);
            this.Controls.Add(this.llnLabel);
            this.Controls.Add(this.cpnLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.fNameLabel);
            this.MaximumSize = new System.Drawing.Size(939, 689);
            this.MinimumSize = new System.Drawing.Size(939, 600);
            this.Name = "Form1";
            this.Text = "Resume Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cpnLabel;
        private System.Windows.Forms.Label llnLabel;
        private System.Windows.Forms.Label emailaLabel;
        private System.Windows.Forms.Label titleContactLabel;
        private System.Windows.Forms.TextBox cpNumber;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox llNumber;
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.Label educTitleLabel;
        private System.Windows.Forms.Label highSchoolTitleLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label hsLabel;
        private System.Windows.Forms.Label yrhsEnd;
        private System.Windows.Forms.TextBox hsName;
        private System.Windows.Forms.TextBox yGHS;
        private System.Windows.Forms.Label collegeTitleLabel;
        private System.Windows.Forms.TextBox yearClgGraduated;
        private System.Windows.Forms.TextBox clgUnivName;
        private System.Windows.Forms.Label yrClgGraduatedLabel;
        private System.Windows.Forms.Label clgName;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.TextBox skills;
        private System.Windows.Forms.Label workingExperienceLabel;
        private System.Windows.Forms.Label summaryLabeel;
        private System.Windows.Forms.TextBox summary;
        private System.Windows.Forms.Button loadJsonButton;
        private System.Windows.Forms.Button pdfButton;
        private System.Windows.Forms.DataGridView workExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDuration;
        private System.Windows.Forms.Label requiredWorkExperience;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.Button GenerateJSON;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Button reset;
    }
}

