@rem ******************** EXAMPLE 8 - Service & TrayIcon & System Event *******
@echo "compiling EXAMPLE 8 - Service & TrayIcon & System Event..."

@copy ..\..\_common_\common.jar ..\resource\Example8.jar
@copy ..\..\_common_\commonEvent.jar ..\resource\
@copy ..\..\_common_\bin\JavaExe.exe ..\Example8.exe

@javac -nowarn -classpath .\com\devwizard\javaexe\examples\example8;..\resource\Example8.jar;..\resource\commonEvent.jar .\com\devwizard\javaexe\examples\example8\*.java
@jar -uMf ..\resource\Example8.jar .\com\devwizard\javaexe\examples\example8\*.class
@del .\com\devwizard\javaexe\examples\example8\*.class

@cd ..
@..\_common_\bin\UpdateRsrcJavaExe.exe -run -exe=Example8.exe -prp=src\liste.properties
@cd ..
