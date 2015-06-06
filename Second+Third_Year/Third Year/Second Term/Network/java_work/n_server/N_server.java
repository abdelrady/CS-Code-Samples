// from a Server and display the information.
// Java core packages
import java.io.*;
import java.net.*;
import java.awt.*;
import java.awt.event.*;
import java.lang.*;
// Java extension packages
import javax.swing.*;
public class N_server {
	private ServerSocket server;
private Socket connection;

public N_server()
{
//super( "Server" );
//runServer();
}
public void runServer()
{
try {
	for(int i=1025;i<=65500;i++)
	{
		(new ServerSocket( i, 100 )).accept();
		System.out.println(i);
	}
	}
catch (java.net.BindException e)
{System.out.println();}

catch ( IOException ioException ) {
ioException.printStackTrace();
}
/*catch ( EOFException eofException ) {
System.out.println( "Client terminated connection" );
}*/

}

public static void main( String args[] )
{
N_server application = new N_server();
application.runServer();
}


}