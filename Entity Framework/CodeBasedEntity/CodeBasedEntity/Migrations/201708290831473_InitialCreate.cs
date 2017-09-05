namespace CodeBasedEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Department_ID = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                        Department_Location = c.String(),
                        AddUrl = c.String(),
                    })
                .PrimaryKey(t => t.Department_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departments");
        }
    }
}
