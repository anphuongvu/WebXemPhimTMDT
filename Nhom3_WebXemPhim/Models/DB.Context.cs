﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLXemPhimEntities : DbContext
    {
        public QLXemPhimEntities()
            : base("name=QLXemPhimEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BanQuyenPhim> BanQuyenPhims { get; set; }
        public virtual DbSet<BinhLuan> BinhLuans { get; set; }
        public virtual DbSet<ChiTietDonMuaLe> ChiTietDonMuaLes { get; set; }
        public virtual DbSet<ChuDe> ChuDes { get; set; }
        public virtual DbSet<ChuDe_Phim> ChuDe_Phim { get; set; }
        public virtual DbSet<DienVien> DienViens { get; set; }
        public virtual DbSet<DonMuaGoiPhim> DonMuaGoiPhims { get; set; }
        public virtual DbSet<DonMuaPhimLe> DonMuaPhimLes { get; set; }
        public virtual DbSet<GoiPhim> GoiPhims { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichSuXemPhim> LichSuXemPhims { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<QuangCao> QuangCaos { get; set; }
        public virtual DbSet<QuocGia> QuocGias { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TapPhim> TapPhims { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<ThongKeDoanhThu> ThongKeDoanhThus { get; set; }
        public virtual DbSet<Trailer> Trailers { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
    }
}