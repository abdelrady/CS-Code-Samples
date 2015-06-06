@rem ******************** EXAMPLE 4 - TrayIcon ********
@echo "compiling EXAMPLE 4 - TrayIcon..."

@copy ..\..\_common_\common.jar ..\Example4.jar
@copy ..\..\_common_\bin\JavaExe.exe ..\Example4.exe

@javac -nowarn -classpath .\com\devwizard\javaexe\examples\example4;..\Example4.jar .\com\devwizard\javaexe\examples\example4\*.java
@jar -uMf ..\Example4.jar .\com\devwizard\javaexe\examples\example4\*.class
@jar -uMf ..\Example4.jar Images\*.*
@del .\com\devwizard\javaexe\examples\example4\*.class

@cd ..\..
