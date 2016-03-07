@ModelType IEnumerable(Of MMA.Models.Activo)
@Code
    ViewData("Title") = "Activos"
End Code

<h1 class="page-header">Activos</h1>

<p>
    @Html.ActionLink("Agregar", "Create", Nothing, New With {.class = "btn btn-primary"})
</p>
<div class="panel panel-primary">
    <!-- Default panel contents -->
    <div class="panel-heading">Detalles</div>

    <!-- Table -->
    <table class="table table-hover">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.ActivoID)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Tipo.Descripcion)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.CodigoTavo)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Descripcion)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                 <td>
                     @Html.DisplayFor(Function(modelItem) item.ActivoID)
                 </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Tipo.Descripcion)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CodigoTavo)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Descripcion)
                </td>
                <td>
                    @Html.ActionLink("Editar", "Edit", New With {.id = item.ActivoID}) |
                    @Html.ActionLink("Detalles", "Details", New With {.id = item.ActivoID}) |
                    @Html.ActionLink("Eliminar", "Delete", New With {.id = item.ActivoID})
                </td>
            </tr>
        Next

    </table>
</div>
