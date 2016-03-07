Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports MMA.Models

Namespace Controllers
    Public Class MantenimientosController
        Inherits System.Web.Mvc.Controller

        Private db As New MMAContext

        ' GET: Mantenimientos
        Function Index() As ActionResult
            Dim mantenimientos = db.Mantenimientos.Include(Function(m) m.Activo).Include(Function(m) m.Custodio)
            Return View(mantenimientos.ToList())
        End Function

        ' GET: Mantenimientos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mantenimiento As Mantenimiento = db.Mantenimientos.Find(id)
            If IsNothing(mantenimiento) Then
                Return HttpNotFound()
            End If
            Return View(mantenimiento)
        End Function

        ' GET: Mantenimientos/Create
        Function Create() As ActionResult
            ViewBag.ActivoID = New SelectList(db.Activos, "ActivoID", "Descripcion")
            ViewBag.CustodioID = New SelectList(db.Custodios, "CustodioID", "Indentificacion")
            Return View()
        End Function

        ' POST: Mantenimientos/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MantenimientoID,ActivoID,CustodioID,FechaInicio,horaInicio,FechaFin,horaFin,TipoMantenimiento,Estado,Descripcion")> ByVal mantenimiento As Mantenimiento) As ActionResult
            If ModelState.IsValid Then
                db.Mantenimientos.Add(mantenimiento)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ActivoID = New SelectList(db.Activos, "ActivoID", "Descripcion", mantenimiento.ActivoID)
            ViewBag.CustodioID = New SelectList(db.Custodios, "CustodioID", "Indentificacion", mantenimiento.CustodioID)
            Return View(mantenimiento)
        End Function

        ' GET: Mantenimientos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mantenimiento As Mantenimiento = db.Mantenimientos.Find(id)
            If IsNothing(mantenimiento) Then
                Return HttpNotFound()
            End If
            ViewBag.ActivoID = New SelectList(db.Activos, "ActivoID", "Descripcion", mantenimiento.ActivoID)
            ViewBag.CustodioID = New SelectList(db.Custodios, "CustodioID", "Indentificacion", mantenimiento.CustodioID)
            Return View(mantenimiento)
        End Function

        ' POST: Mantenimientos/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MantenimientoID,ActivoID,CustodioID,FechaInicio,horaInicio,FechaFin,horaFin,TipoMantenimiento,Estado,Descripcion")> ByVal mantenimiento As Mantenimiento) As ActionResult
            If ModelState.IsValid Then
                db.Entry(mantenimiento).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ActivoID = New SelectList(db.Activos, "ActivoID", "Descripcion", mantenimiento.ActivoID)
            ViewBag.CustodioID = New SelectList(db.Custodios, "CustodioID", "Indentificacion", mantenimiento.CustodioID)
            Return View(mantenimiento)
        End Function

        ' GET: Mantenimientos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mantenimiento As Mantenimiento = db.Mantenimientos.Find(id)
            If IsNothing(mantenimiento) Then
                Return HttpNotFound()
            End If
            Return View(mantenimiento)
        End Function

        ' POST: Mantenimientos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim mantenimiento As Mantenimiento = db.Mantenimientos.Find(id)
            db.Mantenimientos.Remove(mantenimiento)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
