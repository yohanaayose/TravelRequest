namespace TravelRequest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodelUpdateprovince : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TB_M_Province", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Province", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Province", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_M_Province", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Province", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Province", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
