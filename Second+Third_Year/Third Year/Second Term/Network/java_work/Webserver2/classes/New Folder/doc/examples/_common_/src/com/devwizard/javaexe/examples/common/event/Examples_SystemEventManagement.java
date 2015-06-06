/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common.event;


import com.devwizard.javaexe.interfaces.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Examples_SystemEventManagement
	implements JavaExe_I_SystemEventManagement
{
	/*******************************************/
	public static int notifyEvent(Examples_I_LogEvent objLog, boolean isPrompt
		,int msg, int val1, int val2, String val3, int[] arr1, byte[] arr2)
	{
		switch(msg)
		{
			case WM_QUERYENDSESSION	: return notifyEvent_QUERYENDSESSION(objLog,isPrompt,val2);
			case WM_ENDSESSION		: return notifyEvent_ENDSESSION(objLog,val1,val2);
			case WM_DISPLAYCHANGE	: return notifyEvent_DISPLAYCHANGE(objLog,val1,val2);
			case WM_SYSCOMMAND		: return notifyEvent_SYSCOMMAND(objLog,val1,val2);
			case WM_COMPACTING		: return notifyEvent_COMPACTING(objLog,val1);
			case WM_POWERBROADCAST	: return notifyEvent_POWERBROADCAST(objLog,isPrompt,val1,val2,arr1,arr2);
			case WM_DEVICECHANGE	: return notifyEvent_DEVICECHANGE(objLog,isPrompt,val1,val3,arr1);
			case WM_NETWORK			: return notifyEvent_NETWORK(objLog,val1,val3,arr1);
			case WM_SESSION_CHANGE	: return notifyEvent_SESSION(objLog,val1,val2,val3,arr1);
			case WM_CONSOLE			: return notifyEvent_CONSOLE(objLog,isPrompt,val1);
		}

		if(objLog != null)
			objLog.logEvent(Examples_UtilsEvent.getMsgText(msg), ""+val1+" ; "+val2+" ; "+val3);

		return 1;
	}

	/*******************************************/
	static int notifyEvent_CONSOLE(Examples_I_LogEvent objLog, boolean isPrompt, int evt)
	{
		String type = Examples_UtilsEvent.getEventConsole(evt);
		boolean ret = true;

		if(isPrompt
		&& evt != CTRL_LOGOFF_EVENT && evt != CTRL_SHUTDOWN_EVENT)
			ret = Examples_UtilsGUI.showConfirmDialog("System Event","Do you want to break the console ?");

		if(objLog != null)
			objLog.logEvent("WM_CONSOLE", type+" => "+Boolean.toString(ret));

		return(ret ? 1 : 0);
	}

	/*******************************************/
	static int notifyEvent_QUERYENDSESSION(Examples_I_LogEvent objLog, boolean isPrompt, int bitMask)
	{
		String type = Examples_UtilsEvent.getTypeLogOff(bitMask);
		boolean ret = true;

		if(isPrompt)
			ret = Examples_UtilsGUI.showConfirmDialog("System Event","Do you continue the "+type);

		if(objLog != null)
			objLog.logEvent("WM_QUERYENDSESSION", type+" => "+Boolean.toString(ret));

		return(ret ? 1 : 0);
	}

	/*******************************************/
	static int notifyEvent_ENDSESSION(Examples_I_LogEvent objLog, int isEnd, int bitMask)
	{
		String arg = Examples_UtilsEvent.getTypeLogOff(bitMask);

		if(isEnd==1)
			arg += " -- Confirmed";
		else
			arg += " -- Canceled";

		if(objLog != null)
			objLog.logEvent("WM_ENDSESSION", arg);

		return 0;
	}

	/*******************************************/
	static int notifyEvent_DISPLAYCHANGE(Examples_I_LogEvent objLog, int bitsPixel, int wh)
	{
		int w = (wh & 0x0000FFFF);
		int h = ((wh>>16) & 0x0000FFFF);

		String arg = ""+w+"x"+h+", "+bitsPixel+" bits/pixel";

		if(objLog != null)
			objLog.logEvent("WM_DISPLAYCHANGE", arg);

		return 0;
	}

	/*******************************************/
	static int notifyEvent_SYSCOMMAND(Examples_I_LogEvent objLog, int type, int val)
	{
		String arg = ""+type;

		switch(type)
		{
			case SC_SCREENSAVE	:
				arg = "SC_SCREENSAVE : "+(val==1 ? "starting..." : "stopped");
				break;
		}

		if(objLog != null)
			objLog.logEvent("WM_SYSCOMMAND", arg);

		return 0;
	}

	/*******************************************/
	static int notifyEvent_NETWORK(Examples_I_LogEvent objLog, int type, String desc, int[] ip)
	{
		String arg = ""+type;

		switch(type)
		{
			case NET_CONNECTING	: arg = "CONNECTING to "+desc+"..."; break;
			case NET_DISCONNECT	: arg = "DISCONNECTED from "+desc; break;

			case NET_CONNECTED	:
				arg = "CONNECTED to "+desc
					+" (Type="+Examples_UtilsEvent.getTypeNetwork(ip[0])
					+" ; IP="+Examples_UtilsEvent.getIPstr(ip,1)
					+" ; Gateway="+Examples_UtilsEvent.getIPstr(ip,5)
					+" ; Mask="+Examples_UtilsEvent.getIPstr(ip,9)
					+")";

				break;
		}

		if(objLog != null)
			objLog.logEvent("WM_NETWORK", arg);

		return 0;
	}

	/*******************************************/
	static int notifyEvent_SESSION(Examples_I_LogEvent objLog, int status, int sessionID
		,String userName, int[] arr1)
	{
		String arg = Examples_UtilsEvent.getStatusSession(status)
			+ "(session="+sessionID
			+" ; user="+userName
			+ ((arr1 != null && arr1.length > 0 && arr1[0] != 0) ? " ; CURRENT" : "")
			+ ")";

		if(objLog != null)
			objLog.logEvent("WM_SESSION_CHANGE", arg);

		return 0;
	}

	/*******************************************/
	static int notifyEvent_COMPACTING(Examples_I_LogEvent objLog, int ratio)
	{
		double percent = (100.0 * ((double) ratio)) / 65536.0;
		percent = Math.floor(percent*100.0) / 100.0;

		if(objLog != null)
			objLog.logEvent("WM_COMPACTING", ""+percent+" % of CPU time");

		return 0;
	}

	/*******************************************/
	static int notifyEvent_POWERBROADCAST(Examples_I_LogEvent objLog, boolean isPrompt
		,int type, int val, int[] arr1, byte[] arr2)
	{
		String arg = ""+type;
		boolean ret = true;

		switch(type)
		{
			case PBT_APMSUSPEND				: arg = "PBT_APMSUSPEND"; break;
			case PBT_APMQUERYSUSPENDFAILED	: arg = "PBT_APMQUERYSUSPENDFAILED"; break;
			case PBT_APMRESUMECRITICAL		: arg = "PBT_APMRESUMECRITICAL"; break;
			case PBT_APMRESUMESUSPEND		: arg = "PBT_APMRESUMESUSPEND"; break;
			case PBT_APMRESUMEAUTOMATIC		: arg = "PBT_APMRESUMEAUTOMATIC"; break;
			case PBT_APMBATTERYLOW			: arg = "PBT_APMBATTERYLOW"; break;
			case PBT_APMOEMEVENT			: arg = "PBT_APMOEMEVENT : OEM="+val; break;

			case PBT_APMPOWERSTATUSCHANGE :
				arg = "PBT_APMPOWERSTATUSCHANGE";

				if(arr1 != null && arr2 != null)
					arg += " (AC="+Examples_UtilsEvent.getStatusPowerAC(arr2[0])
						+" ; "+Examples_UtilsEvent.getStatusPowerBattery(arr2[1])
						+" ; "+(arr2[2]==255 ? "?" : ""+arr2[2])+" %"
						+" ; "+Examples_UtilsEvent.getHHMMSS(arr1[0])+" / "+Examples_UtilsEvent.getHHMMSS(arr1[1])
						+")";

				break;

			case PBT_APMQUERYSUSPEND :
				if((val & 1) != 0 && isPrompt)
					ret = Examples_UtilsGUI.showConfirmDialog("System Event"
						,"The system entered a suspended state.\nDo you want to continue ?");

				arg = "PBT_APMQUERYSUSPEND ("+val+") => "+Boolean.toString(ret);
				break;
		}

		if(objLog != null)
			objLog.logEvent("WM_POWERBROADCAST",arg);

		return(ret ? 1 : 0);
	}

	/*******************************************/
	static int notifyEvent_DEVICECHANGE(Examples_I_LogEvent objLog, boolean isPrompt
		,int type, String val3, int[] arr1)
	{
		String arg = ""+type;
		boolean ret = true;

		switch(type)
		{
			case DBT_DEVICEARRIVAL :
				arg = "DBT_DEVICEARRIVAL (" + notifyEvent_DEVICECHANGE_HDR(val3, arr1) + ")";
				break;

			case DBT_DEVICEQUERYREMOVE :
				if(isPrompt)
					ret = Examples_UtilsGUI.showConfirmDialog("System Event"
						,"The system has requested a query to remove a device.\nDo you accept ?");

				arg = "DBT_DEVICEQUERYREMOVE (" + notifyEvent_DEVICECHANGE_HDR(val3, arr1)
					+ ") => "+Boolean.toString(ret);
				break;

			case DBT_DEVICEQUERYREMOVEFAILED :
				arg = "DBT_DEVICEQUERYREMOVEFAILED (" + notifyEvent_DEVICECHANGE_HDR(val3, arr1) + ")";
				break;

			case DBT_DEVICEREMOVEPENDING :
				arg = "DBT_DEVICEREMOVEPENDING (" + notifyEvent_DEVICECHANGE_HDR(val3, arr1) + ")";
				break;

			case DBT_DEVICEREMOVECOMPLETE :
				arg = "DBT_DEVICEREMOVECOMPLETE (" + notifyEvent_DEVICECHANGE_HDR(val3, arr1) + ")";
				break;

			case DBT_DEVICETYPESPECIFIC :
				arg = "DBT_DEVICETYPESPECIFIC (" + notifyEvent_DEVICECHANGE_HDR(val3, arr1) + ")";
				break;

			case DBT_CUSTOMEVENT :
				arg = "DBT_CUSTOMEVENT (" + notifyEvent_DEVICECHANGE_HDR(val3, arr1) + ")";
				break;

			case DBT_USERDEFINED :
				arg = "DBT_USERDEFINED (" + notifyEvent_DEVICECHANGE_HDR(val3, arr1) + ")";
				break;

			case DBT_QUERYCHANGECONFIG :
				if(isPrompt)
					ret = Examples_UtilsGUI.showConfirmDialog("System Event"
						,"The system has requested to dock or undock this computer.\nDo you accept ?");

				arg = "DBT_QUERYCHANGECONFIG => "+Boolean.toString(ret);
				break;

			case DBT_CONFIGCHANGED			: arg = "DBT_CONFIGCHANGED"; break;
			case DBT_CONFIGCHANGECANCELED	: arg = "DBT_CONFIGCHANGECANCELED"; break;
		}

		if(objLog != null)
			objLog.logEvent("WM_DEVICECHANGE",arg);

		return(ret ? 1 : 0);
	}

	/*******************************************/
	static String notifyEvent_DEVICECHANGE_HDR(String val3, int[] arr1)
	{
		String ret = "";

		switch(arr1[1])
		{
			case DBT_DEVTYP_OEM		: ret = "OEM="+arr1[3]+", "+arr1[4]; break;
			case DBT_DEVTYP_PORT	: ret = "port="+val3; break;

			case DBT_DEVTYP_VOLUME :
				ret = Examples_UtilsEvent.getVolumeUnits(arr1[3]);
				String type = Examples_UtilsEvent.getTypeVolume(arr1[4]);

				if(type != null)
					ret += " ; "+type;

				break;
		}

		return ret;
	}
}
