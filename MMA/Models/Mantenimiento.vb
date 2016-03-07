Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Enum TipoMantenimiento
        Preventivo
        Correctivo
    End Enum
    Public Enum Estado
        Pendiente
        Realizado
    End Enum

    Public Class Mantenimiento
        <Key>
        Public Property MantenimientoID As Integer

        Public Property ActivoID As Integer
        Public Overridable Property Activo As Activo

        Public Property CustodioID As String
        Public Overridable Property Custodio As Custodio

        <Display(Name:="Fecha de inicio")>
        <DataType(DataType.Date)>
        Public Property FechaInicio As Date

        <Display(Name:="Hora de inicio")>
        <DataType(DataType.Time)>
        Public Property horaInicio As String

        <Display(Name:="Fecha de fin")>
        <DataType(DataType.Date)>
        Public Property FechaFin As Date

        <Display(Name:="Hora de Fin")>
        <DataType(DataType.Time)>
        Public Property horaFin As String

        <Display(Name:="Tipo de mantenimiento")>
        Public Property TipoMantenimiento As TipoMantenimiento?

        <Display(Name:="Estado")>
        Public Property Estado As Estado?

        <Display(Name:="Descripción")>
        <DataType(DataType.MultilineText)>
        Public Property Descripcion As String
    End Class
End Namespace

