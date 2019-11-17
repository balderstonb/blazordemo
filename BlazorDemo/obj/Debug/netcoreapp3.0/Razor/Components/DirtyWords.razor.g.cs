#pragma checksum "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a367569d04c1dd19d41459af7969b39234121e9c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using BlazorDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\_Imports.razor"
using BlazorDemo.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class DirtyWords : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
 if (AllDirtyWords != null)
{
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
         foreach (var word in AllDirtyWords)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
             word

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(1, " ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-danger");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
                                                           (()=> RemoveWord(word))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Remove");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, " <br>\r\n");
#nullable restore
#line 8 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
         
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<div>No words</div>\r\n");
#nullable restore
#line 13 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
               NewWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewWord = __value, NewWord));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
                                          AddWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Add");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\balde\source\repos\WebApplication2\WebApplication2\Components\DirtyWords.razor"
       
    [Parameter] public List<string> AllDirtyWords { get; set; }

    string NewWord { get; set; }

    void RemoveWord(string word)
    {
        AllDirtyWords.Remove(word);
    }

    void AddWord()
    {
        if (AllDirtyWords == null)
        {
            AllDirtyWords = new List<string>();
        }

        AllDirtyWords.Add(NewWord);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
