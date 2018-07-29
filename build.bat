set MSBUILD="C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe"
set TARGET_SLN=".\Unity-Technologies-networking\Networking.sln"

call %MSBUILD% %TARGET_SLN%
