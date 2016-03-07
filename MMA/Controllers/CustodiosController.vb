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
    Public Class CustodiosController
        Inherits System.Web.Mvc.Controller

        Private db As New MMAContext

        ' GET: Custodios
        Function Index() As ActionResult
            Dim custodios = db.Custodios.Include(Function(c) c.Planta)
            Return View(custodios.ToList())
        End Function

        ' GET: Custodios/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim custodio As Custodio = db.Custodios.Find(id)
            If IsNothing(custodio) Then
                Return HttpNotFound()
            End If
            Return View(custodio)
        End Function

        ' GET: Custodios/Create
        Function Create() As ActionResult
            ViewBag.PlantaID = New SelectList(db.Plantas, "PlantaID", "Descripcion")
            Return View()
        End Function

        ' POST: Custodios/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="CustodioID,Indentificacion,Nombre,Apellido1,Apellido2,PlantaID,Telefono,Email")> ByVal custodio As Custodio) As ActionResult
            If ModelState.IsValid Then
                db.Custodios.Add(custodio)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PlantaID = New SelectList(db.Plantas, "PlantaID", "Descripcion", custodio.PlantaID)
            Return View(custodio)
        End Function

        ' GET: Custodios/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim custodio As Custodio = db.Custodios.Find(id)
            If IsNothing(custodio) Then
                Return HttpNotFound()
            End If
            ViewBag.PlantaID = New SelectList(db.Plantas, "PlantaID", "Descripcion", custodio.PlantaID)
            Return View(custodio)
        End Function

        ' POST: Custodios/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="CustodioID,Indentificacion,Nombre,Apellido1,Apellido2,PlantaID,Telefono,Email")> ByVal custodio As Custodio) As ActionResult
            If ModelState.IsValid Then
                db.Entry(custodio).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PlantaID = New SelectList(db.Plantas, "PlantaID", "Descripcion", custodio.PlantaID)
            Return View(custodio)
        End Function

        ' GET: Custodios/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim custodio As Custodio = db.Custodios.Find(id)
            If IsNothing(custodio) Then
                Return HttpNotFound()
            End If
            Return View(custodio)
        End Function

        ' POST: Custodios/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim custodio As Custodio = db.Custodios.Find(id)
            db.Custodios.Remove(custodio)
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
