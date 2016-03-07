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
    Public Class TrazabilidadController
        Inherits System.Web.Mvc.Controller

        Private db As New MMAContext

        ' GET: Trazabilidad
        Function Index() As ActionResult
            Dim trazabilidad = db.Trazabilidad.Include(Function(t) t.Activo).Include(Function(t) t.Custodio).Include(Function(t) t.Planta)
            Return View(trazabilidad.ToList())
        End Function

        ' GET: Trazabilidad/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim trazabilidad As Trazabilidad = db.Trazabilidad.Find(id)
            If IsNothing(trazabilidad) Then
                Return HttpNotFound()
            End If
            Return View(trazabilidad)
        End Function

        ' GET: Trazabilidad/Create
        Function Create() As ActionResult
            ViewBag.ActivoID = New SelectList(db.Activos, "ActivoID", "Descripcion")
            ViewBag.CustodioID = New SelectList(db.Custodios, "CustodioID", "Indentificacion")
            ViewBag.PlantaID = New SelectList(db.Plantas, "PlantaID", "Descripcion")
            Return View()
        End Function

        ' POST: Trazabilidad/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="TrazabilidadID,ActivoID,PlantaID,CustodioID")> ByVal trazabilidad As Trazabilidad) As ActionResult
            If ModelState.IsValid Then
                db.Trazabilidad.Add(trazabilidad)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ActivoID = New SelectList(db.Activos, "ActivoID", "Descripcion", trazabilidad.ActivoID)
            ViewBag.CustodioID = New SelectList(db.Custodios, "CustodioID", "Indentificacion", trazabilidad.CustodioID)
            ViewBag.PlantaID = New SelectList(db.Plantas, "PlantaID", "Descripcion", trazabilidad.PlantaID)
            Return View(trazabilidad)
        End Function

        ' GET: Trazabilidad/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim trazabilidad As Trazabilidad = db.Trazabilidad.Find(id)
            If IsNothing(trazabilidad) Then
                Return HttpNotFound()
            End If
            ViewBag.ActivoID = New SelectList(db.Activos, "ActivoID", "Descripcion", trazabilidad.ActivoID)
            ViewBag.CustodioID = New SelectList(db.Custodios, "CustodioID", "Indentificacion", trazabilidad.CustodioID)
            ViewBag.PlantaID = New SelectList(db.Plantas, "PlantaID", "Descripcion", trazabilidad.PlantaID)
            Return View(trazabilidad)
        End Function

        ' POST: Trazabilidad/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="TrazabilidadID,ActivoID,PlantaID,CustodioID")> ByVal trazabilidad As Trazabilidad) As ActionResult
            If ModelState.IsValid Then
                db.Entry(trazabilidad).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ActivoID = New SelectList(db.Activos, "ActivoID", "Descripcion", trazabilidad.ActivoID)
            ViewBag.CustodioID = New SelectList(db.Custodios, "CustodioID", "Indentificacion", trazabilidad.CustodioID)
            ViewBag.PlantaID = New SelectList(db.Plantas, "PlantaID", "Descripcion", trazabilidad.PlantaID)
            Return View(trazabilidad)
        End Function

        ' GET: Trazabilidad/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim trazabilidad As Trazabilidad = db.Trazabilidad.Find(id)
            If IsNothing(trazabilidad) Then
                Return HttpNotFound()
            End If
            Return View(trazabilidad)
        End Function

        ' POST: Trazabilidad/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim trazabilidad As Trazabilidad = db.Trazabilidad.Find(id)
            db.Trazabilidad.Remove(trazabilidad)
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
