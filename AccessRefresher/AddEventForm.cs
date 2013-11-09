using System;
using System.Windows.Forms;
using NetOffice;
using Form = System.Windows.Forms.Form;

namespace AccessRefresher
{
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();
        }

        private NetOffice.AccessApi.Application GetApp()
        {
            return new NetOffice.AccessApi.Application((NetOffice.AccessApi.Application)System.Runtime.InteropServices.Marshal.BindToMoniker(""));
        }

        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var img = pictureBox1.Image;
            if (img == null) return;
            DoDragDrop(img, DragDropEffects.None);
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
