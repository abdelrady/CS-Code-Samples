using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;
using System.Configuration;
using System.Threading;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GameKiller 
{
	/// <summary>
	/// Summary description for Global.
	/// </summary>
	public class Global : System.Web.HttpApplication
	{
		private static bool m_bInitialized = false;
		private static ArrayList m_oGameList = new ArrayList();
		private static Hashtable m_oGameRecords = new Hashtable();
		private static Thread m_oKiller = null;
		public static string m_sMainFolder = null;
		
		public static void Kill(int nProcessID)
		{
			Process[] pList = Process.GetProcesses();
			for(int i=0;i<pList.Length;i++)
			{
				if(pList[i].Id==nProcessID) pList[i].Kill();
			}
		}

		public static void Add(string sGame, int nTime, int nDelay)
		{
			lock(typeof(Global))
			{
				sGame = sGame.Trim().ToLower();
				object[] pItem = {sGame, nTime, nDelay};
				bool bFound = false;
				for(int i=0;i<m_oGameList.Count;i++)
				{
					if(((object[])m_oGameList[i])[0].ToString()==sGame)
					{
						m_oGameList[i] = pItem;
						bFound = true;
						break;
					}
				}
				if(bFound==false) m_oGameList.Add(pItem);
			}
		}

		public static void Restart()
		{
			lock(typeof(Global))
			{
				try
				{
					if(m_oKiller!=null) m_oKiller.Abort();
				}
				catch(Exception) {}
				finally { m_oKiller = null; }
				m_oKiller = new Thread(new ThreadStart(KillerProc));
				m_oKiller.Start();
			}
		}

		private static void KillerProc()
		{
			bool bStartUp = true;
			while(true)
			{
				try
				{
					DateTime oNow = DateTime.Now;
					bool bBadTimeKill = false;
					object oCheckTime = m_oGameRecords["CheckTime"];
					if(oCheckTime==null) m_oGameRecords["CheckTime"] = oNow;
					else 
					{
						DateTime oSavedTime = Convert.ToDateTime(oCheckTime);
						if(oNow<oSavedTime) bBadTimeKill = true;
						else m_oGameRecords["CheckTime"] = oNow;
						if(bStartUp==false&&oNow>oSavedTime.AddMinutes(10)) m_oGameRecords["CheckTime"] = oNow.AddHours(3);
					}
					if(bStartUp) bStartUp = false;
					ArrayList oKilledGames = new ArrayList();
					Process[] pList = Process.GetProcesses();
					for(int i=0;i<pList.Length;i++)
					{
						try
						{
							bool bFound = false;
							string sFilePath = pList[i].MainModule.FileName.ToLower();
							string sGame = null;
							int nTime = 0;
							int nDelay = 0;
							lock(typeof(Global))
							{
								for(int j=0;j<m_oGameList.Count;j++)
								{
									object[] pItem = (object[])m_oGameList[j];
									if(sFilePath.EndsWith(pItem[0].ToString()))
									{
										sGame = pItem[0].ToString();
										nTime = Convert.ToInt32(pItem[1]);
										nDelay = Convert.ToInt32(pItem[2]);
										if(nTime<=0||bBadTimeKill) pList[i].Kill();
										else bFound = true;
										break;
									}
								}
							}
							if(bFound)
							{
								if(m_oGameRecords[sGame]==null)
								{
									m_oGameRecords[sGame] = oNow;
								}
								else
								{
									DateTime oStamp = Convert.ToDateTime(m_oGameRecords[sGame]);
									if(oNow>oStamp.AddMinutes(nTime))
									{
										if(nDelay<=0) nDelay = (ConfigurationSettings.AppSettings["GameDelay"]==null?120:Convert.ToInt32(ConfigurationSettings.AppSettings["GameDelay"]));
										if(oNow<oStamp.AddMinutes(nTime+nDelay))  pList[i].Kill();
										else oKilledGames.Add(sGame);
									}
								}
							}
						}
						catch(Exception) {}
						finally { Thread.Sleep(10); }
					}
					for(int i=0;i<oKilledGames.Count;i++)
					{
						string sGame = oKilledGames[i].ToString();
						if(m_oGameRecords[sGame]!=null) m_oGameRecords.Remove(sGame);
					}
				}
				catch(Exception) {}
				finally 
				{
					int nInterval = (ConfigurationSettings.AppSettings["CheckInterval"]==null?15:Convert.ToInt32(ConfigurationSettings.AppSettings["CheckInterval"]));				
					Thread.Sleep(nInterval*1000); 
				}
			}
		}

		private static bool InitKiller()
		{
			try
			{
				m_oGameList.Clear();
				string[] pGameList = ConfigurationSettings.AppSettings["GameList"].Split(";".ToCharArray());
				for(int i=0;i<pGameList.Length;i++)
				{
					if(pGameList[i]!="")
					{
						string[] pItem = pGameList[i].Split(",".ToCharArray());
						if(pItem.Length>=2)
						{
							string sGame = pItem[0].Trim ().ToLower();
							int nTime = Convert.ToInt32(pItem[1]);
							int nDelay = (pItem.Length==2)?0:Convert.ToInt32(pItem[2]);
							Add(sGame,nTime,nDelay);
						}
					}
				}
				Restart();
				return true;
			}
			catch(Exception) { return false; }
		}

		private System.ComponentModel.IContainer components = null;

		public Global()
		{
			InitializeComponent();
		}	
		
		protected void Application_Start(Object sender, EventArgs e)
		{
			m_sMainFolder = Server.MapPath(".");
			try
			{
				if(File.Exists(m_sMainFolder+"\\GameKiller.data"))
				{
					IFormatter oFormatter = new BinaryFormatter();
					Stream oStream = new FileStream(m_sMainFolder+"\\GameKiller.data",FileMode.Open,FileAccess.Read,FileShare.Read);
					m_oGameRecords = (Hashtable)oFormatter.Deserialize(oStream);
					oStream.Close();
				}
			}
			catch(Exception) { }
			m_bInitialized = InitKiller();
		}
 
		protected void Session_Start(Object sender, EventArgs e)
		{
			lock(typeof(Global))
			{
				if(m_bInitialized==false) m_bInitialized = InitKiller();
			}
		}

		protected void Application_BeginRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_EndRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_Error(Object sender, EventArgs e)
		{

		}

		protected void Session_End(Object sender, EventArgs e)
		{

		}

		protected void Application_End(Object sender, EventArgs e)
		{
			try
			{
				IFormatter oFormatter = new BinaryFormatter();
				Stream oStream = new FileStream(m_sMainFolder+"\\GameKiller.data",FileMode.Create,FileAccess.Write,FileShare.None);
				oFormatter.Serialize(oStream,m_oGameRecords);
				oStream.Close();
			}
			catch(Exception) { }
		}
			
		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.components = new System.ComponentModel.Container();
		}
		#endregion
	}
}

