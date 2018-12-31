namespace KutuphaneVeriTabani.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class degis : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.KiralamaDetay", "UyeAdi");
            DropColumn("dbo.KiralamaDetay", "UyeSoyadi");
            DropColumn("dbo.KiralamaDetay", "KitapAdi");
            DropColumn("dbo.KiralamaDetay", "YazarAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KiralamaDetay", "YazarAdi", c => c.String());
            AddColumn("dbo.KiralamaDetay", "KitapAdi", c => c.String());
            AddColumn("dbo.KiralamaDetay", "UyeSoyadi", c => c.String());
            AddColumn("dbo.KiralamaDetay", "UyeAdi", c => c.String());
        }
    }
}
