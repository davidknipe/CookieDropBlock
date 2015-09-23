@Echo Setting up folder structure
md Package\lib\net45\
md Package\tools\
md Package\content\ClientResources\Images\
md Package\content\Views\Shared\Blocks\

@Echo Removing old files
del /Q Package\lib\net45\*.*
del /Q Package\content\ClientResources\Images\*.*
del /Q Package\content\Views\Shared\Blocks\*.*

@Echo Copying new files
copy ..\CookieDropBlock\bin\Release\CookieDropBlock.dll Package\lib\net45 
copy ..\CookieDropBlock\ClientResources\Images\block-type-thumbnail-cookiedrop.png Package\content\ClientResources\Images\block-type-thumbnail-cookiedrop.png
copy ..\CookieDropBlock\Views\Shared\Blocks\CookieDropBlock.cshtml Package\content\Views\Shared\Blocks\CookieDropBlock.cshtml

@Echo Packing files
"..\.nuget\nuget.exe" pack package\CookieDropBlock.nuspec

@Echo Moving package
move /Y *.nupkg c:\project\nuget.local\