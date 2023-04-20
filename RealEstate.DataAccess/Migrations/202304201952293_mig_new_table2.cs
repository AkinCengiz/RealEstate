namespace RealEstate.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_new_table2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        District = c.String(),
                        Street = c.String(),
                        Town = c.String(),
                        City = c.String(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        Mail1 = c.String(),
                        Mail2 = c.String(),
                        MapInfo = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Subject = c.String(),
                        Mail = c.String(),
                        Description = c.String(),
                        DateInfo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SubTitle = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
            CreateTable(
                "dbo.FeatureServices",
                c => new
                    {
                        FeatureServiceID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageIcon = c.String(),
                    })
                .PrimaryKey(t => t.FeatureServiceID);
            
            CreateTable(
                "dbo.SocialAccounts",
                c => new
                    {
                        SocialAccountID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SocialUrl = c.String(),
                    })
                .PrimaryKey(t => t.SocialAccountID);
            
            CreateTable(
                "dbo.Subscribes",
                c => new
                    {
                        SubscribeID = c.Int(nullable: false, identity: true),
                        Mail = c.String(),
                    })
                .PrimaryKey(t => t.SubscribeID);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Job = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.TestimonialID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
            DropTable("dbo.Subscribes");
            DropTable("dbo.SocialAccounts");
            DropTable("dbo.FeatureServices");
            DropTable("dbo.Features");
            DropTable("dbo.Contacts");
            DropTable("dbo.Addresses");
        }
    }
}
