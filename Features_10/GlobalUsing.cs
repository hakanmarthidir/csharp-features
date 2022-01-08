global using System.Text;
global using System;
global using System.Security.Cryptography;

namespace Features_10
{
    public class GlobalUsing
    {
        //Some namespaces are already automatically imported. 
        //it changes according to SDK types. for example Web and others are different. Pleasce check the changes. 

        //1
        //Microsoft.NET.SDK:
        //System
        //System.Collections.Generic
        //System.IO
        //System.Linq
        //System.Net.Http
        //System.Threading
        //System.Threading.Tasks

        //2
        //Microsoft.NET.SDK.Web:
        //All of Microsoft.NET.SDK
        //System.Net.Http.Json
        //Microsoft.AspNetCore.Builder
        //Microsoft.AspNetCore.Hosting
        //Microsoft.AspNetCore.Http
        //Microsoft.AspNetCore.Routing
        //Microsoft.Extensions.Configuration
        //Microsoft.Extensions.DependencyInjection
        //Microsoft.Extensions.Hosting
        //Microsoft.Extensions.Logging

        //3
        //Microsoft.NET.SDK.Worker :
        //All of Microsoft.NET.SDK
        //Microsoft.Extensions.Configuration
        //Microsoft.Extensions.DependencyInjection
        //Microsoft.Extensions.Hosting
        //Microsoft.Extensions.Logging

        //to customization please visit the .csproj file related your project, and manage the attribute <ImplicitUsings>disable</ImplicitUsings>. default is enable

        //ADD GLOBAL USING
        //if you add using definition with global, it will be active on every file in project. 
        //global using System.Security.Cryptography;

        //CREATING ALIAS 
        //using x = MyProject.Features10.Trial;

        //ADD STATIC MODIFIERS
        //using static <fully-qualified-type-name>;
        //using static System.Console;
        //using static System.Math;

        //after that you can use like that the static members : return 2 * Radius * PI; or WriteLine(Sqrt(3*3 + 4*4));
    }
}
