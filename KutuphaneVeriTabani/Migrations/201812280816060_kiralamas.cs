namespace KutuphaneVeriTabani.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kiralamas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KiralamaDetay",
                c => new
                    {
                        KitapID = c.Int(nullable: false),
                        UyeID = c.Int(nullable: false),
                        KiralandıgıTarih = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => new { t.KitapID, t.UyeID })
                .ForeignKey("dbo.Kitaplar", t => t.KitapID, cascadeDelete: true)
                .ForeignKey("dbo.Uyeler", t => t.UyeID, cascadeDelete: true)
                .Index(t => t.KitapID)
                .Index(t => t.UyeID);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeID = c.Int(nullable: false, identity: true),
                        UyeAdi = c.String(nullable: false),
                        UyeSoyadi = c.String(nullable: false),
                        UyeTCKN = c.String(nullable: false, maxLength: 11),
                        UyeTel = c.String(nullable: false, maxLength: 11),
                        KitabıVarMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UyeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KiralamaDetay", "UyeID", "dbo.Uyeler");
            DropForeignKey("dbo.KiralamaDetay", "KitapID", "dbo.Kitaplar");
            DropIndex("dbo.KiralamaDetay", new[] { "UyeID" });
            DropIndex("dbo.KiralamaDetay", new[] { "KitapID" });
            DropTable("dbo.Uyeler");
            DropTable("dbo.KiralamaDetay");
        }
    }
}
