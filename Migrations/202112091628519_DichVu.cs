namespace qlks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DichVu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DichVu",
                c => new
                    {
                        MaDV = c.String(nullable: false, maxLength: 128),
                        TenDV = c.String(),
                        DonGiaVN = c.String(),
                    })
                .PrimaryKey(t => t.MaDV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DichVu");
        }
    }
}
