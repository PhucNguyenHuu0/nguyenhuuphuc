
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
    
public partial class Loaihang
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Loaihang()
    {

        this.Hanghoa = new HashSet<Hanghoa>();

    }


    public string Maloai { get; set; }

    public string Tenloai { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Hanghoa> Hanghoa { get; set; }

}

}
