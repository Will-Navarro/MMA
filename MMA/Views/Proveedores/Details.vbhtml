@ModelType MMA.Models.Proveedor
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ProveedorID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
