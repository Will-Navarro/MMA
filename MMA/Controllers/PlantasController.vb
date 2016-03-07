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
    Public Class PlantasController
        Inherits System.Web.Mvc.Controller

        Private db As New MMAContext

        ' GET: Plantas
        Function Index() As ActionResult
            Return View(db.Plantas.ToList())
        End Function

        ' GET: Plantas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim planta As Planta = db.Plantas.Find(id)
            If IsNothing(planta) Then
                Return HttpNotFound()
            End If
            Return View(planta)
        End Function

        ' GET: Plantas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Plantas/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="PlantaID,Descripcion,Telefono")> ByVal planta As Planta) As ActionResult
            If ModelState.IsValid Then
                db.Plantas.Add(planta)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(planta)
        End Function

        ' GET: Plantas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim planta As Planta = db.Plantas.Find(id)
            If IsNothing(planta) Then
                Return HttpNotFound()
            End If
            Return View(planta)
        End Function

        ' POST: Plantas/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="PlantaID,Descripcion,Telefono")> ByVal planta As Planta) As ActionResult
            If ModelState.IsValid Then
                db.Entry(planta).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(planta)
        End Function

        ' GET: Plantas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim planta As Planta = db.Plantas.Find(id)
            If IsNothing(planta) Then
                Return HttpNotFound()
            End If
            Return View(planta)
        End Function

        ' POST: Plantas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim planta As Planta = db.Plantas.Find(id)
            db.Plantas.Remove(planta)
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
