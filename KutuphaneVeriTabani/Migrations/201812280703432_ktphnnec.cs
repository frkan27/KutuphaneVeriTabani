namespace KutuphaneVeriTabani.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ktphnnec : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapID = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(maxLength: 50),
                        YazarID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapID)
                .ForeignKey("dbo.Yazarlar", t => t.YazarID, cascadeDelete: true)
                .Index(t => t.YazarID);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarID = c.Int(nullable: false, identity: true),
                        YazarAd = c.String(),
                        YazarSoyad = c.String(),
                    })
                .PrimaryKey(t => t.YazarID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "YazarID", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "YazarID" });
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
        }
    }
}
