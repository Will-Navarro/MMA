@ModelType MMA.Models.Activo
@Code
    ViewData("Title") = "Detalles"
End Code

<h2>Detalles</h2>

<div>
    <h4>Activo</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Tipo.Descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tipo.Descripcion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CodigoTavo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CodigoTavo)
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
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.ActivoID}) |
    @Html.ActionLink("Regresar", "Index")
</p>
