namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovaMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Produto", "Preco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "Preco", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Produto", "Valor");
        }
    }
}
