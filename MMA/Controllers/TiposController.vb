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
    Public Class TiposController
        Inherits System.Web.Mvc.Controller

        Private db As New MMAContext

        ' GET: Tipos
        Function Index() As ActionResult
            Return View(db.Tipos.ToList())
        End Function

        ' GET: Tipos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tipo As Tipo = db.Tipos.Find(id)
            If IsNothing(tipo) Then
                Return HttpNotFound()
            End If
            Return View(tipo)
        End Function

        ' GET: Tipos/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Tipos/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="TipoID,Descripcion")> ByVal tipo As Tipo) As ActionResult
            If ModelState.IsValid Then
                db.Tipos.Add(tipo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tipo)
        End Function

        ' GET: Tipos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tipo As Tipo = db.Tipos.Find(id)
            If IsNothing(tipo) Then
                Return HttpNotFound()
            End If
            Return View(tipo)
        End Function

        ' POST: Tipos/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="TipoID,Descripcion")> ByVal tipo As Tipo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tipo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tipo)
        End Function

        ' GET: Tipos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tipo As Tipo = db.Tipos.Find(id)
            If IsNothing(tipo) Then
                Return HttpNotFound()
            End If
            Return View(tipo)
        End Function

        ' POST: Tipos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tipo As Tipo = db.Tipos.Find(id)
            db.Tipos.Remove(tipo)
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
