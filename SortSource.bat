@echo off
set dir=%1
set label=%2
set "extlist=.mkv|.mp4|.bat|"

@echo off
if /I %label% equ "Sources" (
 	    GOTO isSource
) else (
 	GOTO end
)

:isSource
echo is a Source
for /r %dir% %%i in (*) do (
    set "fname=%%~i"
    setlocal enabledelayedexpansion
    if "!extlist:%%~xi|=!"=="%extlist%" del "!fname!"
    endlocal
)

for /f "usebackq delims=" %%d in (`"dir /ad/b/s | sort /R"`) do rd "%%d"

echo All Excess Files Removed
echo %dir% cleaned

:end
echo Finished
