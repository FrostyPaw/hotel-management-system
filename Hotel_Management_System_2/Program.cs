using Hotel_Management_System_2.Services;
using Hotel_Management_System_2.Forms;

namespace Hotel_Management_System_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Creation of JSON storage
            var storage = new FileDataStorage();

            // Creation of guest manager
            var guestManager = new GuestManager(storage);

            // Transfer of GuestManager to main window
            Application.Run(new MainForm(guestManager));
        }
    }
}
