@ModelType MMA.Models.Trazabilidad
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.TrazabilidadID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
