
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace NHPhuc_QuanLyBanHang.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Donhangchitiet
{

    public string MaDH { get; set; }

    public string Mahang { get; set; }

    public double Dongia { get; set; }

    public Nullable<int> Soluong { get; set; }

    public Nullable<double> Thanhtien { get; set; }



    public virtual Donhang Donhang { get; set; }

    public virtual Hanghoa Hanghoa { get; set; }

}

}
