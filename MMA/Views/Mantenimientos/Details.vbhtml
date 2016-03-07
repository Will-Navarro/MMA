@ModelType MMA.Models.Mantenimiento
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Mantenimiento</h4>
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
            @Html.DisplayNameFor(Function(model) model.FechaInicio)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaInicio)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.horaInicio)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.horaInicio)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaFin)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaFin)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.horaFin)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.horaFin)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TipoMantenimiento)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TipoMantenimiento)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Estado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Estado)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Descripcion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.MantenimientoID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
