@ECHO OFF
ECHO Building ...

call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe ..\Bugsnager.sln ^
/m /clp:ErrorsOnly /t:Clean,Build /p:Configuration=Release /p:Platform="Any CPU" 

PAUSE
