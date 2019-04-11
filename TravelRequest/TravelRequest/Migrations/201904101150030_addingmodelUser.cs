namespace TravelRequest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodelUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_roles_Id = c.Int(),
                        TB_M_Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Role", t => t.TB_M_roles_Id)
                .ForeignKey("dbo.TB_M_User", t => t.TB_M_Users_Id)
                .Index(t => t.TB_M_roles_Id)
                .Index(t => t.TB_M_Users_Id);
            
            CreateTable(
                "dbo.TB_M_Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.Int(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        Password = c.String(),
                        Email = c.String(),
                        Salary = c.Int(nullable: false),
                        Manager_Id = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Departments_Id = c.Int(),
                        TB_M_Jobs_Id = c.Int(),
                        Tb_M_Religions_Id = c.Int(),
                        TB_M_Villages_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Department", t => t.TB_M_Departments_Id)
                .ForeignKey("dbo.TB_M_Job", t => t.TB_M_Jobs_Id)
                .ForeignKey("dbo.TB_M_Religion", t => t.Tb_M_Religions_Id)
                .ForeignKey("dbo.TB_M_Village", t => t.TB_M_Villages_Id)
                .Index(t => t.TB_M_Departments_Id)
                .Index(t => t.TB_M_Jobs_Id)
                .Index(t => t.Tb_M_Religions_Id)
                .Index(t => t.TB_M_Villages_Id);
            
            CreateTable(
                "dbo.TB_M_Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Companies_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Company", t => t.TB_M_Companies_Id)
                .Index(t => t.TB_M_Companies_Id);
            
            CreateTable(
                "dbo.TB_M_Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Job",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Religion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Village",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_SubDistricts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_SubDistrict", t => t.TB_M_SubDistricts_Id)
                .Index(t => t.TB_M_SubDistricts_Id);
            
            CreateTable(
                "dbo.TB_M_SubDistrict",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Districts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_District", t => t.TB_M_Districts_Id)
                .Index(t => t.TB_M_Districts_Id);
            
            CreateTable(
                "dbo.TB_M_District",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Provinces_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Province", t => t.TB_M_Provinces_Id)
                .Index(t => t.TB_M_Provinces_Id);
            
            CreateTable(
                "dbo.TB_M_Province",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Condition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Puposes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Purpose", t => t.TB_M_Puposes_Id)
                .Index(t => t.TB_M_Puposes_Id);
            
            CreateTable(
                "dbo.TB_M_Purpose",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_SalesOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_TravelBy",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_TravelRequest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Notes = c.String(),
                        RequestDate = c.DateTime(nullable: false),
                        Derpature = c.DateTime(nullable: false),
                        Return = c.DateTime(nullable: false),
                        Ticket = c.String(),
                        CarRental = c.String(),
                        PaymentMessage = c.String(),
                        Status = c.String(),
                        Wages = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Conditions_Id = c.Int(),
                        TB_M_Districts_Id = c.Int(),
                        TB_M_SalesOrders_Id = c.Int(),
                        TB_M_TravelBy_Id = c.Int(),
                        TB_M_Users_Id = c.Int(),
                        TB_T_AdvancePayments_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Condition", t => t.TB_M_Conditions_Id)
                .ForeignKey("dbo.TB_M_District", t => t.TB_M_Districts_Id)
                .ForeignKey("dbo.TB_M_SalesOrder", t => t.TB_M_SalesOrders_Id)
                .ForeignKey("dbo.TB_M_TravelBy", t => t.TB_M_TravelBy_Id)
                .ForeignKey("dbo.TB_M_User", t => t.TB_M_Users_Id)
                .ForeignKey("dbo.TB_T_AdvancePayment", t => t.TB_T_AdvancePayments_Id)
                .Index(t => t.TB_M_Conditions_Id)
                .Index(t => t.TB_M_Districts_Id)
                .Index(t => t.TB_M_SalesOrders_Id)
                .Index(t => t.TB_M_TravelBy_Id)
                .Index(t => t.TB_M_Users_Id)
                .Index(t => t.TB_T_AdvancePayments_Id);
            
            CreateTable(
                "dbo.TB_T_AdvancePayment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_TravelRequest", "TB_T_AdvancePayments_Id", "dbo.TB_T_AdvancePayment");
            DropForeignKey("dbo.TB_M_TravelRequest", "TB_M_Users_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_M_TravelRequest", "TB_M_TravelBy_Id", "dbo.TB_M_TravelBy");
            DropForeignKey("dbo.TB_M_TravelRequest", "TB_M_SalesOrders_Id", "dbo.TB_M_SalesOrder");
            DropForeignKey("dbo.TB_M_TravelRequest", "TB_M_Districts_Id", "dbo.TB_M_District");
            DropForeignKey("dbo.TB_M_TravelRequest", "TB_M_Conditions_Id", "dbo.TB_M_Condition");
            DropForeignKey("dbo.TB_M_Condition", "TB_M_Puposes_Id", "dbo.TB_M_Purpose");
            DropForeignKey("dbo.TB_M_Account", "TB_M_Users_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_M_User", "TB_M_Villages_Id", "dbo.TB_M_Village");
            DropForeignKey("dbo.TB_M_Village", "TB_M_SubDistricts_Id", "dbo.TB_M_SubDistrict");
            DropForeignKey("dbo.TB_M_SubDistrict", "TB_M_Districts_Id", "dbo.TB_M_District");
            DropForeignKey("dbo.TB_M_District", "TB_M_Provinces_Id", "dbo.TB_M_Province");
            DropForeignKey("dbo.TB_M_User", "Tb_M_Religions_Id", "dbo.TB_M_Religion");
            DropForeignKey("dbo.TB_M_User", "TB_M_Jobs_Id", "dbo.TB_M_Job");
            DropForeignKey("dbo.TB_M_User", "TB_M_Departments_Id", "dbo.TB_M_Department");
            DropForeignKey("dbo.TB_M_Department", "TB_M_Companies_Id", "dbo.TB_M_Company");
            DropForeignKey("dbo.TB_M_Account", "TB_M_roles_Id", "dbo.TB_M_Role");
            DropIndex("dbo.TB_M_TravelRequest", new[] { "TB_T_AdvancePayments_Id" });
            DropIndex("dbo.TB_M_TravelRequest", new[] { "TB_M_Users_Id" });
            DropIndex("dbo.TB_M_TravelRequest", new[] { "TB_M_TravelBy_Id" });
            DropIndex("dbo.TB_M_TravelRequest", new[] { "TB_M_SalesOrders_Id" });
            DropIndex("dbo.TB_M_TravelRequest", new[] { "TB_M_Districts_Id" });
            DropIndex("dbo.TB_M_TravelRequest", new[] { "TB_M_Conditions_Id" });
            DropIndex("dbo.TB_M_Condition", new[] { "TB_M_Puposes_Id" });
            DropIndex("dbo.TB_M_District", new[] { "TB_M_Provinces_Id" });
            DropIndex("dbo.TB_M_SubDistrict", new[] { "TB_M_Districts_Id" });
            DropIndex("dbo.TB_M_Village", new[] { "TB_M_SubDistricts_Id" });
            DropIndex("dbo.TB_M_Department", new[] { "TB_M_Companies_Id" });
            DropIndex("dbo.TB_M_User", new[] { "TB_M_Villages_Id" });
            DropIndex("dbo.TB_M_User", new[] { "Tb_M_Religions_Id" });
            DropIndex("dbo.TB_M_User", new[] { "TB_M_Jobs_Id" });
            DropIndex("dbo.TB_M_User", new[] { "TB_M_Departments_Id" });
            DropIndex("dbo.TB_M_Account", new[] { "TB_M_Users_Id" });
            DropIndex("dbo.TB_M_Account", new[] { "TB_M_roles_Id" });
            DropTable("dbo.TB_T_AdvancePayment");
            DropTable("dbo.TB_M_TravelRequest");
            DropTable("dbo.TB_M_TravelBy");
            DropTable("dbo.TB_M_SalesOrder");
            DropTable("dbo.TB_M_Purpose");
            DropTable("dbo.TB_M_Condition");
            DropTable("dbo.TB_M_Province");
            DropTable("dbo.TB_M_District");
            DropTable("dbo.TB_M_SubDistrict");
            DropTable("dbo.TB_M_Village");
            DropTable("dbo.TB_M_Religion");
            DropTable("dbo.TB_M_Job");
            DropTable("dbo.TB_M_Company");
            DropTable("dbo.TB_M_Department");
            DropTable("dbo.TB_M_User");
            DropTable("dbo.TB_M_Role");
            DropTable("dbo.TB_M_Account");
        }
    }
}
