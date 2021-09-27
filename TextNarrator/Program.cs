#region Using Directives
using System;
using System.Windows.Forms;

using TextNarrator.UI;
#endregion

namespace TextNarrator
{
    /// <summary>
    /// Contains entry point of the application
    /// and initializes the MainForm object ...
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Gets the MainForm object of the application
        /// </summary>
        public static MainForm MainForm { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] static void Main ( ) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( ( MainForm = new MainForm() ) );
        }
    }
}
