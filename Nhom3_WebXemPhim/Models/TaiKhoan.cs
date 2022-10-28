//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom3_WebXemPhim.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            this.Admins = new HashSet<Admin>();
            this.BinhLuans = new HashSet<BinhLuan>();
            this.ChiTietDonMuaLes = new HashSet<ChiTietDonMuaLe>();
            this.DonMuaGoiPhims = new HashSet<DonMuaGoiPhim>();
            this.DonMuaPhimLes = new HashSet<DonMuaPhimLe>();
            this.KhachHangs = new HashSet<KhachHang>();
            this.LichSuXemPhims = new HashSet<LichSuXemPhim>();
        }
    
        public short MaTaiKhoan { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public Nullable<short> MaLoaiTK { get; set; }
        public Nullable<short> MaPhanQuyen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admin> Admins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonMuaLe> ChiTietDonMuaLes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonMuaGoiPhim> DonMuaGoiPhims { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonMuaPhimLe> DonMuaPhimLes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuXemPhim> LichSuXemPhims { get; set; }
        public virtual LoaiTaiKhoan LoaiTaiKhoan { get; set; }
        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
