@ModelType IEnumerable(Of MMA.Models.Custodio)
@Code
    ViewData("Title") = "Custodios"
End Code

<h2>Custodios</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Planta.Descripcion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Indentificacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Apellido1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Apellido2)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Planta.Descripcion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Indentificacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Apellido1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Apellido2)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Telefono)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Email)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.CustodioID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.CustodioID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.CustodioID })
        </td>
    </tr>
Next

</table>
