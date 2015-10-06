using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace connectDBNameSpace
{
    class ConnectDBClass
    {
        public SqlConnection myConnection;
        public void open()
        {
            myConnection = new SqlConnection("Server=localhost;Trusted_Connection=True;");//Change_Me
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                String mailBody = messageBodyBuilder(e);                
                //mailerNameSpace.mailClass.sendMail("issueLogger.fti@gmail.com", "mnbzxc12", "karthikbm2007@gmail.com", "IssueLogger Exception Details", mailBody, "smtp.gmail.com", 587);
            }
        }

        public SqlDataReader ExecuteQuery(String query)
        {
            try
            {

                SqlCommand myCommand = new SqlCommand(query,
                                                 myConnection);
                return myCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                String mailBody = messageBodyBuilder(e);
                //mailerNameSpace.mailClass.sendMail("issueLogger.fti@gmail.com", "mnbzxc12", "karthikbm2007@gmail.com", "IssueLogger Exception Details", mailBody, "smtp.gmail.com", 587);
                return null;
            }

        }

        public void close()
        {
            myConnection.Close();
        }
        public String messageBodyBuilder(Exception e)
        {
            String messageBody = "Hi Karthik,\n";            
            messageBody += "\n--------------EXCEPTION MESSAGE[START]---------------\n" + e.Message + "\n--------------EXCEPTION MESSAGE[END]---------------\n";
            messageBody += "\n--------------STACK TRACE[START]---------------\n" + e.StackTrace + "\n--------------STACK TRACE[END]---------------\n";
            return messageBody;
        }
    }
}
