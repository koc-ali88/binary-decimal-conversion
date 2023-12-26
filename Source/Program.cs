using System;

namespace binary_conversion_guessing_game_cs_version
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());            
        }
    }
}