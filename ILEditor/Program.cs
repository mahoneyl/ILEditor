﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ILEditor.Forms;
using ILEditor.Classes;

namespace ILEditor
{
    static class Program
    {
        public static readonly string SYSTEMSDIR = "systems";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LicenceKey LicenceInput = new LicenceKey();
            HostSelect Selector = new HostSelect();

            if (!Licence.CheckExistsIsValid())
                Application.Run(LicenceInput);

            if (Licence.CheckExistsIsValid())
            {
                Application.Run(Selector);
                if (Selector.SystemSelected)
                    Application.Run(new Editor());
            }
        }
    }
}