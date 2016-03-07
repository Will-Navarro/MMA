@ModelType IEnumerable(Of MMA.Models.Trazabilidad)
@Code
    ViewData("Title") = "Trazabilidad"
End Code

<h2>Trazabilidad</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Activo.Descripcion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Custodio.Indentificacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Planta.Descripcion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Activo.Descripcion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Custodio.Indentificacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Planta.Descripcion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.TrazabilidadID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.TrazabilidadID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.TrazabilidadID })
        </td>
    </tr>
Next

</table>
