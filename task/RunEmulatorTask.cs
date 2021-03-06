using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using Moscrif.IDE.Workspace;
using System.Diagnostics;
using Moscrif.IDE.Extensions;

namespace Moscrif.IDE.Task
{
	public class RunEmulatorTask : ITask
	{
		List<TaskMessage> output = new List<TaskMessage>();
		StateEnum stateTask = StateEnum.OK;
	
		public RunEmulatorTask()
		{
		}

		#region ITask implementation
		public void Initialize (object dataObject)
		{

		}


		public bool ExecuteTask ()
		{
			Tool.Logger.LogDebugInfo("RUN EMULATOR - Initialize",null);
			if (MainClass.Settings.ClearConsoleBeforRuning){
				MainClass.MainWindow.OutputConsole.Clear();
				Tool.Logger.LogDebugInfo("Clear console",null);
			}

			if(MainClass.MainWindow.RunningEmulator){
				output.Add( new TaskMessage(MainClass.Languages.Translate("emulator_is_running"),null,null));
				stateTask = StateEnum.ERROR;
				Tool.Logger.Error(MainClass.Languages.Translate("emulator_is_running"),null);
				return false;
			}


			if(String.IsNullOrEmpty(MainClass.Workspace.ActualResolution)){
				output.Add(new TaskMessage(MainClass.Languages.Translate("pleas_select_resolution"),null,null));
				Tool.Logger.Error(MainClass.Languages.Translate("pleas_select_resolution"),null);
				stateTask = StateEnum.ERROR;
				return false;
			}

			if (!File.Exists(MainClass.Workspace.ActualResolution)){
				output.Add(new TaskMessage(MainClass.Languages.Translate("resolution_file_not_exist",MainClass.Workspace.ActualResolution),null,null));
				Tool.Logger.Error(MainClass.Languages.Translate("resolution_file_not_exist",MainClass.Workspace.ActualResolution),null);
				stateTask = StateEnum.ERROR;
				return false;
			}

			if(MainClass.Workspace.ActualProject == null){
				output.Add(new TaskMessage(MainClass.Languages.Translate("no_project_selected"),null,null));
				Tool.Logger.Error(MainClass.Languages.Translate("no_project_selected"),null);
				stateTask = StateEnum.ERROR;
				return false;
			}

			string newPath =System.IO.Path.Combine(MainClass.Settings.EmulatorDirectory,"generic.ini");

			try{
				if (File.Exists(newPath)){
					Tool.Logger.LogDebugInfo(String.Format("Delete File ->{0}",newPath),null);
					File.Delete(newPath);
				}

				File.Copy(MainClass.Workspace.ActualResolution,newPath);
				Tool.Logger.LogDebugInfo(String.Format("File Copy {0} to {1}",MainClass.Workspace.ActualResolution,newPath),null);

				int selectOs = MainClass.Workspace.ActualDevice;

				Devices.Device d =  MainClass.Workspace.ActualProject.DevicesSettings.Find(x=>x.TargetPlatformId == selectOs);

				if(d != null){
					Tool.Logger.LogDebugInfo(String.Format("Device ->{0}",d.Devicetype),null);
					string font = "";
					if(d.Includes.Fonts != null && d.Includes.Fonts.Length>0){
						font =string.Join(" ",d.Includes.Fonts);
						font= font.Replace('/',System.IO.Path.DirectorySeparatorChar);
						font= font.Replace('\\',System.IO.Path.DirectorySeparatorChar);
					}
						using (StreamWriter stream = File.AppendText(newPath)) {
	
							stream.WriteLine();
							string fonts = font;
							stream.WriteLine("[emulation]");
							stream.WriteLine("fonts = " + fonts);

							if(d.Includes.Skin != null){
								stream.WriteLine("skin = "+ d.Includes.Skin.Name);
								stream.WriteLine("theme = " + d.Includes.Skin.Theme);
							}else {
								stream.WriteLine("skin = ");
								stream.WriteLine("theme = ");

						}
							stream.Flush();
							stream.Close();
							stream.Dispose();
						}

				}

			}catch (Exception ex){
				//output.Add("Create generic.ini failed!");
				output.Add(new TaskMessage(ex.Message));
				stateTask = StateEnum.ERROR;
				Tool.Logger.Error(ex.Message,null);
				return false;

			}
			string cmd = "";
			if(MainClass.Settings.EmulatorSettings == null){
				MainClass.Settings.EmulatorSettings = new Moscrif.IDE.Option.Settings.EmulatorSetting();
				MainClass.Settings.EmulatorSettings.UsDefault = true;
				
			}

			if(MainClass.Settings.EmulatorSettings.UsDefault){
				if(!GetDefaultCommand(out cmd)){
					return false;
				}
			} else {
				cmd = MainClass.Settings.EmulatorSettings.Exec;
			}


			AppFile appFile = MainClass.Workspace.ActualProject.AppFile;
			string projDir = Path.GetDirectoryName(appFile.ApplicationFile);
			if (!projDir.EndsWith(Path.DirectorySeparatorChar.ToString())) projDir += Path.DirectorySeparatorChar;
			string args = String.Format("/f {0} /d {1} /o console", Path.GetFileName(appFile.ApplicationFile), projDir);
			string wordDir = MainClass.Settings.EmulatorDirectory;

			if(MainClass.Settings.EmulatorSettings.UsDefault){
				wordDir = "";
				if(MainClass.Platform.IsMac){
					
					args = String.Format(" -f {0} -d {1} -o console", Path.GetFileName(appFile.ApplicationFile), projDir);
					
					Process []pArry = Process.GetProcesses();
					foreach(Process p in pArry)
					{
						if(p != null){
							try {
								string s = p.ProcessName;
								s = s.ToLower();
								
								if (s.CompareTo("moscrif") ==0){
									Tool.Logger.LogDebugInfo("Kill Emulator Mac",null);
									p.Kill();
									MainClass.MainWindow.RunningEmulator= false;
								}
								//string s = p.ProcessName;
								//s = s.ToLower();
								//Console.WriteLine("\t"+s);
							} catch {//(Exception ex){
								//Console.WriteLine(ex.Message);
								//Tool.Logger.Error(ex.Message,null);
							}
						}
					}
					
				} else {
					
					if(MainClass.Platform.IsWindows){
						Process []pArry = Process.GetProcesses();
						foreach(Process p in pArry)
						{
							try{
								string s = p.ProcessName;
								s = s.ToLower();
								
								if (s.CompareTo("moscrif") ==0){
									
									
									Tool.Logger.LogDebugInfo("Kill Emulator win",null);
									p.Kill();
									MainClass.MainWindow.RunningEmulator= false;
								}
							} catch{
								//Console.WriteLine(ex.Message);
								//Tool.Logger.Error(ex.Message,null);;
							}
						}
					}
				}
			} else {
				args = String.Format(MainClass.Settings.EmulatorSettings.Params, Path.GetFileName(appFile.ApplicationFile), projDir);

			}


			try{
				Tool.Logger.LogDebugInfo(String.Format("command ->{0}",cmd),null);
				Tool.Logger.LogDebugInfo(String.Format("arguments ->{0}",args),null);
				Tool.Logger.LogDebugInfo("RUN EMULATOR -Start",null);
				MainClass.MainWindow.RunEmulator(cmd, args,wordDir ,ProcessOutputChange);

			}catch (Exception ex){

				output.Add(new TaskMessage(ex.Message));
				stateTask = StateEnum.ERROR;
				Tool.Logger.Error(ex.Message,null);
				return false;
			}

			return true;
		}

