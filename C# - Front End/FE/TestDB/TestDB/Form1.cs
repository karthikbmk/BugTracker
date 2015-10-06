using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using connectDBNameSpace;
using System.Text.RegularExpressions;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace TestDB
{
    public partial class IssueTrackerMainForm : Form
    {
        public DataTable dtx;
        public IssueTrackerMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hide Top-Right labels first 

            txtDelIssue.Visible = false;
            dtGridView.ReadOnly = true;
            btnReport.Visible = false;
            bntDelete.Visible = false;
            lblDeleteIssue.Visible = false;
            btnReload.Visible = false;
            lblDev.Visible = false;
            btnIssueSubmit.Visible = false;
            lblDev.Visible = false;
            lblLead.Visible = false;
            cboDev.Visible = false;
            cboLead.Visible = false;
            lblRemarks.Visible = false;
            txtRemarks.Visible = false;
            lblSeverity.Visible = false;
            cboSeverity.Visible = false;
            txtIssueDesc.Visible = false;
            lblWelcome.Visible = false;
            lblSelectedProject.Visible = false;
            lblSelectedCR.Visible = false;
            dtGridView.Visible = false;
            btnADD.Visible = false;
            btnDelete.Visible = false;
            btnBack.Visible = false;
            btnUpdate.Visible = false;
            lblIssueNo.Visible = false;
            txtIssueNo.Visible = false;
            btnRaise.Visible = false;
            lblAddDelUpd.Visible = false;
            cboAddDelUpd.Visible = false;
            lblEnterDetials.Visible = false;
            lblIssueDesc.Visible = false;
            lblStatus.Visible = false;
            cboStatus.Visible = false;
            lblUpdate.Visible = false;
            cboUpdate.Visible = false;
            btnFetch.Visible = false;
            updatePanel.Visible = false;
            //Hide Top-Right labels first

            ConnectDBClass DBconnect = new ConnectDBClass();
            //Populate UserName cboBox [START].                       
            DBconnect.open();
            SqlDataReader sDR;
            sDR = DBconnect.ExecuteQuery("Exec master..getnames");
            while (sDR.Read())
            {
                cboUserNames.Items.Add(sDR.GetValue(0));
            }
            DBconnect.close();
            sDR = null;
            //Populate UserName cboBox [END].

            //Populate ProjectList cboBox [START].
            DBconnect.open();
            sDR = DBconnect.ExecuteQuery("Exec master..getProjects");
            while (sDR.Read())
            {
                cboProject.Items.Add(sDR.GetValue(0));
            }
            DBconnect.close();
            sDR = null;
            //Populate ProjectList cboBox [END].
        }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Populate Enhancemnet cboBox [START].
            cboCR.Items.Clear();
            ConnectDBClass DBconnect = new ConnectDBClass();
            DBconnect.open();
            SqlDataReader sDR;
            sDR = DBconnect.ExecuteQuery("Exec master..getProjectCRs" + " '" + cboProject.SelectedItem + "'");
            while (sDR.Read())
            {
                cboCR.Items.Add(sDR.GetValue(0));
            }
            DBconnect.close();
            sDR = null;
            //Populate Enhancemnet cboBox [END].
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboUserNames.SelectedItem != null && cboProject.SelectedItem != null)
            {
                btnReport.Visible = true;
            }
            if (cboUserNames.SelectedItem == null && cboProject.SelectedItem == null)
            {
                MessageBox.Show("Select your Name and project");
            }
            else if (cboUserNames.SelectedItem == null && !(cboProject.SelectedItem == null))
            {
                MessageBox.Show("Select your Name");
            }
            else if ((!(cboUserNames.SelectedItem == null)) && cboProject.SelectedItem == null)
            {
                MessageBox.Show("Select your Project");
            }
            else
            {
                //Remove everything , once success                
                cboCR.Visible = false;
                cboProject.Visible = false;
                cboUserNames.Visible = false;
                dtGridView.Visible = true;
                btnReload.Visible = true;
                dtGridView.ReadOnly = true;
                btnFetch.Visible = false;


                lblAddDelUpd.Visible = true;
                cboAddDelUpd.Visible = true;

                lblCR.Visible = false;
                lblName.Visible = false;
                lblProject.Visible = false;

                btnSubmit.Visible = false;

                lblIssueNo.Visible = true;
                txtIssueNo.Visible = true;
                btnRaise.Visible = true;
                //Remove everything , once success

                //Populate top right labels ,once success
                lblWelcome.Text = "User     ::" + cboUserNames.SelectedItem;
                lblWelcome.Visible = true;

                lblSelectedProject.Text = "Project ::" + cboProject.SelectedItem;
                lblSelectedProject.Visible = true;

                if (cboCR.SelectedItem != null)
                {
                    lblSelectedCR.Text = "CR         ::" + cboCR.SelectedItem;
                }
                else
                {
                    lblSelectedCR.Text = "CR         ::" + "None";
                }
                lblSelectedCR.Visible = true;
                //Populate top right labels ,once success

                //Populate Enhancemnet cboBox [START].                
                fillGrid();
                //Populate Enhancemnet cboBox [END].

                //show btns                
                btnBack.Visible = true;
                //show btns


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnADD.Visible = false;
            btnReport.Visible = false;
            btnDelete.Visible = false;
            btnBack.Visible = false;
            btnUpdate.Visible = false;
            dtGridView.Visible = false;
            lblUpdate.Visible = false;
            cboUpdate.Visible = false;
            dtGridView.ReadOnly = true;
            btnFetch.Visible = false;
            updatePanel.Visible = false;

            txtDelIssue.Visible = false;
            bntDelete.Visible = false;
            lblDeleteIssue.Visible = false;

            lblAddDelUpd.Visible = false;
            cboAddDelUpd.Visible = false;

            lblSelectedCR.Visible = false;
            lblSelectedProject.Visible = false;
            lblWelcome.Visible = false;

            lblName.Visible = true;
            lblProject.Visible = true;
            lblCR.Visible = true;

            cboCR.Visible = true;
            cboProject.Visible = true;
            cboUserNames.Visible = true;
            btnSubmit.Visible = true;

            lblIssueNo.Visible = false;
            txtIssueNo.Visible = false;
            btnRaise.Visible = false;
            lblEnterDetials.Visible = false;
            lblIssueDesc.Visible = false;
            txtIssueDesc.Visible = false;
            lblSeverity.Visible = false;
            cboSeverity.Visible = false;
            lblStatus.Visible = false;
            cboStatus.Visible = false;

            lblDev.Visible = false;
            lblLead.Visible = false;
            cboDev.Visible = false;
            cboLead.Visible = false;
            btnIssueSubmit.Visible = false;
            btnReload.Visible = false;

            lblRemarks.Visible = false;
            txtRemarks.Visible = false;
        }

        private void cboAddDelUpd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAddDelUpd.SelectedItem.Equals("ADD"))
            {
                lblEnterDetials.Visible = true;
                lblIssueDesc.Visible = true;
                txtIssueDesc.Visible = true;
                lblSeverity.Visible = true;
                cboSeverity.Visible = true;
                lblStatus.Visible = true;
                cboStatus.Visible = true;
                lblUpdate.Visible = false;
                cboUpdate.Visible = false;
                dtGridView.ReadOnly = true;
                btnFetch.Visible = false;
                updatePanel.Visible = false;

                txtDelIssue.Visible = false;
                bntDelete.Visible = false;
                lblDeleteIssue.Visible = false;

                btnIssueSubmit.Visible = true;

                lblDev.Visible = true;
                lblLead.Visible = true;
                cboDev.Visible = true;
                cboLead.Visible = true;

                lblRemarks.Visible = true;
                txtRemarks.Visible = true;

                //Populate Lead cboBox [START].
                if (cboLead.Items.Count == 0 && cboDev.Items.Count == 0)
                {
                    cboLead.Items.Clear();
                    ConnectDBClass DBconnect = new ConnectDBClass();
                    DBconnect.open();
                    SqlDataReader sDR;
                    sDR = DBconnect.ExecuteQuery("Exec master..getLeads");
                    while (sDR.Read())
                    {
                        cboLead.Items.Add(sDR.GetValue(0));
                        cboUpdateLead.Items.Add(sDR.GetValue(0));
                    }
                    DBconnect.close();
                    sDR = null;
                    //Populate Lead cboBox [END].

                    //Populate Resource cboBox [START].
                    cboDev.Items.Clear();
                    DBconnect.open();
                    sDR = DBconnect.ExecuteQuery("Exec master..getResources");
                    while (sDR.Read())
                    {
                        cboDev.Items.Add(sDR.GetValue(0));
                        cboUpdateDev.Items.Add(sDR.GetValue(0));
                    }
                    DBconnect.close();
                    sDR = null;
                }
                //Populate Resource cboBox [END].

            }
            else if (cboAddDelUpd.SelectedItem.Equals("DELETE"))
            {
                lblEnterDetials.Visible = true;
                lblIssueDesc.Visible = false;
                txtIssueDesc.Visible = false;
                lblSeverity.Visible = false;
                cboSeverity.Visible = false;
                lblStatus.Visible = false;
                cboStatus.Visible = false;
                lblUpdate.Visible = false;
                cboUpdate.Visible = false;
                dtGridView.ReadOnly = true;
                btnFetch.Visible = false;
                updatePanel.Visible = false;

                btnIssueSubmit.Visible = false;

                lblDev.Visible = false;
                lblLead.Visible = false;
                cboDev.Visible = false;
                cboLead.Visible = false;

                lblRemarks.Visible = false;
                txtRemarks.Visible = false;

                txtDelIssue.Visible = true;
                bntDelete.Visible = true;
                lblDeleteIssue.Visible = true;
            }
            else if (cboAddDelUpd.SelectedItem.Equals("UPDATE"))
            {
                lblEnterDetials.Visible = false;
                // lblUpdate.Visible = true;
                lblIssueDesc.Visible = false;
                txtIssueDesc.Visible = false;
                lblSeverity.Visible = false;
                cboSeverity.Visible = false;
                lblStatus.Visible = false;
                cboStatus.Visible = false;
                //cboUpdate.Visible = true;
                dtGridView.ReadOnly = true;

                btnIssueSubmit.Visible = false;

                lblDev.Visible = false;
                lblLead.Visible = false;
                cboDev.Visible = false;
                cboLead.Visible = false;

                lblRemarks.Visible = false;
                txtRemarks.Visible = false;

                txtDelIssue.Visible = true;
                bntDelete.Visible = false;
                lblDeleteIssue.Visible = true;
                btnFetch.Visible = true;

                //Populate Update cboBox [START].      
                if (cboUpdate.Items.Count == 0)
                {
                    ConnectDBClass DBconnect = new ConnectDBClass();
                    DBconnect.open();
                    SqlDataReader sDR;
                    sDR = DBconnect.ExecuteQuery("exec master..cboUpdate");
                    while (sDR.Read())
                    {
                        cboUpdate.Items.Add(sDR.GetValue(0));
                    }
                    DBconnect.close();
                    sDR = null;
                }
                //Populate Update cboBox [END].
            }
        }

        private void btnIssueSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cboDev.SelectedItem == null || cboDev.SelectedItem.Equals(String.Empty)) && (cboLead.SelectedItem == null || cboLead.SelectedItem.Equals(String.Empty)))
                {
                    MessageBox.Show("Select Developer & Lead from comboBox");
                }
                else if ((cboDev.SelectedItem == null || cboDev.SelectedItem.Equals(String.Empty)) && !(cboLead.SelectedItem == null || cboLead.SelectedItem.Equals(String.Empty)))
                {
                    MessageBox.Show("Select Developer from comboBox");
                }
                else if (!(cboDev.SelectedItem == null || cboDev.SelectedItem.Equals(String.Empty)) && (cboLead.SelectedItem == null || cboLead.SelectedItem.Equals(String.Empty)))
                {
                    MessageBox.Show("Select Lead from comboBox");
                }
                else
                {
                    ConnectDBClass DBconnect = new ConnectDBClass();
                    DBconnect.open();
                    SqlDataReader sDR;
                    String parms;
                    txtIssueDesc.Text = txtIssueDesc.Text.Replace("'", "''");
                    txtRemarks.Text = txtRemarks.Text.Replace("'", "''");
                    parms = " '" + cboProject.SelectedItem + "','" + cboCR.SelectedItem + "','" + txtIssueDesc.Text + "','" + cboSeverity.SelectedItem + "','" + cboStatus.SelectedItem + "','" + cboDev.SelectedItem + "','" + cboUserNames.SelectedItem + "','" + cboLead.SelectedItem + "','" + txtRemarks.Text + "'";
                    sDR = DBconnect.ExecuteQuery("Exec master..issueInsert" + parms);
                    sDR.Read();
                    MessageBox.Show(sDR.GetValue(0).ToString());
                    DBconnect.close();
                    sDR = null;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Issue all values");
                //mailerNameSpace.mailClass.sendMail("issueLogger.fti@gmail.com", "mnbzxc12", "karthikbm2007@gmail.com", "IssueLogger Exception :: Submit at Issue ADD",("Time: "+ System.DateTime.Now+"\n"+ e1.Message), "smtp.gmail.com", 587);
            }

        }
        public void fillGrid()
        {
            //Populate Enhancemnet cboBox [START].                
            ConnectDBClass DBconnect = new ConnectDBClass();
            DBconnect.open();
            SqlDataReader sDR;
            sDR = DBconnect.ExecuteQuery("exec master..issuelogRead" + " '" + cboProject.SelectedItem + "','" + cboCR.SelectedItem + "'");
            using (sDR)
            {
                DataTable table = new DataTable();
                table.Load(sDR);
                dtGridView.DataSource = table;
                dtx = DeepClone(table);
            }
            DBconnect.close();
            sDR = null;
            //Populate Enhancemnet cboBox [END].
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void txtDelIssue_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!(Regex.IsMatch(txtDelIssue.Text, "^[0-9]+$")))
            {
                txtDelIssue.Text = "";
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            //Populate Enhancemnet cboBox [START].                
            ConnectDBClass DBconnect = new ConnectDBClass();
            DBconnect.open();
            SqlDataReader sDR;
            txtDelIssue.Text = txtDelIssue.Text.Replace("'", "''");
            sDR = DBconnect.ExecuteQuery("exec master..issuelogDel" + " '" + txtDelIssue.Text + "','" + cboProject.SelectedItem + "'");
            sDR.Read();
            MessageBox.Show(sDR.GetValue(0).ToString());
            DBconnect.close();
            sDR = null;
            //Populate Enhancemnet cboBox [END].
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(outlook);
            t.Start();            
            
        }
        private void outlook()
        {
            CheckForIllegalCrossThreadCalls = false;
            //Populate Enhancemnet cboBox [START].                
            ConnectDBClass DBconnect = new ConnectDBClass();
            DBconnect.open();
            SqlDataReader sDR;
            txtIssueNo.Text = txtIssueNo.Text.Replace("'", "''");
            sDR = DBconnect.ExecuteQuery("exec master..getRaiseIssueDetails" + " '" + txtIssueNo.Text + "'");
            bool sendMail;
            String emailContent = "";
            string header = "";
            string content = "";
            header = "<table border=\"1\"><font color = \"Green\"><b><tr><td>ISSUE ID</td><td>PROJECT NAME</td><td>CR NAME</td><td>ISSUE DESC</td><td>SEVERITY</td><td>STATUS</td><td>REMARKS</td></tr></font></b>";
            //</table>
            while (sDR.Read())
            {
                if (sDR.GetValue(1).ToString().Equals("NNN"))
                {
                    sendMail = false;
                    MessageBox.Show(sDR.GetValue(0).ToString());
                    break;
                }
                else
                {
                    content = "<tr><td>" + sDR.GetValue(0).ToString() + "</td><td>" + sDR.GetValue(1).ToString() + "</td><td>" + sDR.GetValue(2).ToString() + "</td><td>" + sDR.GetValue(3).ToString() + "</td><td>" + sDR.GetValue(4).ToString() + "</td><td>" + sDR.GetValue(5).ToString() + "</td><td>" + sDR.GetValue(7).ToString() + "</td></tr></table>";
                    header = "Hi " + sDR.GetValue(6).ToString() + ",<br><br>Please Look into the below issue :: <br><br> " + header;
                    //Populate Enhancemnet cboBox [START].                
                    ConnectDBClass DBconnect2 = new ConnectDBClass();
                    DBconnect2.open();
                    SqlDataReader sDR2;
                    sDR2 = DBconnect2.ExecuteQuery("exec master..getMailingList" + "'" + sDR.GetValue(6).ToString() + "','" + sDR.GetValue(8).ToString() + "'");
                    String mailList = "";
                    String to;
                    String cc;
                    while (sDR2.Read())
                    {
                        mailList += sDR2.GetValue(0).ToString() + "~";
                    }
                    String[] mailPeople = mailList.Split('~');
                    DBconnect2.close();
                    sDR2 = null;
                    //Populate Enhancemnet cboBox [END].
                    if (cboCR.SelectedItem == null || cboCR.SelectedItem.Equals(String.Empty))
                    {
                        openOutlook(mailPeople[0], (mailPeople[1] + ";" + mailPeople[2]), "IssueLogger :: " + cboProject.SelectedItem, header + content);
                    }
                    else
                    {
                        openOutlook(mailPeople[0], (mailPeople[1] + ";" + mailPeople[2]), "IssueLogger :: " + cboProject.SelectedItem + " :: " + cboCR.SelectedItem, header + content);
                    }
                }
            }
            DBconnect.close();
            sDR = null;
        }
        //Populate Enhancemnet cboBox [END].
        public void openOutlook(String To, String cc, String subject, String content)
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = To;
            oMailItem.CC = cc;
            oMailItem.Subject = subject;
            oMailItem.HTMLBody = content;
            oMailItem.Display(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteToExcel.Excel_FromDataTable(dtx);
            MessageBox.Show("Report Generated.");
            dtx = null;
        }
        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            //Populate Enhancemnet cboBox [START].                
            ConnectDBClass DBconnect = new ConnectDBClass();
            DBconnect.open();
            SqlDataReader sDR;
            sDR = DBconnect.ExecuteQuery("exec master..updateIssueLog" + " '" + txtDelIssue.Text.Replace("'", "''") + "','" + cboProject.SelectedItem + "','" + cboCR.SelectedItem + "'");
            sDR.Read();
            if ((sDR.GetValue(0).ToString().Equals("valid")))
            {
                sDR.NextResult();
                sDR.Read();
                txtUpdateDesc.Text = sDR.GetValue(0).ToString();
                txtUpdateRemarks.Text = sDR.GetValue(6).ToString();
                lblDeleteIssue.Visible = false;
                btnFetch.Visible = false;
                txtDelIssue.Visible = false;
                updatePanel.Visible = true;
                //Populate Lead cboBox [START].
                if (cboUpdateDev.Items.Count == 0 && cboUpdateLead.Items.Count == 0)
                {
                    cboUpdateLead.Items.Clear();
                    ConnectDBClass DBconnect3 = new ConnectDBClass();
                    DBconnect3.open();
                    SqlDataReader sDR2;
                    sDR2 = DBconnect3.ExecuteQuery("Exec master..getLeads");
                    while (sDR2.Read())
                    {
                        cboUpdateLead.Items.Add(sDR2.GetValue(0));
                    }
                    DBconnect3.close();
                    sDR2 = null;
                    //Populate Lead cboBox [END].
                    //Populate Resource cboBox [START].
                    cboUpdateDev.Items.Clear();
                    DBconnect3.open();
                    sDR2 = DBconnect3.ExecuteQuery("Exec master..getResources");
                    while (sDR2.Read())
                    {
                        cboUpdateDev.Items.Add(sDR2.GetValue(0));
                    }
                    DBconnect3.close();
                    sDR2 = null;
                }
                cboUpdateDev.SelectedItem = sDR.GetValue(3).ToString();
                cboUpdateLead.SelectedItem = sDR.GetValue(5).ToString();
                cboUpdateSeverity.SelectedItem = sDR.GetValue(1).ToString();
                cboUpdateStatus.SelectedItem = sDR.GetValue(2).ToString();
            }
            else
            {
                MessageBox.Show(sDR.GetValue(0).ToString());
            }
            DBconnect.close();
            sDR = null;
            //Populate Enhancemnet cboBox [END].
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            //Populate Enhancemnet cboBox [START].                
            ConnectDBClass DBconnect = new ConnectDBClass();
            DBconnect.open();
            SqlDataReader sDR;
            txtDelIssue.Text = txtDelIssue.Text.Replace("'", "''");
            sDR = DBconnect.ExecuteQuery("exec master..UpdateTheLog" + " '" + txtDelIssue.Text + "','" + txtUpdateDesc.Text.Replace("'", "''") + "','" + cboUpdateSeverity.SelectedItem + "','" + cboUpdateStatus.SelectedItem + "','" + cboUpdateDev.SelectedItem + "','" + cboUserNames.SelectedItem + "','" + cboUpdateLead.SelectedItem + "','" + txtUpdateRemarks.Text.Replace("'", "''") + "'");
            sDR.Read();
            MessageBox.Show(sDR.GetValue(0).ToString());
            DBconnect.close();
            sDR = null;
            //Populate Enhancemnet cboBox [END].


        }
    }
}
