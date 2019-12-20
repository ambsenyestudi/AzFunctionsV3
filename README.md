# AzFunctionsV3
Unfortunately as of today there is no Visual Studio template por Azure Functions v3. Hear I explain a few tweaks to make it work.

To avoid your error in Azure Functions V3 you have to:

Change your project settings Application/TargetFramework to .Net Core 3.1

Update your Version <AzureFunctionsVersion> to V3

Add your <RootNamespace> 

Mine look like this:
```
<PropertyGroup>
    <TargetFramework>netcoreapp3.1</TargetFramework>
    <AzureFunctionsVersion>v3</AzureFunctionsVersion>
    <RootNamespace>DI.Az.Func.V3</RootNamespace>
</PropertyGroup>
```
