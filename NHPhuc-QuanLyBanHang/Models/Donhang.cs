
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
    
public partial class Donhang
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Donhang()
    {

        this.Donhangchitiet = new HashSet<Donhangchitiet>();

    }


    public string MaDH { get; set; }

    public Nullable<System.DateTime> Ngaydat { get; set; }

    public Nullable<double> Tongtien { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Donhangchitiet> Donhangchitiet { get; set; }

}

}
