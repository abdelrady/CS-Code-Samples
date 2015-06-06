@rem ******************** EXAMPLE 3 - Service *************
@echo "compiling EXAMPLE 3 - Service..."

@copy ..\..\_common_\common.jar ..\resource\Example3.jar
@copy ..\..\_common_\commonService.jar ..\resource\
@copy ..\..\_common_\bin\JavaExe.exe ..\Example3.exe

@javac -nowarn -classpath .\com\devwizard\javaexe\examples\example3;..\resource\Example3.jar;..\resource\commonService.jar .\com\devwizard\javaexe\examples\example3\*.java
@jar -uMf ..\resource\Example3.jar .\com\devwizard\javaexe\examples\example3\*.class
@del .\com\devwizard\javaexe\examples\example3\*.class

@cd ..
@..\_common_\bin\UpdateRsrcJavaExe.exe -run -exe=Example3.exe -prp=src\liste.properties
@cd ..
