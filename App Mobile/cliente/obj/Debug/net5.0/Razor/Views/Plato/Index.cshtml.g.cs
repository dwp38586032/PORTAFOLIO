#pragma checksum "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "160853fc9e9203af8378df324862b7dec7929ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plato_Index), @"mvc.1.0.view", @"/Views/Plato/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\_ViewImports.cshtml"
using cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\_ViewImports.cshtml"
using cliente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"160853fc9e9203af8378df324862b7dec7929ce8", @"/Views/Plato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a0ae87e171a223eca5ae858c3a82e33705a7cf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Plato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/platos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
  
    ViewData["Title"] = "Menú de Platos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "160853fc9e9203af8378df324862b7dec7929ce84581", async() => {
                WriteLiteral("\r\n    <!-- ... Tus otras referencias a estilos y metadatos ... -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "160853fc9e9203af8378df324862b7dec7929ce84911", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css\">\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"page-container\">\r\n    <header>\r\n        <h1>");
#nullable restore
#line 14 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        <div class=""button-container"">
           
            <button id=""estado-pedido"" class=""btn btn-info"">Ver Estado del Pedido</button>
            <button id=""clear-order"" class=""btn btn-danger"">Borrar Orden</button>
        </div>
    </header>

    <div class=""reservation-container"">
        <input type=""text"" id=""codigo-reserva"" placeholder=""Código de Reserva"" />
        <button id=""verificar-reserva"" class=""btn btn-primary"">Verificar Reserva</button>
    </div>

    <div id=""cart-container"" class=""cart-container"">
        <h3>Carrito</h3>
        <div id=""cart-items"" class=""cart-items"">
            <!-- Los elementos del carrito se añadirán aquí dinámicamente -->
        </div>
        <p>Total: <span id=""cart-total"" class=""cart-total"">0</span></p>
        <button id=""checkout-button"" class=""btn btn-success"">Pedir</button>
    </div>

<div class=""platos-container"">
");
#nullable restore
#line 37 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
         foreach (var plato in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"plato-card\">\r\n                <div class=\"image-container\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1455, "\"", 1474, 1);
#nullable restore
#line 41 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
WriteAttributeValue("", 1461, plato.Imagen, 1461, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1475, "\"", 1504, 3);
            WriteAttributeValue("", 1481, "Imagen", 1481, 6, true);
            WriteAttributeValue(" ", 1487, "de", 1488, 3, true);
#nullable restore
#line 41 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
WriteAttributeValue(" ", 1490, plato.Nombre, 1491, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"plato-info\">\r\n                    <h3>");
#nullable restore
#line 44 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
                   Write(plato.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"price-time-container\">\r\n                        <div class=\"price-label\">Precio:</div>\r\n                        <div class=\"price\">");
#nullable restore
#line 47 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
                                      Write(plato.Precio.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"price-time-container\">\r\n                        <div class=\"preparation-label\">Tiempo de Preparación:</div>\r\n                        <div class=\"preparation-time\">");
#nullable restore
#line 51 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
                                                 Write(plato.TiempoPreparacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <button class=\"btn btn-primary add-to-cart-button\" data-id=\"");
#nullable restore
#line 53 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
                                                                           Write(plato.IdPlato);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-nombre=\"");
#nullable restore
#line 53 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
                                                                                                        Write(plato.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-precio=\"");
#nullable restore
#line 53 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
                                                                                                                                    Write(plato.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Añadir al carrito\r\n                    </button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 58 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3(EN PROCESO)\App Mobile\cliente\Views\Plato\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n    <!-- Agrega un icono para representar el carrito en la esquina superior derecha -->\r\n    <div class=\"cart-icon\" id=\"cart-icon\">\r\n        <i class=\"fa fa-shopping-cart\"></i>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <!-- Asegúrate de incluir jQuery si aún no está incluido -->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "160853fc9e9203af8378df324862b7dec7929ce812769", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        // Selecciona el icono del carrito y el contenedor del carrito
        const cartIcon = document.getElementById('cart-icon');
        const cartContainer = document.getElementById('cart-container');

        // Agrega un evento de clic al icono del carrito para llevar al usuario al principio de la página
        cartIcon.addEventListener('click', () => {
            // Desplaza la página al principio
            window.scrollTo({
                top: 0,
                behavior: 'smooth' // Esto proporciona un desplazamiento suave
            });
        });
                        cartIcon.addEventListener('click', () => {
                    // Muestra u oculta el contenedor del carrito al hacer clic en el icono
                    if (cartContainer.style.display === 'none' || cartContainer.style.display === '') {
                        cartContainer.style.display = 'block';
                    } else {
                        cartContainer.style.display = 'none';
");
                WriteLiteral(@"                    }
                });
    </script>
        <script>
        // Selecciona todos los botones ""Añadir al carrito""
        const addToCartButtons = document.querySelectorAll('.add-to-cart-button');

        // Agrega un evento de clic a cada botón
        addToCartButtons.forEach(button => {
            button.addEventListener('click', () => {
                // Agrega la clase ""clicked"" al botón al hacer clic
                button.classList.add('clicked');

                // Elimina la clase ""clicked"" después de 300 milisegundos (ajusta el tiempo según tu preferencia)
                setTimeout(() => {
                    button.classList.remove('clicked');
                }, 300);
            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
