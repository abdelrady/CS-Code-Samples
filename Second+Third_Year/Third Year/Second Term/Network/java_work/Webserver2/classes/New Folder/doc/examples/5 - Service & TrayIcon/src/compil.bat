@rem ******************** EXAMPLE 5 - Service & TrayIcon *************
@echo "compiling EXAMPLE 5 - Service & TrayIcon..."

@copy ..\..\_common_\common.jar ..\resource\Example5.jar
@copy ..\..\_common_\commonService.jar ..\resource\
@copy ..\..\_common_\bin\JavaExe.exe ..\Example5.exe

@javac -nowarn -classpath .\com\devwizard\javaexe\examples\example5;..\resource\Example5.jar;..\resource\commonService.jar .\com\devwizard\javaexe\examples\example5\*.java
@jar -uMf ..\resource\Example5.jar .\com\devwizard\javaexe\examples\example5\*.class
@del .\com\devwizard\javaexe\examples\example5\*.class

@cd ..
@..\_common_\bin\UpdateRsrcJavaExe.exe -run -exe=Example5.exe -prp=src\liste.properties
@cd ..