		private bool GetDefaultCommand(out string cmd){
			cmd = Path.Combine(MainClass.Settings.EmulatorDirectory,  "moscrif.exe");
			
			if(MainClass.Platform.IsMac){
				
				string file = System.IO.Path.Combine( MainClass.Settings.EmulatorDirectory,  "Moscrif.app");//.app
				
				if(!System.IO.Directory.Exists(file) ){
					output.Add(new TaskMessage(MainClass.Languages.Translate("emulator_not_found")));
					stateTask = StateEnum.ERROR;
					Tool.Logger.Error(MainClass.Languages.Translate("emulator_not_found"),null);
					return false;
				}
				
				file = System.IO.Path.Combine(file,  "Contents");
				file = System.IO.Path.Combine(file,  "MacOS");
				file = System.IO.Path.Combine(file,  "Moscrif");
				cmd = file;

				if(!System.IO.File.Exists(file) ){
					output.Add(new TaskMessage(MainClass.Languages.Translate("emulator_not_found")));
					stateTask = StateEnum.ERROR;
					Tool.Logger.Error(MainClass.Languages.Translate("emulator_not_found"),null);
					return false;
				}
				
			} else {
				if(!System.IO.File.Exists(cmd)  ){
					output.Add(new TaskMessage(MainClass.Languages.Translate("emulator_not_found")));
					stateTask = StateEnum.ERROR;
					Tool.Logger.Error(MainClass.Languages.Translate("emulator_not_found"),null);
					return false;
				}
			}
			return true;
		}

