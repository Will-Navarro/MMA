Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class A3
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.Plantas", "Detalle")
            DropColumn("dbo.Plantas", "Detalle2")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Plantas", "Detalle2", Function(c) c.String())
            AddColumn("dbo.Plantas", "Detalle", Function(c) c.String())
        End Sub
    End Class
End Namespace
