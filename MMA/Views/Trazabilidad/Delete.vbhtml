@ModelType MMA.Models.Trazabilidad
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Trazabilidad</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Activo.Descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Activo.Descripcion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Custodio.Indentificacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Custodio.Indentificacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Planta.Descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Planta.Descripcion)
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
