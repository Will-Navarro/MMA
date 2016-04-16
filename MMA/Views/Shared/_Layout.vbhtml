<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Módulo de  de Activos", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            
            <div class="navbar-collapse collapse">

                <ul class="nav navbar-nav menu2">
                    <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li>@Html.ActionLink("Activos", "Index", "Activos")</li>
                    <li>@Html.ActionLink("Tipos de Activos", "Index", "Tipos")</li>
                    <li>@Html.ActionLink("Plantas", "Index", "Plantas")</li>
                    <li>@Html.ActionLink("Custodios", "Index", "Custodios")</li>
                    <li>@Html.ActionLink("Trazabilidad", "Index", "Trazabilidad")</li>
                    <li>@Html.ActionLink("Mantenimientos", "Index", "Mantenimientos")</li>
                    <li>@Html.ActionLink("Proveedores", "Index", "Proveedores")</li>
                </ul>

                <ul class="nav navbar-nav navbar-right">
                    <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                    <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                </ul>

                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
    <div class="container body-content">
        <div class="col-sm-3 col-md-2 sidebar col-lg-2">
            <ul class="nav nav-sidebar">
                <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                <li>@Html.ActionLink("Activos", "Index", "Activos")</li>
                <li>@Html.ActionLink("Tipos de Activos", "Index", "Tipos")</li>
                <li>@Html.ActionLink("Plantas", "Index", "Plantas")</li>
                <li>@Html.ActionLink("Custodios", "Index", "Custodios")</li>
                <li>@Html.ActionLink("Trazabilidad", "Index", "Trazabilidad")</li>
                <li>@Html.ActionLink("Mantenimientos", "Index", "Mantenimientos")</li>
                <li>@Html.ActionLink("Proveedores", "Index", "Proveedores")</li>
            </ul>
        </div>
        <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main col-lg-10">
            @RenderBody()
        </div>
        
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
