/*//package ServerPackage;
import java.io.*;
import java.net.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.event.*;
import javax.swing.*;
//import SServerConnection.*;
class asd extends Thread{

private ObjectOutputStream output;
private ObjectInputStream input;
private ServerSocket server;
private Socket connection;
static int counter = 1;

	public asd(Socket s){
		connection=s;
		Server2.displayArea.append( "\nConnection " + counter +
" received from: " +
connection.getInetAddress().getHostName() );
Server2.Sendbtn.setEnabled(true);
	}
	public static void asd2(String str)
	{
	//	Server2.displayArea.append("wqeew");
	sendData(str);
	}
	
public void Run()
{
try {
//server = new ServerSocket( 5000, 100 );

getStreams();
++counter;
processConnection();
closeConnection();


}
// process EOFException when client closes connection
catch ( EOFException eofException ) {
System.out.println( "Client terminated connection" );
}
// process problems with I/O
catch ( IOException ioException ) {
ioException.printStackTrace();
}
}
*/
/*private void waitForConnection() throws IOException
{
//asd.asd2();
//connection = server.accept();

}
*/
/*
private void getStreams() throws IOException
{
output = new ObjectOutputStream(
connection.getOutputStream() );
// flush output buffer to send header information
output.flush();

input = new ObjectInputStream(
connection.getInputStream() );
Server2.displayArea.append( "\nGot I/O streams\n" );
}

private void processConnection() throws IOException
{
String message = "FCI>>> Connection successful";
output.writeObject( message );
output.flush();
// enable SendBtn so server user can send messages
Server2.Sendbtn.setEnabled( true );
// process messages sent from client
do {
// read message and display it
try {
message = ( String ) input.readObject();
Server2.displayArea.append( "\n" + message );
Server2.displayArea.setCaretPosition(
Server2.displayArea.getText().length() );

}
// catch problems reading from client
catch ( ClassNotFoundException classNotFoundException ) {
Server2.displayArea.append( "\nUnknown object type received" );
}
} while ( !message.equals( "CLIENT>>> TERMINATE" ) );
}
private void closeConnection() throws IOException
{
Server2.displayArea.append( "\nUser terminated connection" );
Server2.Sendbtn.setEnabled( false );
output.close();
input.close();
connection.close();
}

public void sendData( String message )
{
try {
output.writeObject( "FCI>>> " + message );
output.flush();
Server2.displayArea.append( "\nFCI>>>" + message );
}
// process problems sending object
catch ( IOException ioException ) {
Server2.displayArea.append( "\nError writing object" );
}
}

}
///////////////////////////////////////////////////////////////////////////


class Server2 extends JFrame {
	
private ServerSocket server;
public static JTextField enterField;
public static JButton Sendbtn;
public static JTextArea displayArea;
private Socket connection;

public static void set(String str)
{
	enterField.setText(str);
}
// set up GUI
public Server2()
{
super( "Server" );
try{server = new ServerSocket( 5000, 100 );}
catch(IOException e){}
Container container = getContentPane();
//container.setLayout(new GridLayout(2,2));
JPanel pan1=new JPanel();
pan1.setLayout(new GridLayout(1,2));
pan1.setVisible(true);
Sendbtn=new JButton("Send Msg");
Sendbtn.setEnabled(false);
Sendbtn.setSize(50,50);
Sendbtn.addActionListener(
new ActionListener() {
// send message to client
public void actionPerformed( ActionEvent event )
{
//	try{
new asd(connection).sendData( enterField.getText() );
//}
//catch(IOException E){}
displayArea.append( "\nFCI>>>" + enterField.getText() );
}
}
);

enterField = new JTextField();
enterField.setSize(150,150);
enterField.setEnabled( true );

pan1.add(enterField);
pan1.add(Sendbtn);
container.add(pan1,BorderLayout.NORTH);

displayArea = new JTextArea();
container.add( new JScrollPane( displayArea ),
BorderLayout.CENTER );
setSize(800, 500 );
setVisible( true );

displayArea.setText( "Waiting for connection\n" );
try{
while(true)
{
	connection=server.accept();
new asd(connection).start();
}
}
catch(IOException e){}
}

public static void main( String args[] )
{
Server2 application = new Server2();
application.setDefaultCloseOperation(
JFrame.EXIT_ON_CLOSE );
//application.Run();
}
}*/
