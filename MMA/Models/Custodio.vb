Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Custodio
        <DatabaseGenerated(DatabaseGeneratedOption.None)>
        <Display(Name:="AYA ID")>
        Public Property CustodioID As String
        <Display(Name:="ID")>
        Public Property Indentificacion As String
        Public Property Nombre As String
        <Display(Name:="Primer apellido")>
        Public Property Apellido1 As String
        <Display(Name:="Segundo apellido")>
        Public Property Apellido2 As String
        <Display(Name:="Planta")>
        Public Property PlantaID As Integer
        Public Overridable Property Planta As Planta

        <Display(Name:="Teléfono")>
        <DataType(DataType.PhoneNumber)>
        Public Property Telefono As Integer

        <DataType(DataType.EmailAddress)>
        Public Property Email As String
    End Class
End Namespace


