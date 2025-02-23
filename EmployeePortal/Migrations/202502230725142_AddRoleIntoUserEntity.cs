namespace EmployeePortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleIntoUserEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TUSER", "Roles", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TUSER", "Roles");
        }
    }
}
