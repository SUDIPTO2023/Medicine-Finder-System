using MedicineLocator.Model;
using MedicineLocator.Controller;
namespace MedicineLocator

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new View.LoginForm());
            //Application.Run(new View.RegisterForm());
            //Application.Run(new View.ClientRegisterForm());
            //Application.Run(new View.MedicineForm());
           // Application.Run(new View.AdminForm());
        }
    }
}