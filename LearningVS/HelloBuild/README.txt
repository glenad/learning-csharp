to use open the visual studio command prompt (this has the msbuild path setup automatically)
=> Start -> Programs -> Visual Studio -> Developer Command Prompt for VS2013

msbuild /t:build - builds with the default assembly name
msbuild /t:build /p:Greetings - overrides the default assembly
msbuild /t:clean - deletes the default assembly
msbuild /t:clean /p:Greetings - deletes the specified assembly
msbuild /t:rebuild - deletes default assembly and then builds
msbuild - does the default target of build
msbuild /v:d - default but with verbose loggging

see https://msdn.microsoft.com/en-us/library/dd576348.aspx