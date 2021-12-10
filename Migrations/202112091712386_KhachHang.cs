namespace qlks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 128),
                        MaKH = c.String(),
                        SoTien = c.Single(nullable: false),
                        NgayTT = c.String(),
                        HinhThucTT = c.String(),
                    })
                .PrimaryKey(t => t.MaHD);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        HoTenKH = c.String(),
                        SoDT = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHang");
            DropTable("dbo.HoaDon");
        }
    }
}
