@Echo Setting up folder structure
md Package\lib\net45\
md Package\tools\
md Package\content\modules\_protected\CookieDropBlock\Images\
md Package\content\modules\_protected\CookieDropBlock\Views\

@Echo Removing old files
del /Q Package\lib\net45\*.*
del /Q Package\content\modules\_protected\CookieDropBlock\Images\*.*
del /Q Package\content\modules\_protected\CookieDropBlock\Views\*.*

@Echo Copying new files
copy ..\CookieDropBlock\bin\Release\CookieDropBlock.dll Package\lib\net45 
copy ..\CookieDropBlock\modules\_protected\CookieDropBlock\Images\block-type-thumbnail-cookiedrop.png Package\content\modules\_protected\CookieDropBlock\Images\block-type-thumbnail-cookiedrop.png
copy ..\CookieDropBlock\modules\_protected\CookieDropBlock\Views\CookieDropBlock.cshtml Package\content\modules\_protected\CookieDropBlock\Views\CookieDropBlock.cshtml
copy ..\CookieDropBlock\modules\_protected\CookieDropBlock\Views\web.config Package\content\modules\_protected\CookieDropBlock\Views\web.config

@Echo Packing files
"..\.nuget\nuget.exe" pack package\CookieDropBlock.nuspec

@Echo Moving package
move /Y *.nupkg c:\project\nuget.local\