namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriADToKategoriAdiInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAdi", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriAD");
    

        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriAD", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriAdi");
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.String());
        }
    }
}
