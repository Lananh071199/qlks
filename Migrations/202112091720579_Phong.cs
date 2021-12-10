namespace qlks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Phong : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phong",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 128),
                        TenPhong = c.String(),
                        LoaiPhong = c.String(),
                        TrangThai = c.String(),
                        GiaPhong = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phong");
        }
    }
}
