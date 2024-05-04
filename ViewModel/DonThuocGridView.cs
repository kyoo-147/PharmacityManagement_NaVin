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
    public class DonThuocGridView
    {
        public int MaDonThuoc { get; set; }
        public DateTime NgayLapDon { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhachHang { get; set; }
        public string TenChiNhanh { get; set; }

    }

}
