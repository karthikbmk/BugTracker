namespace TestDB
{
    partial class IssueTrackerMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.cboUserNames = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblCR = new System.Windows.Forms.Label();
            this.cboCR = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSelectedProject = new System.Windows.Forms.Label();
            this.lblSelectedCR = new System.Windows.Forms.Label();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtIssueNo = new System.Windows.Forms.TextBox();
            this.btnRaise = new System.Windows.Forms.Button();
            this.lblIssueNo = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.cboAddDelUpd = new System.Windows.Forms.ComboBox();
            this.lblAddDelUpd = new System.Windows.Forms.Label();
            this.lblIssueDesc = new System.Windows.Forms.Label();
            this.txtIssueDesc = new System.Windows.Forms.RichTextBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.cboSeverity = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboDev = new System.Windows.Forms.ComboBox();
            this.lblDev = new System.Windows.Forms.Label();
            this.cboLead = new System.Windows.Forms.ComboBox();
            this.lblLead = new System.Windows.Forms.Label();
            this.btnIssueSubmit = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.txtDelIssue = new System.Windows.Forms.TextBox();
            this.lblDeleteIssue = new System.Windows.Forms.Label();
            this.bntDelete = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.cboUpdate = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblEnterDetials = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.cboUpdateLead = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboUpdateDev = new System.Windows.Forms.ComboBox();
            this.lblUpdateRemarks = new System.Windows.Forms.Label();
            this.lblUpdateIssueDesc = new System.Windows.Forms.Label();
            this.txtUpdateRemarks = new System.Windows.Forms.RichTextBox();
            this.cboUpdateStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateDesc = new System.Windows.Forms.RichTextBox();
            this.cboUpdateSeverity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "FTI ISSUE TRACKER";
            // 
            // cboUserNames
            // 
            this.cboUserNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserNames.FormattingEnabled = true;
            this.cboUserNames.Location = new System.Drawing.Point(12, 59);
            this.cboUserNames.Name = "cboUserNames";
            this.cboUserNames.Size = new System.Drawing.Size(244, 21);
            this.cboUserNames.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "User Name";
            // 
            // cboProject
            // 
            this.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(12, 138);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(244, 21);
            this.cboProject.TabIndex = 3;
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(9, 122);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Project";
            // 
            // lblCR
            // 
            this.lblCR.AutoSize = true;
            this.lblCR.Location = new System.Drawing.Point(9, 213);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(93, 13);
            this.lblCR.TabIndex = 2;
            this.lblCR.Text = "Enhancement/CR";
            // 
            // cboCR
            // 
            this.cboCR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCR.FormattingEnabled = true;
            this.cboCR.Location = new System.Drawing.Point(12, 229);
            this.cboCR.Name = "cboCR";
            this.cboCR.Size = new System.Drawing.Size(244, 21);
            this.cboCR.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(52, 270);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(800, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(58, 14);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "User     ::";
            // 
            // lblSelectedProject
            // 
            this.lblSelectedProject.AutoSize = true;
            this.lblSelectedProject.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProject.Location = new System.Drawing.Point(800, 24);
            this.lblSelectedProject.Name = "lblSelectedProject";
            this.lblSelectedProject.Size = new System.Drawing.Size(59, 14);
            this.lblSelectedProject.TabIndex = 5;
            this.lblSelectedProject.Text = "Project ::";
            // 
            // lblSelectedCR
            // 
            this.lblSelectedCR.AutoSize = true;
            this.lblSelectedCR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCR.Location = new System.Drawing.Point(799, 40);
            this.lblSelectedCR.Name = "lblSelectedCR";
            this.lblSelectedCR.Size = new System.Drawing.Size(60, 14);
            this.lblSelectedCR.TabIndex = 5;
            this.lblSelectedCR.Text = "CR         ::";
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToDeleteRows = false;
            this.dtGridView.AllowUserToOrderColumns = true;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(12, 86);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.Size = new System.Drawing.Size(1060, 283);
            this.dtGridView.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(968, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 44);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "GO BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtIssueNo
            // 
            this.txtIssueNo.Location = new System.Drawing.Point(776, 520);
            this.txtIssueNo.Name = "txtIssueNo";
            this.txtIssueNo.Size = new System.Drawing.Size(59, 20);
            this.txtIssueNo.TabIndex = 12;
            // 
            // btnRaise
            // 
            this.btnRaise.Location = new System.Drawing.Point(848, 517);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(75, 23);
            this.btnRaise.TabIndex = 7;
            this.btnRaise.Text = "RAISE";
            this.btnRaise.UseVisualStyleBackColor = true;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // lblIssueNo
            // 
            this.lblIssueNo.AutoSize = true;
            this.lblIssueNo.Location = new System.Drawing.Point(773, 504);
            this.lblIssueNo.Name = "lblIssueNo";
            this.lblIssueNo.Size = new System.Drawing.Size(52, 13);
            this.lblIssueNo.TabIndex = 11;
            this.lblIssueNo.Text = "Issue No:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(518, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(412, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(390, 177);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 7;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Visible = false;
            // 
            // cboAddDelUpd
            // 
            this.cboAddDelUpd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddDelUpd.FormattingEnabled = true;
            this.cboAddDelUpd.Items.AddRange(new object[] {
            "ADD",
            "DELETE",
            "UPDATE"});
            this.cboAddDelUpd.Location = new System.Drawing.Point(12, 388);
            this.cboAddDelUpd.Name = "cboAddDelUpd";
            this.cboAddDelUpd.Size = new System.Drawing.Size(244, 21);
            this.cboAddDelUpd.TabIndex = 14;
            this.cboAddDelUpd.SelectedIndexChanged += new System.EventHandler(this.cboAddDelUpd_SelectedIndexChanged);
            // 
            // lblAddDelUpd
            // 
            this.lblAddDelUpd.AutoSize = true;
            this.lblAddDelUpd.Location = new System.Drawing.Point(9, 372);
            this.lblAddDelUpd.Name = "lblAddDelUpd";
            this.lblAddDelUpd.Size = new System.Drawing.Size(105, 13);
            this.lblAddDelUpd.TabIndex = 13;
            this.lblAddDelUpd.Text = "ADD/DEL/UPDATE";
            // 
            // lblIssueDesc
            // 
            this.lblIssueDesc.AutoSize = true;
            this.lblIssueDesc.Location = new System.Drawing.Point(12, 439);
            this.lblIssueDesc.Name = "lblIssueDesc";
            this.lblIssueDesc.Size = new System.Drawing.Size(63, 13);
            this.lblIssueDesc.TabIndex = 15;
            this.lblIssueDesc.Text = "Issue Desc:";
            // 
            // txtIssueDesc
            // 
            this.txtIssueDesc.Location = new System.Drawing.Point(81, 436);
            this.txtIssueDesc.Name = "txtIssueDesc";
            this.txtIssueDesc.Size = new System.Drawing.Size(361, 44);
            this.txtIssueDesc.TabIndex = 16;
            this.txtIssueDesc.Text = "";
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(12, 491);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(48, 13);
            this.lblSeverity.TabIndex = 15;
            this.lblSeverity.Text = "Severity:";
            // 
            // cboSeverity
            // 
            this.cboSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeverity.FormattingEnabled = true;
            this.cboSeverity.Items.AddRange(new object[] {
            "SHOW STOPPER",
            "HIGH",
            "MEDIUM",
            "LOW",
            "COSMETIC"});
            this.cboSeverity.Location = new System.Drawing.Point(81, 488);
            this.cboSeverity.Name = "cboSeverity";
            this.cboSeverity.Size = new System.Drawing.Size(99, 21);
            this.cboSeverity.TabIndex = 14;
            this.cboSeverity.SelectedIndexChanged += new System.EventHandler(this.cboAddDelUpd_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "OPEN",
            "CLOSED",
            "REOPENED"});
            this.cboStatus.Location = new System.Drawing.Point(255, 488);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(100, 21);
            this.cboStatus.TabIndex = 14;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboAddDelUpd_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(186, 491);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // cboDev
            // 
            this.cboDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDev.FormattingEnabled = true;
            this.cboDev.Location = new System.Drawing.Point(81, 519);
            this.cboDev.Name = "cboDev";
            this.cboDev.Size = new System.Drawing.Size(99, 21);
            this.cboDev.TabIndex = 14;
            this.cboDev.SelectedIndexChanged += new System.EventHandler(this.cboAddDelUpd_SelectedIndexChanged);
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(12, 522);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(56, 13);
            this.lblDev.TabIndex = 15;
            this.lblDev.Text = "Developer";
            // 
            // cboLead
            // 
            this.cboLead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLead.FormattingEnabled = true;
            this.cboLead.Location = new System.Drawing.Point(255, 522);
            this.cboLead.Name = "cboLead";
            this.cboLead.Size = new System.Drawing.Size(100, 21);
            this.cboLead.TabIndex = 14;
            this.cboLead.SelectedIndexChanged += new System.EventHandler(this.cboAddDelUpd_SelectedIndexChanged);
            // 
            // lblLead
            // 
            this.lblLead.AutoSize = true;
            this.lblLead.Location = new System.Drawing.Point(186, 525);
            this.lblLead.Name = "lblLead";
            this.lblLead.Size = new System.Drawing.Size(55, 13);
            this.lblLead.TabIndex = 15;
            this.lblLead.Text = "Proj Lead:";
            // 
            // btnIssueSubmit
            // 
            this.btnIssueSubmit.Location = new System.Drawing.Point(516, 520);
            this.btnIssueSubmit.Name = "btnIssueSubmit";
            this.btnIssueSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnIssueSubmit.TabIndex = 17;
            this.btnIssueSubmit.Text = "Submit";
            this.btnIssueSubmit.UseVisualStyleBackColor = true;
            this.btnIssueSubmit.Click += new System.EventHandler(this.btnIssueSubmit_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(486, 372);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(162, 39);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "RELOAD GRID";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(458, 439);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(52, 13);
            this.lblRemarks.TabIndex = 15;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(516, 434);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(393, 46);
            this.txtRemarks.TabIndex = 16;
            this.txtRemarks.Text = "";
            // 
            // txtDelIssue
            // 
            this.txtDelIssue.Location = new System.Drawing.Point(15, 455);
            this.txtDelIssue.Name = "txtDelIssue";
            this.txtDelIssue.Size = new System.Drawing.Size(59, 20);
            this.txtDelIssue.TabIndex = 20;
            this.txtDelIssue.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtDelIssue_PreviewKeyDown);
            // 
            // lblDeleteIssue
            // 
            this.lblDeleteIssue.AutoSize = true;
            this.lblDeleteIssue.Location = new System.Drawing.Point(12, 439);
            this.lblDeleteIssue.Name = "lblDeleteIssue";
            this.lblDeleteIssue.Size = new System.Drawing.Size(52, 13);
            this.lblDeleteIssue.TabIndex = 19;
            this.lblDeleteIssue.Text = "Issue No:";
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(81, 453);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 21;
            this.bntDelete.Text = "DEL";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(9, 426);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(108, 13);
            this.lblUpdate.TabIndex = 15;
            this.lblUpdate.Text = "Column to be update:";
            // 
            // cboUpdate
            // 
            this.cboUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdate.FormattingEnabled = true;
            this.cboUpdate.Location = new System.Drawing.Point(12, 442);
            this.cboUpdate.Name = "cboUpdate";
            this.cboUpdate.Size = new System.Drawing.Size(196, 21);
            this.cboUpdate.TabIndex = 22;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(958, 376);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(114, 42);
            this.btnReport.TabIndex = 23;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEnterDetials
            // 
            this.lblEnterDetials.AutoSize = true;
            this.lblEnterDetials.Location = new System.Drawing.Point(9, 410);
            this.lblEnterDetials.Name = "lblEnterDetials";
            this.lblEnterDetials.Size = new System.Drawing.Size(102, 13);
            this.lblEnterDetials.TabIndex = 15;
            this.lblEnterDetials.Text = "Enter Below Details:";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(81, 453);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 24;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.btnUpdateData);
            this.updatePanel.Controls.Add(this.cboUpdateLead);
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Controls.Add(this.label3);
            this.updatePanel.Controls.Add(this.label5);
            this.updatePanel.Controls.Add(this.cboUpdateDev);
            this.updatePanel.Controls.Add(this.lblUpdateRemarks);
            this.updatePanel.Controls.Add(this.lblUpdateIssueDesc);
            this.updatePanel.Controls.Add(this.txtUpdateRemarks);
            this.updatePanel.Controls.Add(this.cboUpdateStatus);
            this.updatePanel.Controls.Add(this.label6);
            this.updatePanel.Controls.Add(this.txtUpdateDesc);
            this.updatePanel.Controls.Add(this.cboUpdateSeverity);
            this.updatePanel.Location = new System.Drawing.Point(12, 410);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(677, 154);
            this.updatePanel.TabIndex = 25;
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(506, 86);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(153, 47);
            this.btnUpdateData.TabIndex = 34;
            this.btnUpdateData.Text = "UPDATE DATA";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // cboUpdateLead
            // 
            this.cboUpdateLead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateLead.FormattingEnabled = true;
            this.cboUpdateLead.Location = new System.Drawing.Point(378, 109);
            this.cboUpdateLead.Name = "cboUpdateLead";
            this.cboUpdateLead.Size = new System.Drawing.Size(117, 21);
            this.cboUpdateLead.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Proj Lead:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Developer";
            // 
            // cboUpdateDev
            // 
            this.cboUpdateDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateDev.FormattingEnabled = true;
            this.cboUpdateDev.Location = new System.Drawing.Point(247, 109);
            this.cboUpdateDev.Name = "cboUpdateDev";
            this.cboUpdateDev.Size = new System.Drawing.Size(120, 21);
            this.cboUpdateDev.TabIndex = 28;
            // 
            // lblUpdateRemarks
            // 
            this.lblUpdateRemarks.AutoSize = true;
            this.lblUpdateRemarks.Location = new System.Drawing.Point(266, 14);
            this.lblUpdateRemarks.Name = "lblUpdateRemarks";
            this.lblUpdateRemarks.Size = new System.Drawing.Size(52, 13);
            this.lblUpdateRemarks.TabIndex = 17;
            this.lblUpdateRemarks.Text = "Remarks:";
            // 
            // lblUpdateIssueDesc
            // 
            this.lblUpdateIssueDesc.AutoSize = true;
            this.lblUpdateIssueDesc.Location = new System.Drawing.Point(4, 13);
            this.lblUpdateIssueDesc.Name = "lblUpdateIssueDesc";
            this.lblUpdateIssueDesc.Size = new System.Drawing.Size(63, 13);
            this.lblUpdateIssueDesc.TabIndex = 17;
            this.lblUpdateIssueDesc.Text = "Issue Desc:";
            // 
            // txtUpdateRemarks
            // 
            this.txtUpdateRemarks.Location = new System.Drawing.Point(263, 27);
            this.txtUpdateRemarks.Name = "txtUpdateRemarks";
            this.txtUpdateRemarks.Size = new System.Drawing.Size(226, 57);
            this.txtUpdateRemarks.TabIndex = 16;
            this.txtUpdateRemarks.Text = "";
            // 
            // cboUpdateStatus
            // 
            this.cboUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateStatus.FormattingEnabled = true;
            this.cboUpdateStatus.Items.AddRange(new object[] {
            "OPEN",
            "CLOSED",
            "REOPENED"});
            this.cboUpdateStatus.Location = new System.Drawing.Point(133, 109);
            this.cboUpdateStatus.Name = "cboUpdateStatus";
            this.cboUpdateStatus.Size = new System.Drawing.Size(100, 21);
            this.cboUpdateStatus.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Severity:";
            // 
            // txtUpdateDesc
            // 
            this.txtUpdateDesc.Location = new System.Drawing.Point(7, 27);
            this.txtUpdateDesc.Name = "txtUpdateDesc";
            this.txtUpdateDesc.Size = new System.Drawing.Size(226, 57);
            this.txtUpdateDesc.TabIndex = 16;
            this.txtUpdateDesc.Text = "";
            // 
            // cboUpdateSeverity
            // 
            this.cboUpdateSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateSeverity.FormattingEnabled = true;
            this.cboUpdateSeverity.Items.AddRange(new object[] {
            "SHOW STOPPER",
            "HIGH",
            "MEDIUM",
            "LOW",
            "COSMETIC"});
            this.cboUpdateSeverity.Location = new System.Drawing.Point(7, 107);
            this.cboUpdateSeverity.Name = "cboUpdateSeverity";
            this.cboUpdateSeverity.Size = new System.Drawing.Size(110, 21);
            this.cboUpdateSeverity.TabIndex = 29;
            // 
            // IssueTrackerMainForm
            // 
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.cboUpdate);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.txtDelIssue);
            this.Controls.Add(this.lblDeleteIssue);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnIssueSubmit);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtIssueDesc);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblLead);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.lblIssueDesc);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblEnterDetials);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboLead);
            this.Controls.Add(this.cboDev);
            this.Controls.Add(this.cboSeverity);
            this.Controls.Add(this.cboAddDelUpd);
            this.Controls.Add(this.lblAddDelUpd);
            this.Controls.Add(this.txtIssueNo);
            this.Controls.Add(this.lblIssueNo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.lblSelectedCR);
            this.Controls.Add(this.lblSelectedProject);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboCR);
            this.Controls.Add(this.lblCR);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboUserNames);
            this.Controls.Add(this.label2);
            this.Name = "IssueTrackerMainForm";
            this.Text = "Issue Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUserNames;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.ComboBox cboCR;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSelectedProject;
        private System.Windows.Forms.Label lblSelectedCR;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtIssueNo;
        private System.Windows.Forms.Button btnRaise;
        private System.Windows.Forms.Label lblIssueNo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.ComboBox cboAddDelUpd;
        private System.Windows.Forms.Label lblAddDelUpd;
        private System.Windows.Forms.Label lblIssueDesc;
        private System.Windows.Forms.RichTextBox txtIssueDesc;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.ComboBox cboSeverity;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboDev;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.ComboBox cboLead;
        private System.Windows.Forms.Label lblLead;
        private System.Windows.Forms.Button btnIssueSubmit;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.TextBox txtDelIssue;
        private System.Windows.Forms.Label lblDeleteIssue;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.ComboBox cboUpdate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblEnterDetials;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label lblUpdateIssueDesc;
        private System.Windows.Forms.RichTextBox txtUpdateDesc;
        private System.Windows.Forms.Label lblUpdateRemarks;
        private System.Windows.Forms.RichTextBox txtUpdateRemarks;
        private System.Windows.Forms.ComboBox cboUpdateLead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboUpdateDev;
        private System.Windows.Forms.ComboBox cboUpdateStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUpdateSeverity;
        private System.Windows.Forms.Button btnUpdateData;
    }
}