		void ProcessOutputChange(object sender, string message)
		{
			//Gtk.Application.Invoke(delegate
			//{
			//this.output.Add( new TaskMessage(">> " + message.Trim() + "<<"));

			MainClass.MainWindow.OutputConsole.WriteText(message);
			Console.WriteLine(message);
			//return;
			/*string msg = message.Trim();
			if (String.IsNullOrEmpty(msg))
				return;*/

			
			/*string fileDitr = "";
			if (sender.GetType() == typeof(ProcessWrapper)) {
				ProcessWrapper pw = (ProcessWrapper)sender;
				if (pw.StartInfo != null) {
					fileDitr = pw.StartInfo.WorkingDirectory;
				}
				//(sender as ProcessWrapper).
			}*/

			ParseOutput(message);
			//Console.WriteLine(">> " + message.Trim() + "<<");
			//});
		}
		// not uses
		public void OnTaskOutputChanged(object sender, string name, string status, List<TaskMessage> errors){
			if(TaskOutputChanged!= null)
				TaskOutputChanged(sender, name,status, errors);

		}

		public void OnEndTaskWrite(object sender, string name, string status, List<TaskMessage> errors){
			if(EndTaskWrite!= null)
				EndTaskWrite(sender, name,status, errors);

		}		

		public event ProcessTaskHandler TaskOutputChanged;
		public event ProcessErrorHandler ErrorWrite;
		public event ProcessErrorHandler LogWrite;
		public event ProcessTaskHandler EndTaskWrite;

		void ITask.StopTask()
		{
		}

		private string messageError;
		private bool isLog; // novy text
		private bool isOldLog; // predchadzajuci text

		private void ParseOutput(string message)
		{

			//Console.WriteLine("message->>>>>> {0} <<<<<<<<",message );


			//string[] messageSeparators = new string[] {"\n\n"};
			//string[] stringSeparators = new string[] {"\n"};//\n\n

			//string[] allMessage =message.Split(messageSeparators,StringSplitOptions.RemoveEmptyEntries); 

			//foreach(string b in allMessage){

			string endMessage ="\n\n";//"\n\n"

			message = message.Replace("\r\n","\n");
			message = message.Replace("\n\r","\n");
			message = message.Replace("\r\r","\n");
			message = message.Replace("\r","\n");
			//string[] allLine = message.Split(messageSeparators,StringSplitOptions.RemoveEmptyEntries);
			//IEnumerable<string> allLine = message.SplitAndKeep (endMessage);
			//string[] allLine = message.Split (stringSeparators,StringSplitOptions.None);
			IEnumerable<string> allLine = message.SplitAndKeep ("\n");

			//string temp =  message.Replace("\r","*");
			//temp = temp.Replace("\n","»");
			//Console.WriteLine("temp ->{0}",temp);

			/*foreach (string a in allLine)
				Console.WriteLine("------>"+a);*/

			foreach (string a in allLine){
				message = a;
				//Console.WriteLine("------>"+a+"<------");

				//MatchCollection match = Regex.Matches( dataBlock, @"(ERROR:.*?\t.*?\t.*?\t)", RegexOptions.Singleline );
				int indx = message.IndexOf("Error:");  // start erroru
				//Console.WriteLine("indx ->"+indx);

				if (indx >-1 ) isLog = false;

				if (indx <0){
					indx = message.IndexOf("Log-I:");
					 if (indx >-1 ) isLog = true;
				}
				if (indx <0){
					indx = message.IndexOf("Log-E:");
					if (indx >-1 ) isLog = true;
				}
				if (indx <0){
					indx = message.IndexOf("Log-W:");
					if (indx >-1 ) isLog = true;
				}

				if (indx > -1) {
					// pred touto spravou existuje stara v buffry tak ju spracujem.
					if (!String.IsNullOrEmpty(messageError)){

						if(isOldLog)
							GetLog(messageError);
						else GetError(messageError);

						messageError = "";
					}

					isOldLog = isLog;

					if(!message.Contains(endMessage)){
						messageError  = messageError +message;
						continue; // neukonceny error
					}

					messageError = message; //.Remove(0, indx + 6);

					// odoberem staru spravu
					if (indx>0) messageError = messageError.Remove(0,indx);

						if(isLog)
							GetLog(messageError);
						else GetError(messageError);
					messageError = "";
					continue;

				} else {
					messageError  = messageError +message;
					if(!messageError.Contains(endMessage)){
						continue; // neukonceny error
					}

					indx = messageError.IndexOf("Error:");
					if (indx <0){
						indx = messageError.IndexOf("Log-I:");
					}
					if (indx <0){
						indx = messageError.IndexOf("Log-E:");
					}
					if (indx <0){
						indx = messageError.IndexOf("Log-W:");
					}
					if (indx>0) messageError = messageError.Remove(0,indx);

					if(isOldLog)
						GetLog(messageError);
					else GetError(messageError);
					messageError = "";
				}
			}
			//}
		}

