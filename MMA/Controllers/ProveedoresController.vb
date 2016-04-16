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
    Public Class ProveedoresController
        Inherits System.Web.Mvc.Controller

        Private db As New MMAContext

        ' GET: Proveedores
        Function Index() As ActionResult
            Return View(db.Proveedores.ToList())
        End Function

        ' GET: Proveedores/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim proveedor As Proveedor = db.Proveedores.Find(id)
            If IsNothing(proveedor) Then
                Return HttpNotFound()
            End If
            Return View(proveedor)
        End Function

        ' GET: Proveedores/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Proveedores/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ProveedorID,Descripcion,MontoMax,FechaIngreso")> ByVal proveedor As Proveedor) As ActionResult
            If ModelState.IsValid Then
                db.Proveedores.Add(proveedor)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(proveedor)
        End Function

        ' GET: Proveedores/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim proveedor As Proveedor = db.Proveedores.Find(id)
            If IsNothing(proveedor) Then
                Return HttpNotFound()
            End If
            Return View(proveedor)
        End Function

        ' POST: Proveedores/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ProveedorID,Descripcion,MontoMax,FechaIngreso")> ByVal proveedor As Proveedor) As ActionResult
            If ModelState.IsValid Then
                db.Entry(proveedor).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(proveedor)
        End Function

        ' GET: Proveedores/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim proveedor As Proveedor = db.Proveedores.Find(id)
            If IsNothing(proveedor) Then
                Return HttpNotFound()
            End If
            Return View(proveedor)
        End Function

        ' POST: Proveedores/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim proveedor As Proveedor = db.Proveedores.Find(id)
            db.Proveedores.Remove(proveedor)
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
