Imports MMA.Models
Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Trazabilidad
        Public Property TrazabilidadID As Integer
        <Display(Name:="Activo")>
        Public Property ActivoID As Integer
        <Display(Name:="Planta")>
        Public Property PlantaID As Integer
        <Display(Name:="Custodio")>
        Public Property CustodioID As String
        <Display(Name:="Activo")>
        Public Overridable Property Activo As Activo
        <Display(Name:="Planta")>
        Public Overridable Property Planta As Planta
        <Display(Name:="Custodio")>
        Public Overridable Property Custodio As Custodio

    End Class
End Namespace