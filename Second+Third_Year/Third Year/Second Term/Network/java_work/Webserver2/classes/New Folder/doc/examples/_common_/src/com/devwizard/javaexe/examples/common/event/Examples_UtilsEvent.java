/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common.event;


import java.io.*;
import com.devwizard.javaexe.interfaces.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Examples_UtilsEvent
	implements JavaExe_I_SystemEventManagement
{
	/*******************************************/
	public static String getVolumeUnits(int unitMask)
	{
		String ret = "";

		for(int i=0;i < 26;i++)
			if(((unitMask>>i) & 1) != 0)
				ret += ((char) ('A'+i))+": ";

		return ret.trim();
	}

	/*******************************************/
	public static String getTypeVolume(int type)
	{
		if(type==1) return "Media";
		if(type==2) return "Network";

		return null;
	}

	/*******************************************/
	public static String getStatusPowerBattery(byte flag)
	{
		String ret = "";

		if(flag==255)
			ret = "?";
		else
		{
			if((flag &   1) != 0) ret  = "High ";
			if((flag &   2) != 0) ret += "Low ";
			if((flag &   4) != 0) ret += "Critical ";
			if((flag &   8) != 0) ret += "Charging ";
			if((flag & 128) != 0) ret += "No system battery ";
		}

		return ret.trim();
	}

	/*******************************************/
	public static String getStatusPowerAC(byte flag)
	{
		if(flag==0) return "off";
		if(flag==1) return "on";

		return "?";
	}

	/*******************************************/
	public static String getHHMMSS(int nbSecs)
	{
		if(nbSecs < 0)
			return "?";

		int s = nbSecs % 60;
		int m = (nbSecs / 60) % 60;
		int h = nbSecs / 3600;

		String ret = "";

		if(h > 0) ret += h+"h ";
		if(m > 0 || h > 0) ret += m+"mn ";

		return ret+s+"s";
	}

	/*******************************************/
	public static String getTypeLogOff(int bitMask)
	{
		if((bitMask & ENDSESSION_LOGOFF)==0)
			return "Shutdown System";

		return "LogOff Session";
	}

	/*******************************************/
	public static String getMsgText(int msg)
	{
		switch(msg)
		{
			case WM_QUERYENDSESSION	: return "WM_QUERYENDSESSION";
			case WM_ENDSESSION		: return "WM_ENDSESSION";
			case WM_DEVMODECHANGE	: return "WM_DEVMODECHANGE";
			case WM_TIMECHANGE		: return "WM_TIMECHANGE";
			case WM_COMPACTING		: return "WM_COMPACTING";
			case WM_USERCHANGED		: return "WM_USERCHANGED";
			case WM_DISPLAYCHANGE	: return "WM_DISPLAYCHANGE";
			case WM_POWERBROADCAST	: return "WM_POWERBROADCAST";
			case WM_DEVICECHANGE	: return "WM_DEVICECHANGE";
			case WM_SYSCOMMAND		: return "WM_SYSCOMMAND";
			case WM_NETWORK			: return "WM_NETWORK";
			case WM_SESSION_CHANGE	: return "WM_SESSION_CHANGE";
			case WM_CONSOLE			: return "WM_CONSOLE";
		}

		return "";
	}

	/*******************************************/
	public static String getIPstr(int[] bufIP, int ndx)
	{
		return ""+bufIP[ndx]+"."+bufIP[ndx+1]+"."+bufIP[ndx+2]+"."+bufIP[ndx+3];
	}

	/*******************************************/
	public static String getTypeNetwork(int type)
	{
		switch(type)
		{
			case MIB_IF_TYPE_OTHER		: return "OTHER";
			case MIB_IF_TYPE_ETHERNET	: return "ETHERNET";
			case MIB_IF_TYPE_TOKENRING	: return "TOKENRING";
			case MIB_IF_TYPE_FDDI		: return "FDDI";
			case MIB_IF_TYPE_PPP		: return "PPP";
			case MIB_IF_TYPE_LOOPBACK	: return "LOOPBACK";
			case MIB_IF_TYPE_SLIP		: return "SLIP";
		}

		return "";
	}

	/*******************************************/
	public static String getStatusSession(int status)
	{
		switch(status)
		{
			case WTS_CONSOLE_CONNECT		: return "CONSOLE_CONNECT";
			case WTS_CONSOLE_DISCONNECT		: return "CONSOLE_DISCONNECT";
			case WTS_REMOTE_CONNECT			: return "REMOTE_CONNECT";
			case WTS_REMOTE_DISCONNECT		: return "REMOTE_DISCONNECT";
			case WTS_SESSION_LOGGED			: return "SESSION_LOGGED";
			case WTS_SESSION_LOGON			: return "SESSION_LOGON";
			case WTS_SESSION_LOGOFF			: return "SESSION_LOGOFF";
			case WTS_SESSION_LOCK			: return "SESSION_LOCK";
			case WTS_SESSION_UNLOCK			: return "SESSION_UNLOCK";
			case WTS_SESSION_REMOTE_CONTROL	: return "SESSION_REMOTE_CONTROL";
		}

		return "";
	}

	/*******************************************/
	public static String getEventConsole(int evt)
	{
		switch(evt)
		{
			case CTRL_C_EVENT			: return "CTRL_C_EVENT";
			case CTRL_BREAK_EVENT		: return "CTRL_BREAK_EVENT";
			case CTRL_CLOSE_EVENT		: return "CTRL_CLOSE_EVENT";
			case CTRL_LOGOFF_EVENT		: return "CTRL_LOGOFF_EVENT";
			case CTRL_SHUTDOWN_EVENT	: return "CTRL_SHUTDOWN_EVENT";
		}

		return "";
	}

	/*******************************************/
	public static void logEvent(String[] data)
	{
		if(data != null)
			try
			{
				String path = Examples_Config.getRsrcPathname("event.log");

				PrintStream file = new PrintStream(new FileOutputStream(path,true));
				String s = "";

				for(int i=0;i < data.length;i++)
					s += (data[i]==null ? "" : data[i])+"\t";

				file.println(s.trim());
				file.close();
			}
			catch(Exception ex) {}
	}
}
