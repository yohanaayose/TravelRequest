namespace TravelRequest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodelUpdatetabel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TB_M_Account", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Account", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Account", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Role", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Role", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Role", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_User", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_User", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_User", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Department", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Department", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Department", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Company", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Company", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Company", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Job", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Job", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Job", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Religion", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Religion", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Religion", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Village", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Village", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Village", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_SubDistrict", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_SubDistrict", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_SubDistrict", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_District", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_District", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_District", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Condition", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Condition", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Condition", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Purpose", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Purpose", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Purpose", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_SalesOrder", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_SalesOrder", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_SalesOrder", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_TravelBy", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_TravelBy", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_TravelBy", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_TravelRequest", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_TravelRequest", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_TravelRequest", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_T_AdvancePayment", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_T_AdvancePayment", "EditDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_T_AdvancePayment", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_T_AdvancePayment", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_T_AdvancePayment", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_T_AdvancePayment", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_TravelRequest", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_TravelRequest", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_TravelRequest", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_TravelBy", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_TravelBy", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_TravelBy", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_SalesOrder", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_SalesOrder", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_SalesOrder", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Purpose", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Purpose", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Purpose", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Condition", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Condition", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Condition", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_District", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_District", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_District", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_SubDistrict", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_SubDistrict", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_SubDistrict", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Village", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Village", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Village", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Religion", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Religion", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Religion", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Job", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Job", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Job", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Company", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Company", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Company", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Department", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Department", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Department", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_User", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_User", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_User", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Role", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Role", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Role", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Account", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Account", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Account", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
