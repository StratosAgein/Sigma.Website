@ECHO OFF

FOR /f "delims=" %%i IN ('node -v') DO SET nodeVersion=%%i

IF DEFINED nodeVersion (
    GOTO :NPMInstall
)ELSE (
    GOTO :installNodeJS
)

:FinishScript
SETLOCAL
ECHO Finished script
EXIT
ENDLOCAL

:GRUNT
SETLOCAL
ECHO Running Grunt
call grunt
GOTO :FinishScript
ENDLOCAL

:NPMInstall
SETLOCAL
ECHO Installing NPM Packages...
call npm install
GOTO :grunt
ENDLOCAL

:installNodeJS
SETLOCAL
ECHO Installing Node.js and NPM...
@powershell -NoProfile -ExecutionPolicy Bypass -Command "iex ((new-object net.webclient).DownloadString('https://chocolatey.org/install.ps1'))" && SET PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin
call choco install nodejs.install
ENDLOCAL