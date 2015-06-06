@rem ******************** EXAMPLE 7 - OneInstance ********
@echo "compiling EXAMPLE 7 - OneInstance..."

@copy ..\..\_common_\common.jar ..\OneInstance.jar
@copy ..\..\_common_\bin\JavaExe.exe ..\OneInstance.exe

@javac -nowarn -classpath .\com\devwizard\javaexe\examples\example7;..\OneInstance.jar .\com\devwizard\javaexe\examples\example7\*.java
@jar -umf MANIFEST.MF ..\OneInstance.jar .\com\devwizard\javaexe\examples\example7\*.class
@del .\com\devwizard\javaexe\examples\example7\*.class

@cd ..\..
