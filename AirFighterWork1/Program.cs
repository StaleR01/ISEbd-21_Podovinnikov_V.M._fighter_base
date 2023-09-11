using System.Drawing;

namespace AirFighterWork1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Title1());
        }
    }
}