@ModelType MMA.Models.Activo
@Code
    ViewData("Title") = "Eliminar"
End Code

<h2>Eliminar</h2>

<h3>¿Está seguro que desea Eliminar?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Eliminar" class="btn btn-danger" /> |
            @Html.ActionLink("Regresar", "Index")
        </div>
    End Using
</div>
