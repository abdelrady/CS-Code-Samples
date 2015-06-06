@rem ******************** COMMON ****************
@echo "compiling Common..."


@javac -nowarn -classpath .\com\devwizard\javaexe\interfaces .\com\devwizard\javaexe\interfaces\*.java
@jar -cMf ..\common.jar .\com\devwizard\javaexe\interfaces\*.class
@del .\com\devwizard\javaexe\interfaces\*.class


@javac -nowarn -classpath .\com\devwizard\javaexe\examples\common .\com\devwizard\javaexe\examples\common\*.java
@jar -uMf ..\common.jar .\com\devwizard\javaexe\examples\common\*.class
@del .\com\devwizard\javaexe\examples\common\*.class


@javac -nowarn -classpath .\com\devwizard\javaexe\examples\common\event;..\common.jar .\com\devwizard\javaexe\examples\common\event\*.java
@jar -cMf ..\commonEvent.jar .\com\devwizard\javaexe\examples\common\event\*.class
@del .\com\devwizard\javaexe\examples\common\event\*.class


@javac -nowarn -classpath .\com\devwizard\javaexe\examples\common\service;..\common.jar .\com\devwizard\javaexe\examples\common\service\*.java
@jar -cMf ..\commonService.jar .\com\devwizard\javaexe\examples\common\service\*.class
@del .\com\devwizard\javaexe\examples\common\service\*.class


@cd ..\..
