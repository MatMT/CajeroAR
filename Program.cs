/*
 * DESARROLLO DE HABILIDADES - GUÍA 4 PED104G08L
 * 
 * Oscar Mateo Elías López      - EL232710
 * Javier Enrique Mejía Flores  - MF232724
 * 
 */

namespace CajeroAR
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
            Application.Run(new CajeroAR());
        }
    }
}