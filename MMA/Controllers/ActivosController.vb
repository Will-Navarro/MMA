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
    Public Class ActivosController
        Inherits System.Web.Mvc.Controller

        Private db As New MMAContext

        ' GET: Activos
        Function Index() As ActionResult
            Dim activos = db.Activos.Include(Function(a) a.Tipo)
            Return View(activos.ToList())
        End Function

        ' GET: Activos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activo As Activo = db.Activos.Find(id)
            If IsNothing(activo) Then
                Return HttpNotFound()
            End If
            Return View(activo)
        End Function

        ' GET: Activos/Create
        Function Create() As ActionResult
            ViewBag.TipoID = New SelectList(db.Tipos, "TipoID", "Descripcion")
            Return View()
        End Function

        ' POST: Activos/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ActivoID,CodigoTavo,TipoID,Descripcion")> ByVal activo As Activo) As ActionResult
            If ModelState.IsValid Then
                db.Activos.Add(activo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.TipoID = New SelectList(db.Tipos, "TipoID", "Descripcion", activo.TipoID)
            Return View(activo)
        End Function

        ' GET: Activos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activo As Activo = db.Activos.Find(id)
            If IsNothing(activo) Then
                Return HttpNotFound()
            End If
            ViewBag.TipoID = New SelectList(db.Tipos, "TipoID", "Descripcion", activo.TipoID)
            Return View(activo)
        End Function

        ' POST: Activos/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ActivoID,CodigoTavo,TipoID,Descripcion")> ByVal activo As Activo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(activo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.TipoID = New SelectList(db.Tipos, "TipoID", "Descripcion", activo.TipoID)
            Return View(activo)
        End Function

        ' GET: Activos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activo As Activo = db.Activos.Find(id)
            If IsNothing(activo) Then
                Return HttpNotFound()
            End If
            Return View(activo)
        End Function

        ' POST: Activos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim activo As Activo = db.Activos.Find(id)
            db.Activos.Remove(activo)
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
