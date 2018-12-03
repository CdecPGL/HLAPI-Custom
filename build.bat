set MSBUILD="C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe"
set TARGET_SLN=".\UNetCustom\UNetCustom.sln"

call %MSBUILD% %TARGET_SLN%
