namespace KutuphaneVeriTabani.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class afafdf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KiralamaDetay", "UyeAdi", c => c.String());
            AddColumn("dbo.KiralamaDetay", "UyeSoyadi", c => c.String());
            AddColumn("dbo.KiralamaDetay", "KitapAdi", c => c.String());
            AddColumn("dbo.KiralamaDetay", "YazarAdi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KiralamaDetay", "YazarAdi");
            DropColumn("dbo.KiralamaDetay", "KitapAdi");
            DropColumn("dbo.KiralamaDetay", "UyeSoyadi");
            DropColumn("dbo.KiralamaDetay", "UyeAdi");
        }
    }
}
