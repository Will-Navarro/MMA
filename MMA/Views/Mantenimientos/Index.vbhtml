@ModelType IEnumerable(Of MMA.Models.Mantenimiento)
@Code
    ViewData("Title") = "Mantenimientos"
End Code

<h2>Mantenimientos</h2>

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
            @Html.DisplayNameFor(Function(model) model.FechaInicio)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.horaInicio)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaFin)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.horaFin)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TipoMantenimiento)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Estado)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Descripcion)
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
            @Html.DisplayFor(Function(modelItem) item.FechaInicio)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.horaInicio)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FechaFin)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.horaFin)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TipoMantenimiento)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Estado)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Descripcion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MantenimientoID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MantenimientoID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MantenimientoID })
        </td>
    </tr>
Next

</table>