		private TaskMessage GetError(string message){
			TaskMessage tm =new TaskMessage();
			if(String.IsNullOrEmpty(message)) return null;
			
			try{
				//Console.WriteLine("message_->"+message+"<-");
				//Log-I: Log-W: Log-E:
				message= message.Replace("Error:","" );

				message =message.Replace("\t","»");

				message =message.Replace("\n\r","");
				message =message.Replace("\r\n","");
				message =message.Replace("\n","");
				message =message.Replace("\r","");

				//Console.WriteLine("messageError -> "+ message);

				//Console.WriteLine("message_1->"+message+"<-");

				string[] msg = message.Split('»');

				//Console.WriteLine("match.Count -> "+ msg.Length);

				if (msg.Length <3){
					//Tool.Logger.Error("message ->"+message+"<");
					return null;
				}

				/*foreach(string m in msg){
					Console.WriteLine(m);
				}*/

				//Console.WriteLine("msg.Length ->"+msg.Length);

				string error = msg[0];
				string filename = msg[1];
				string line =msg[2];

				if (msg[1].StartsWith("at") ){

					if (msg.Length <4){
						//Tool.Logger.Error("message ->"+message+"<");
						return null;
					}

					filename = msg[2];
					line =msg[3];

					//int indx = 4; // spracovanie dalsich vetiev (kazda zacina na at)
					if (msg.Length >4)
						tm.Child = GetChild(msg,4);

				}
				else{
					filename = msg[1];
					line =msg[2];
				}
				filename = filename.Replace('/',System.IO.Path.DirectorySeparatorChar);

				//Console.WriteLine("error -> "+ error);
				//Console.WriteLine("filename -> "+ filename);
				//Console.WriteLine("line -> "+ line);

				//tm =new TaskMessage(error, filename, line);
				tm.Message = error;
				tm.Line = line;
				tm.File = filename;

				this.output.Add(tm);
				this.stateTask = StateEnum.ERROR;
				messageError = null;

				if (ErrorWrite!=null){
					ErrorWrite(this,this.Name,this.StateTask.ToString(),tm);
				}


			} catch {

			}
				return tm;
		}

		private TaskMessage GetChild(string[] msg, int indx){

			TaskMessage tmChild =new TaskMessage();

			if (msg[indx].StartsWith("at")){

			indx++;

			if (indx >= msg.Length) return null;

			string fname = msg[indx].Replace('/',System.IO.Path.DirectorySeparatorChar);
			tmChild.File =  fname;
			indx ++;

			if (indx < msg.Length) { // line tam byt nemusi
				if (!msg[indx].StartsWith("at"))
					tmChild.Line =  msg[indx];
				else indx--; // ak tam line nieje (zacina na at) vratim index vratim index naspet

					indx++;
					if (indx >= msg.Length) return tmChild;

					tmChild.Child =GetChild(msg,indx);
				}
			}
			return tmChild;
		}

		private TaskMessage GetLog(string message){

			TaskMessage tm =new TaskMessage();
			try{
				//Log-I: Log-W: Log-E:
				message= message.Replace("LOG-I","" );
				message= message.Replace("LOG-W","" );
				message= message.Replace("LOG-E","" );

				message =message.Replace("\t","»");

				message =message.Replace("\n\r","");
				message =message.Replace("\r\n","");
				message =message.Replace("\n","");
				message =message.Replace("\r","");

				//Console.WriteLine("messageError -> "+ message);

				string[] msg = message.Split('»');

				//Console.WriteLine("match.Count -> "+ msg.Length);

				if (msg.Length <3){
					//Tool.Logger.Error("message ->"+message+"<");
					return null;
				}

				string  filename= msg[0];
				string  line= msg[1];
				string  error=msg[2];

				filename = filename.Replace('/',System.IO.Path.DirectorySeparatorChar);

				tm =new TaskMessage(error, filename, line);

				//this.output.Add(tm);
				this.stateTask = StateEnum.ERROR;
				messageError = null;

				if(filename.Contains("Log-E:")){
					//Console.WriteLine("YES LOGE");
					if (ErrorWrite!=null){
						TaskMessage tm2 = new TaskMessage(error,"","");

						//Console.WriteLine("YES ProcessErrorHandler");
						ErrorWrite(this,this.Name,this.StateTask.ToString(),tm2);
					}
				} //else {

					if (LogWrite!=null){
						LogWrite(this,this.Name,this.StateTask.ToString(),tm);
					}
				//}


			} catch {

			}
				return tm;
		}

		public string Name {
			get {
				return "Running";
			}
		}

		public StateEnum StateTask {
			get {
				return stateTask;
			}
		}

		public List<TaskMessage> Output {
			get {
				return output;
			}
		}

		public ITask ChildrenTask {
			get {
				return null;
			}
		}
		#endregion
}
}

