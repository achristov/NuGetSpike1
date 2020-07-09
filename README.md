# NuGetSpike1
Working with symbols and source code for a NuGet package.

1. Create NuGet package

Console:
```
    dotnet pack MyPackage.csproj -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
```    
Output:
```
Microsoft (R) Build Engine version 16.7.0-preview-20310-07+ee1c9fd0c for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  You are using a preview version of .NET Core. See: https://aka.ms/dotnet-core-preview
  MyPackage -> D:\Projects\2019\NuGetSpike1\MyPackage\bin\Debug\netcoreapp3.1\MyPackage.dll
  Successfully created package 'D:\Projects\2019\NuGetSpike1\MyPackage\bin\Debug\MyPackage.1.1.0.nupkg'.
  Successfully created package 'D:\Projects\2019\NuGetSpike1\MyPackage\bin\Debug\MyPackage.1.1.0.snupkg'.
```  

[Create packages](https://github.com/adam-p/markdown-here/raw/master/src/common/images/icon48.png "Logo Title Text 1")

2. Push the package

Console:
```
dotnet nuget push -s http://baget.local/v3/index.json MyPackage.1.1.0.nupkg -k 123456
```

Output:
```
Pushing MyPackage.1.1.0.nupkg to 'http://baget.local/api/v2/package'...
  PUT http://baget.local/api/v2/package/
  Created http://baget.local/api/v2/package/ 699ms                      
Your package was pushed.
Pushing MyPackage.1.1.0.snupkg to 'http://baget.local/api/v2/symbol'...  
  PUT http://baget.local/api/v2/symbol/
  Created http://baget.local/api/v2/symbol/ 24ms
Your package was pushed.
```

The Assembly (.dll)
It is in .nupkg (as usual)


The Symbols (.pdb)
The program database is stored in MyPackage.snupkg

