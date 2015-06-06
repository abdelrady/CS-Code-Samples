//package com.j2me.part4;

import java.util.Hashtable;
import java.util.Enumeration;
import java.io.*;
import javax.microedition.lcdui.Item;
import javax.microedition.lcdui.List;
import javax.microedition.lcdui.Form;
import javax.microedition.midlet.MIDlet;
import javax.microedition.lcdui.Display;
import javax.microedition.lcdui.Command;
import javax.microedition.lcdui.Displayable;
import javax.microedition.lcdui.CommandListener;
import javax.microedition.lcdui.*;

import javax.microedition.media.Player;
import javax.microedition.media.Control;
import javax.microedition.media.control.*;//VideoControl;
import javax.microedition.media.Manager;
import javax.microedition.media.PlayerListener;

public class MMPlayer extends MIDlet
  implements CommandListener, PlayerListener {

  private Display display;
  private List itemList;
  private Form form;

  private Command stopCommand;
  private Command  exit;
  private Command pauseCommand;
  private Command startCommand;

  private Hashtable items;
  private Hashtable itemsInfo;

  private Player player;

  public MMPlayer() {
    display = Display.getDisplay(this);
    // creates an item list to let you select multimedia files to play
    itemList = new List("Select file to play", List.IMPLICIT);

    // stop, pause and restart commands
    exit=new Command("Exit",Command.EXIT,1);
    stopCommand = new Command("Stop", Command.STOP, 1);
    pauseCommand = new Command("Pause", Command.ITEM, 1);
    startCommand = new Command("Play", Command.ITEM, 1);
    itemList.addCommand(startCommand);
    itemList.addCommand(exit);
    itemList.setCommandListener(this);
    // a form to display when items are being played
    form = new Form("MMPlayer");

    // the form acts as the interface to stop and pause the media
    form.addCommand(stopCommand);
    form.addCommand(pauseCommand);
    form.setCommandListener(this);

    // create a hashtable of items
    items = new Hashtable();

    // and a hashtable to hold information about them
    itemsInfo = new Hashtable();

    // and populate both of them
    items.put("Doaa", "file://doaa.wav");
    itemsInfo.put("Doaa", "audio/x-wav");
     items.put("salah", "file://salah.wav");
    itemsInfo.put("salah", "audio/x-wav");
    items.put("Music", "file://Music.wav");
    itemsInfo.put("Music", "audio/x-wav");
    items.put("Song", "file://Song04.wav");
    itemsInfo.put("Song", "audio/x-wav");
    items.put("Video Promo", "file://promo.mpg");
    itemsInfo.put("Video Promo", "video/mpeg");
    items.put("Video sha3rawe", "file://2-11.mpg");
    itemsInfo.put("Video sha3rawe", "video/mpeg");

  }

  public void startApp() {

    // when MIDlet is started, use the item list to display elements
    for(Enumeration en = items.keys(); en.hasMoreElements();) {
    itemList.append((String)en.nextElement(), null);
  }

    itemList.setCommandListener(this);

    // show the list when MIDlet is started
    display.setCurrent(itemList);
  }

  public void pauseApp() {
    // pause the player
    try {
      if(player != null) player.stop();
    } catch(Exception e) {}
  }

  public void destroyApp(boolean unconditional) {
    if(player != null) player.close(); // close the player
  }

  public void commandAction(Command command, Displayable disp) {

    // generic command handler
       if(command==exit)
        {
        	if(player!=null)
        	        	player.close();
        	notifyDestroyed(); 
        	player.close();
        	System.exit(0);
        }
    // if list is displayed, the user wants to play the item
    if(disp instanceof List) {
      List list = ((List)disp);

      String key = list.getString(list.getSelectedIndex());

      // try and play the selected file
      try {
        playMedia((String)items.get(key), key);
      } catch (Exception e) {
        System.err.println("Unable to play: " + e);
        e.printStackTrace();
      }
    } else if(disp instanceof Form) {

      // if showing form, means the media is being played
      // and the user is trying to stop or pause the player
      try {

        if(command == stopCommand) { // if stopping the media play

          player.close(); // close the player
          display.setCurrent(itemList); // redisplay the list of media
          form.removeCommand(startCommand); // remove the start command
          form.addCommand(pauseCommand); // add the pause command

        } else if(command == pauseCommand) { // if pausing

          player.stop(); // pauses the media, note that it is called stop
          form.removeCommand(pauseCommand); // remove the pause command
          form.addCommand(startCommand); // add the start (restart) command
        } else if(command == startCommand) { // if restarting

          player.start(); // starts from where the last pause was called
          form.removeCommand(startCommand);
          form.addCommand(pauseCommand);
        }
         
      } catch(Exception e) {
        System.err.println(e);
      }
    }

  }

  /* Creates Player and plays media for the first time */
  private void playMedia(String locator, String key) throws Exception {

    // locate the actual file, we are only dealing
    // with file based media here
    String file = locator.substring(
      locator.indexOf("file://") + 6,
      locator.length());

    // create the player
    // loading it as a resource and using information about it
    // from the itemsInfo hashtable
    player = Manager.createPlayer(
        getClass().getResourceAsStream(file), (String)itemsInfo.get(key));

    // a listener to handle player events like starting, closing etc
    player.addPlayerListener(this);

    player.setLoopCount(-1); // play indefinitely
    player.prefetch(); // prefetch
    player.realize(); // realize

    player.start(); // and start
  }

  /* Handle player events */
  public void playerUpdate(Player player, String event, Object eventData) {

   
    if(event.equals(PlayerListener.STARTED) &&
      new Long(0L).equals((Long)eventData)) {
    	// chech the file is it audio or vidio
      	VideoControl vc = null;
      	VolumeControl vol=null;
		if((vc = (VideoControl)player.getControl("VideoControl")) != null) {
		  Item videoDisp =
			(Item)vc.initDisplayMode(vc.USE_GUI_PRIMITIVE, null);
		  form.append(videoDisp);
		}
	//	ImageItem item =new ImageItem("Audio Player",loadimage("/x.png"),0,"");
	//	form.append(item);
		
      display.setCurrent(form);
    } else if(event.equals(PlayerListener.CLOSED)) {

      form.deleteAll(); // clears the form of any previous controls
    }
  }
	private Image loadimage(String name)
	{
		Image image=null;
		try
		{
			image=Image.createImage(name);
		}
		catch(IOException ioe)
		{
			System.out.println(ioe);
		}
		return image;
	}
}
