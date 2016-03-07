@ModelType IEnumerable(Of MMA.Models.Tipo)
@Code
    ViewData("Title") = "Tipos de activos"
End Code

<h2>Tipos de activos</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Descripcion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Descripcion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.TipoID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.TipoID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.TipoID })
        </td>
    </tr>
Next

</table>
