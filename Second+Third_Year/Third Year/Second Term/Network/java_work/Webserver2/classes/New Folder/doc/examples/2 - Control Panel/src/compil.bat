@rem ******************** EXAMPLE 2 - ControlPanel ********
@echo "compiling EXAMPLE 2 - ControlPanel..."

@copy ..\..\_common_\common.jar ..\Example2.jar
@copy ..\..\_common_\bin\JavaExe.exe ..\Example2.exe
@copy ..\..\_common_\bin\JavaExe.cpl ..\Example2.cpl

@javac -nowarn -classpath .\com\devwizard\javaexe\examples\example2;..\Example2.jar .\com\devwizard\javaexe\examples\example2\*.java
@jar -uMf ..\Example2.jar .\com\devwizard\javaexe\examples\example2\*.class
@jar -uMf ..\Example2.jar .\Images\*.*
@del .\com\devwizard\javaexe\examples\example2\*.class

@cd ..
@..\_common_\bin\UpdateRsrcJavaExe.exe -run -exe=Example2.exe -prp=src\liste.properties
@cd ..
