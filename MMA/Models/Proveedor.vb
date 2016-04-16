Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Proveedor
        <DatabaseGenerated(DatabaseGeneratedOption.None)>
        <Display(Name:="ID")>
        Public Property ProveedorID As String
        <Display(Name:="Descripción")>
        Public Property Descripcion As String
        <Display(Name:="Monto máximo")>
        <DataType(DataType.Currency)>
        Public Property MontoMax As Decimal

        <Display(Name:="Fecha de ingreso")>
        <DataType(DataType.Date)>
        Public Property FechaIngreso As Date
    End Class
End Namespace

