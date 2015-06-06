
import java.awt.*;
import java.awt.event.*;
import java.net.*;
import java.io.*;
import java.util.*;

class Webserver2 extends Thread {
	
public Webserver2(Socket s) {
		this.connectionSocket=s;
}
private String requestMessageLine;
private String fileName;
private Socket connectionSocket;
private DataOutputStream outToClient;
private BufferedReader inFromClient;
//ServerSocket listenSocket = new ServerSocket(6789);
//Socket connectionSocket = listenSocket.accept();
public void run()
{
	try{
inFromClient=new BufferedReader(new InputStreamReader(connectionSocket.getInputStream()));
outToClient=new DataOutputStream(connectionSocket.getOutputStream());
requestMessageLine = inFromClient.readLine();
System.out.println(requestMessageLine);
StringTokenizer tokenizedLine =new StringTokenizer(requestMessageLine);
if (tokenizedLine.nextToken().equals("GET")){
fileName = tokenizedLine.nextToken();
if(fileName.equals("/") || fileName.equals(""))
{
	fileName="index.htm";
	File file = new File(fileName);
int numOfBytes = (int) file.length();
FileInputStream inFile = new FileInputStream (fileName);
byte[] fileInBytes = new byte[numOfBytes];
inFile.read(fileInBytes);
outToClient.writeBytes("HTTP/1.0 200 Document Follows\r\n");
outToClient.writeBytes("Content-Type: text/html\r\n");
outToClient.writeBytes("Content-Length: " + numOfBytes + "\r\n");
outToClient.writeBytes("\r\n");
outToClient.write(fileInBytes, 0, numOfBytes);
connectionSocket.close();
return;
}
if (fileName.startsWith("/") == true )
fileName = fileName.substring(1);
File file = new File(fileName);
int numOfBytes = (int) file.length();
FileInputStream inFile = new FileInputStream (fileName);
byte[] fileInBytes = new byte[numOfBytes];
inFile.read(fileInBytes);
outToClient.writeBytes("HTTP/1.0 200 Document Follows\r\n");
if (fileName.endsWith(".jpg"))
outToClient.writeBytes("Content-Type: image/jpeg\r\n");
if (fileName.endsWith(".gif"))
outToClient.writeBytes("Content-Type: image/gif\r\n");
outToClient.writeBytes("Content-Length: " + numOfBytes + "\r\n");
outToClient.writeBytes("\r\n");
outToClient.write(fileInBytes, 0, numOfBytes);
connectionSocket.close();
}
else System.out.println("Bad Request Message");
}

catch(IOException e)
{
	System.out.println(e.getMessage());
}
}

	public static void main(String args[]) {
		System.out.println("Starting Webserver2...");
try{
		ServerSocket listenSocket = new ServerSocket(6789);
		while(true)
		{
			(new Webserver2(listenSocket.accept())).start();
			System.out.println("connection Recieved.");
		}
		}
		catch(IOException e){}
	}
}
