namespace EmployeePortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewTable_TUSER : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TUSER",
                c => new
                    {
                        SystemNumber = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        EmailAddress = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.SystemNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TUSER");
        }
    }
}
