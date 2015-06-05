namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbphone : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pictures", newName: "Picture");
            AlterColumn("dbo.Picture", "PictureBinary", c => c.Binary(nullable: false));
            AlterColumn("dbo.Picture", "MimeType", c => c.String(nullable: false));
            AlterColumn("dbo.Picture", "SeoFilename", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Picture", "SeoFilename", c => c.String());
            AlterColumn("dbo.Picture", "MimeType", c => c.String());
            AlterColumn("dbo.Picture", "PictureBinary", c => c.Binary());
            RenameTable(name: "dbo.Picture", newName: "Pictures");
        }
    }
}
