// from a Server and display the information.
// Java core packages
import java.io.*;
import java.net.*;
import java.awt.*;
import java.awt.event.*;
import java.lang.*;
// Java extension packages
import javax.swing.*;
public class Client2 extends JFrame {
private String ClientName;
private JTextField enterField;
private JButton Sendbtn;
private JTextArea displayArea;
private ObjectOutputStream output;
private ObjectInputStream input;
private String message = "";
private String chatServer;
private Socket client;
// initialize chatServer and set up GUI
public Client2( String host )
{
super( "Client" );

ClientName="Abdelrady";

JMenu fileMenu = new JMenu( "File" );
fileMenu.setMnemonic( 'F' );

JMenuItem aboutItem = new JMenuItem( "About..." );
aboutItem.setMnemonic( 'A' );
aboutItem.addActionListener(

new ActionListener() {

public void actionPerformed( ActionEvent event )
{
JOptionPane.showMessageDialog( Client2.this,
"Eng. Abdelrady Elagamy Abdelrady\nFaculty Of Computer & Info.\nEgypt,Luxor",
"About", JOptionPane.PLAIN_MESSAGE );
}
} 
);
fileMenu.add( aboutItem );

JMenuItem CName = new JMenuItem( "Change Your Name." );
CName.setMnemonic( 'Y' );
CName.addActionListener(

new ActionListener() {

public void actionPerformed( ActionEvent event )
{
ClientName=JOptionPane.showInputDialog("Enter Your NickName:","Abdelrady");
}
} 
);
fileMenu.add( CName );


JMenuItem chnghost = new JMenuItem( "Change Host" );
chnghost.setMnemonic( 'h' );
chnghost.addActionListener(
new ActionListener() {
public void actionPerformed( ActionEvent event )
{
	String str2=JOptionPane.showInputDialog(
		"Enter Host Name To Connect To:","localhost");
//	closeConnection();
	Client2 cln=new Client2(str2);
	cln.setDefaultCloseOperation(
JFrame.EXIT_ON_CLOSE );
cln.runClient();
	//setVisible(false);
	dispose();
//try{super.dispose();}.finalize()
//catch(java.lang.Throwable e){}
//	this=null;
}
}
);
fileMenu.add( chnghost );
chnghost.setEnabled(false);


JMenuItem exitItem = new JMenuItem( "Exit" );
exitItem.setMnemonic( 'x' );
exitItem.addActionListener(
new ActionListener() {
public void actionPerformed( ActionEvent event )
{
	/*try{closeConnection();}
	catch(IOException w){System.out.println(w.getMessage());}*/
	dispose();
	System.exit( 0 );
}
}
);
fileMenu.add( exitItem );

JMenuBar bar = new JMenuBar();
setJMenuBar( bar );
bar.add( fileMenu );

// set server to which this client connects
chatServer = host;
Container container = getContentPane();
// create enterField and register listener
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
sendData( enterField.getText() );
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
}
public void runClient()
{
try {
connectToServer();
getStreams();
processConnection();
closeConnection();
}
// server closed connection
catch ( EOFException eofException ) {
System.out.println( "Server terminated connection" );
}
// process problems communicating with server
catch ( IOException ioException ) {
ioException.printStackTrace();
}
}

private void getStreams() throws IOException
{
output = new ObjectOutputStream(
client.getOutputStream() );
// flush output buffer to send header information
output.flush();
input = new ObjectInputStream(
client.getInputStream() );
displayArea.append( "\nGot I/O streams\n" );
}
//////////////////////////////////////////////////////////////////////////////////////////
private void connectToServer() throws IOException
{
displayArea.setText( "Attempting connection\n" );

//InetAddress.getByName(chatServer )
client = new Socket(
( chatServer==null?"localhost":chatServer ), 5000 );

displayArea.append( "Connected to: " +
 chatServer==null?"localhost":chatServer);//client.getInetAddress().getHostName()
 Sendbtn.setEnabled(true);
}
// process connection with server
private void processConnection() throws IOException
{
Sendbtn.setEnabled( true );

do {

try {
message = ( String ) input.readObject();
displayArea.append( "\n" + message );
displayArea.setCaretPosition(
displayArea.getText().length() );
}
// catch problems reading from server
catch ( ClassNotFoundException classNotFoundException ) {
displayArea.append( "\nUnknown object type received" );
}
} while ( !message.equals( "FCI>>> TERMINATE" ) );
}

private void closeConnection() throws IOException
{
displayArea.append( "\nClosing connection" );
output.close();
input.close();
client.close();
}

private void sendData( String message )
{

try {
output.writeObject( ClientName+">>> " + message );
output.flush();
displayArea.append( "\n"+ClientName+">>>" + message );
}
// process problems sending object
catch ( IOException ioException ) {
displayArea.append( "\nError writing object" );
}
}
// execute application
public static void main( String args[] )
{
Client2 application;
if ( args.length == 0 )
application = new Client2("localhost" /*"127.0.0.1"*/ );
else
application = new Client2( args[ 0 ] );
application.setDefaultCloseOperation(
JFrame.EXIT_ON_CLOSE );
application.runClient();
}
}