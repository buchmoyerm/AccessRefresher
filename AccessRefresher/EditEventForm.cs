using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Form = System.Windows.Forms.Form;

namespace AccessRefresher
{
    public partial class EditEventForm : Form
    {
        public EditEventForm()
        {
            InitializeComponent();
        }

        private NetOffice.AccessApi.Application GetApp(string accessFile)
        {
            try
            {
                return new NetOffice.AccessApi.Application(accessFile);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var f = GetApp(txtAccessFile.Text);
        }

        private void txtAccessFile_TextChanged(object sender, EventArgs e)
        {
            var file = txtAccessFile.Text.ToUpper();

            if (file.EndsWith(".ACCDB") ||
                file.EndsWith(".ACCDE") ||
                file.EndsWith(".ACCDT") ||
                file.EndsWith(".ACCDR") ||
                file.EndsWith(".MDB") )
            {
                SetAccessFile(file);
            }
            else
            {
                SetAccessFile("");
            }
        }

        private string _accessFile;
        private void SetAccessFile(string file)
        {
            _accessFile = file;
            var l = GetAccessTableList();
        }

        //use a micro ORM
        //Dapper
        //petapoco
        //massive

        private List<string> GetAccessTableList()
        {
            var tableList = new List<string>();
            if (_accessFile == string.Empty)
            {
                return tableList;
            }

            // Microsoft Access provider factory
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");

            DataTable userTables = null;
            using (DbConnection connection = factory.CreateConnection())
            {
                // c:\test\test.mdb
                connection.ConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}",_accessFile);
                // We only want user tables, not system tables
                string[] restrictions = new string[4];
                restrictions[3] = "Table";

                connection.Open();

                // Get list of user tables
                userTables = connection.GetSchema("Tables", restrictions);
            }

            for (int i = 0; i < userTables.Rows.Count; i++)
                tableList.Add(userTables.Rows[i][2].ToString());

            return tableList;
        }

        /* from
         * http://stackoverflow.com/questions/1096896/how-do-you-access-an-already-running-com-object-using-net-interop
         * 
         */

        //private NetOffice.AccessApi.Application GetInstance(int hWndChild)
        //{
        //    if (hWndChild != 0)
        //    {
                
        //        // OBJID_NATIVEOM gets us a pointer to the native 
        //        // object model.
        //        uint OBJID_NATIVEOM = 0xFFFFFFF0;
        //        Guid IID_IDispatch =
        //            new Guid("{00020400-0000-0000-C000-000000000046}");
        //        NetOffice.AccessApi.Application.DocumentWindow ptr = null;
        //        int hr = Util.WinApi.AccessibleObjectFromWindow(
        //            hWndChild, OBJID_NATIVEOM,
        //            IID_IDispatch.ToByteArray(), ref ptr);
        //        if (hr >= 0)
        //        {
        //            ppt = ptr.Application;
        //            ppt.Visible = Office.MsoTriState.msoTrue;
        //            pptx = ppt.Presentations.Open(
        //                pptxFile,
        //                Office.MsoTriState.msoFalse,
        //                Office.MsoTriState.msoFalse,
        //                Office.MsoTriState.msoTrue);
        //        }
        //    }
        //}
    }
}
