using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace VetClinic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        private static string getDBPath = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).ToString()).ToString();
        // "C:\Users\User\Source\Repos\IvailoA05\VetClinic\VetClinic\VetClinicDB.mdf"
        public static string con = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={getDBPath}\\VetClinicDB.mdf;Integrated Security=True";
        
        public static bool isAdmin = false;
        public static int id = 0;
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new View.frmLogIn());
        }
    }
}