using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetLinqDemo
{
    static class Program
    {
        public static DbContext Context { get { return context; } }
        private static DbContext context;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        // [STAThread]
        static void Main()
        {
            context = new DbContext();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /* new List<dynamic>() {
                new { FName = "Bill", LName = "Gates", Age = 65 },
                new { FName = "John", LName = "Connor", Age = 25 },
                new { FName = "Sarah", LName = "Connor", Age = 40 },
                new { FName = "Иван", LName = "Иванович", Age = 61 },
                new { FName = "Иван", LName = "Степанович", Age = 15 },
                new { FName = "Иван", LName = "Кузьмич", Age = 30 }
            }.Where(p => p.Age < 60)
            .OrderBy(p => p.Age)
            .Skip(1)
            .Take(2)
            .Select(p => $"{p.FName} {p.LName}")
            // .ToList().ForEach(Console.WriteLine);
            .ToList().ForEach(p => MessageBox.Show(p)); */

            /* var result = new List<dynamic>() {
                new { FName = "Bill", LName = "Gates", Age = 65 },
                new { FName = "John", LName = "Connor", Age = 25 },
                new { FName = "Sarah", LName = "Connor", Age = 40 },
                new { FName = "Иван", LName = "Иванович", Age = 61 },
                new { FName = "Иван", LName = "Степанович", Age = 15 },
                new { FName = "Иван", LName = "Кузьмич", Age = 30 }
            }.Where(p => p.Age < 60)
            .OrderBy(p => p.Age)
            .Skip(1)
            .Take(2)
            .Select(p => $"{p.FName} {p.LName}");

            Console.WriteLine(MessageBox.Show(result.ToString())); */
        }
    }
}
