Imports System.Data.Entity

Namespace Models
    
    Public Class MMAContext
        Inherits DbContext
    
        ' You can add custom code to this file. Changes will not be overwritten.
        ' 
        ' If you want Entity Framework to drop and regenerate your database
        ' automatically whenever you change your model schema, please use data migrations.
        ' For more information refer to the documentation:
        ' http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        Public Sub New()
            MyBase.New("name=MMAContext")
        End Sub
    
        Public Property Activos As System.Data.Entity.DbSet(Of Models.Activo)
        Public Property Tipos As System.Data.Entity.DbSet(Of Models.Tipo)
        Public Property Custodios As System.Data.Entity.DbSet(Of Models.Custodio)
        Public Property Plantas As System.Data.Entity.DbSet(Of Models.Planta)
        Public Property Mantenimientos As System.Data.Entity.DbSet(Of Models.Mantenimiento)
        Public Property Proveedores As System.Data.Entity.DbSet(Of Models.Proveedor)
        Public Property Trazabilidad As System.Data.Entity.DbSet(Of Models.Trazabilidad)
    End Class
    
End Namespace
