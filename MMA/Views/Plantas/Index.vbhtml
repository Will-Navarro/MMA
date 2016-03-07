@ModelType IEnumerable(Of MMA.Models.Planta)
@Code
    ViewData("Title") = "Plantas"
End Code

<h2>Plantas</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Descripcion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Descripcion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Telefono)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.PlantaID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PlantaID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PlantaID })
        </td>
    </tr>
Next

</table>
