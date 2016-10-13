## Update 2016-10-13
Works as expected when targeting full .NET >= 4.5, only problem when targeting netcoreapp1.0.

# LocalizationBug

Reproduces bug reported here: [https://github.com/aspnet/Localization/issues/293](https://github.com/aspnet/Localization/issues/293)

From what I can tell it's not possible to get the app _NOT_ to translate to english, for instance the query param isn't respected, but neither is a custom resource provider or what so ever:
    
    http://localhost:6376/?culture=sv
    
I'm claiming that we'll always see "Welcome" instead of "Välkommen", I've even tried setting the culture in the cookie. If I've missed something please send me a PL with fix.

Right now I'm camouflaging norwegian as english, which is a stupid work around to not always get english.
