
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
    
public partial class Hanghoa
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Hanghoa()
    {

        this.Donhangchitiet = new HashSet<Donhangchitiet>();

    }


    public string Mahang { get; set; }

    public string Tenhang { get; set; }

    public Nullable<double> Dongia { get; set; }

    public Nullable<int> Soluong { get; set; }

    public string Donvitinh { get; set; }

    public string Anh { get; set; }

    public string Maloai { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Donhangchitiet> Donhangchitiet { get; set; }

    public virtual Loaihang Loaihang { get; set; }

}

}
