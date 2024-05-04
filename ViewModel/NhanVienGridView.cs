using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc.ViewModel
{
    public class NhanVienGridView
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgaySinh { get; set; }
    }
}
