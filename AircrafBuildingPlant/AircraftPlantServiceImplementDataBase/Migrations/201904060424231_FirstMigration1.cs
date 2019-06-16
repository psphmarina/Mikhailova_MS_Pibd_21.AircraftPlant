namespace AircraftPlantServiceImplementDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerFIO", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerFIO", c => c.String());
        }
    }
}
