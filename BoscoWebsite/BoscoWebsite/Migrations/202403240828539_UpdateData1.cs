namespace BoscoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Posts", "CreatedBy", c => c.String());
            AddColumn("dbo.tb_Posts", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "ModifierDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "ModifierBy", c => c.String());
            AddColumn("dbo.tb_Product", "ProductCode", c => c.String(maxLength: 50));
            AlterColumn("dbo.tb_Posts", "Alias", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Posts", "Image", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Posts", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Posts", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_Posts", "SeoKeyWords", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "Alias", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "Image", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoKeyWords", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Product", "SeoKeyWords", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Product", "Image", c => c.String());
            AlterColumn("dbo.tb_Product", "Alias", c => c.String());
            AlterColumn("dbo.tb_Posts", "SeoKeyWords", c => c.String());
            AlterColumn("dbo.tb_Posts", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Posts", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Posts", "Image", c => c.String());
            AlterColumn("dbo.tb_Posts", "Alias", c => c.String());
            DropColumn("dbo.tb_Product", "ProductCode");
            DropColumn("dbo.tb_Posts", "ModifierBy");
            DropColumn("dbo.tb_Posts", "ModifierDate");
            DropColumn("dbo.tb_Posts", "CreatedDate");
            DropColumn("dbo.tb_Posts", "CreatedBy");
        }
    }
}
