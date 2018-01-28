using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
using System.Data;

namespace UserManagement
{
    public class UserMgmtSetup
    {
        string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Forbes\source\repos\AccessDB";// & Application.StartupPath + "\AdminDatabase.accdb";

        OleDbConnection connection;
        OleDbCommand command;
        DataSet datast;
        OleDbDataAdapter adapter;
        BindingSource bindingsrc;
        OleDbDataReader reader;

        string sql;

        DateTime dt = DateTime.Now;
        DateTimeFormatInfo dtfInfo = DateTimeFormatInfo.InvariantInfo;
        string myDay = "dd";
        string myMonth = "MMM";
        string myYear = "yyyy";

        string dtID;
        int accType;
        bool IsFind = false;

    }
}
