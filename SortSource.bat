@echo off &setlocal
set dir=%1
set "extlist=.mkv|.mp4|.bat|"
for /r %dir% %%i in (*) do (
    set "fname=%%~i"
    setlocal enabledelayedexpansion
    if "!extlist:%%~xi|=!"=="%extlist%" del "!fname!"
    endlocal
)

for /f "usebackq delims=" %%d in (`"dir /ad/b/s | sort /R"`) do rd "%%d"

CLS
echo All Excess Files Removed
echo %dir% cleaned