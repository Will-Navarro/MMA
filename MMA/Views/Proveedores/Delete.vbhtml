﻿@ModelType MMA.Models.Proveedor
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Proveedor</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Descripcion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MontoMax)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MontoMax)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaIngreso)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaIngreso)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
