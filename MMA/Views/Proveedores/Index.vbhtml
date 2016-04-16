@ModelType IEnumerable(Of MMA.Models.Proveedor)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Descripcion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MontoMax)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaIngreso)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Descripcion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MontoMax)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FechaIngreso)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ProveedorID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ProveedorID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ProveedorID })
        </td>
    </tr>
Next

</table>
