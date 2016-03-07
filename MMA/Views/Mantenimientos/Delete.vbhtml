@ModelType MMA.Models.Mantenimiento
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
