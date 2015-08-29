@echo off
if "%1%"=="" GOTO ERROR
if "%2%"=="" GOTO ERROR

ECHO Se usara la base de datos "%2" en el server "%1"  

sqlcmd -S %1 -i aStarter.sql -v dbname=%2

Pause
GOTO FIN

:ERROR
ECHO; 
ECHO Uso:  create servername\instance dbname 
ECHO;

:FIN

