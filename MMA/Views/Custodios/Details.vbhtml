@ModelType MMA.Models.Custodio
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Custodio</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Planta.Descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Planta.Descripcion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Indentificacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Indentificacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Apellido1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Apellido1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Apellido2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Apellido2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Telefono)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.CustodioID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
