using QLThuoc.DonThuoc1;
using QLThuoc.ThongKe;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        // # -*- encoding: utf-8 -*-
        // # Copyright NaVin Pharmacity (github link) 2024. All Rights Reserved.
        // #  MIT License  (https://opensource.org/licenses/MIT)
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Call den form login - Final using
            Application.Run(new frmLogin());
            // Call den main app - Tester
            //Application.Run(new frmUser(admin));
        }
    }
}
