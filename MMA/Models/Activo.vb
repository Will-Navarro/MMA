Imports MMA.Models
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Models

    Public Class Activo
        <Key>
        <Display(Name:="ID")>
        <DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property ActivoID As Integer

        <Display(Name:="Código secundario")>
        Public Property CodigoTavo As Integer

        Public Property TipoID As Integer
        Public Overridable Property Tipo As Tipo

        <Display(Name:="Descripción")>
        <DataType(DataType.MultilineText)>
        Public Property Descripcion As String
    End Class
End Namespace
