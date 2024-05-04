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
    public class ThongKeTheoNCCGridView
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string DVT { get; set; }

        public string TenLoai { get; set; }

        public int MaNhaCC {  get; set; }
        //Lấy tên nhà cung
        public Nullable<decimal> GiaBan { get; set; }
    }
}
