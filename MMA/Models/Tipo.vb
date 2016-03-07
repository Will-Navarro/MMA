Imports System.ComponentModel.DataAnnotations

Namespace Models

    Public Class Tipo
        Public Property TipoID As Integer
        <Display(Name:="Tipo de activo")>
        Public Property Descripcion As String
        <Display(Name:="Tipo de activo")>
        Public Overridable Property Activos As ICollection(Of Activo)


    End Class
End Namespace
