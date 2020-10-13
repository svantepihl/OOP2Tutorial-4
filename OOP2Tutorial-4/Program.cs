using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Tutorial_4
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ICatalogue catalogue;
            DialogResult answer = MessageBox.Show("Should we enable JSON-persistent catalogues?", "Persistence",
                MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                catalogue = new PersistentCatalogue("products.json");
            }
            else
            {
                catalogue = new Catalogue();
            }
            Application.Run(new Form1(catalogue));
        }
    }
}