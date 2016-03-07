@ModelType MMA.Models.Custodio
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
