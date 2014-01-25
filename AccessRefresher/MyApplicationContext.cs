using System;
using System.Windows.Forms;

namespace AccessRefresher
{
    internal class MyApplicationContext : ApplicationContext
    {
        private NotifyIcon notifyIcon;
        public MyApplicationContext()
        {
            MenuItem configMenuItem = new MenuItem("Add Event", new EventHandler(ShowAddEvent));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = AccessRefresher.Properties.Resources.AppIcon;
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] {configMenuItem, exitMenuItem});
            notifyIcon.Visible = true;
        }

        private void ShowAddEvent(object sender, EventArgs e)
        {
            var w = new EditEventForm();
            w.ShowDialog();
        }

        private void Exit(object sender, EventArgs e)
        {
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}
