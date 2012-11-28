using System;
using Gtk;
using Moscrif.IDE.Option;

namespace Moscrif.IDE.Option
{

	internal class ProxyPanel : OptionsPanel
	{
		ProxyWidget widget;
		
		public override Widget CreatePanelWidget()
		{
			return widget = new ProxyWidget();
		}
		
		public override void ApplyChanges()
		{
			widget.Store();
		}
		
		public override bool ValidateChanges()
		{
			return true;
		}
		
		public override void Initialize(PreferencesDialog dialog, object dataObject)
		{
			base.Initialize(dialog, dataObject);
		}
		
		public override string Label {
			get { return MainClass.Languages.Translate("proxy"); }
		}
		
		public override string Icon {
			get { return "file-ms.png"; }
		}
		
	}

	public partial class ProxyWidget : Gtk.Bin
	{
		public ProxyWidget()
		{
			this.Build();
			if(MainClass.Settings.Proxy== null){
				MainClass.Settings.Proxy = new Settings.ProxySetting();
			}

			switch(MainClass.Settings.Proxy.ProxyType){
				case 0:{
					rbNoProxy.Active = true;
					break;
				}
				case 1:{
					rbSystemProxy.Active = true;
					break;
				}
				case 2:{
					rbCustomProxy.Active = true;
					break;
				}

			}
			if(!String.IsNullOrEmpty(MainClass.Settings.Proxy.Name))
				entrName.Text = MainClass.Settings.Proxy.Name;

			if(!String.IsNullOrEmpty(MainClass.Settings.Proxy.Password))
				entrPassword.Text = MainClass.Settings.Proxy.Password;

			if(!String.IsNullOrEmpty(MainClass.Settings.Proxy.Proxy))
				entrProxy.Text = MainClass.Settings.Proxy.Proxy;

			sbPort.Value = MainClass.Settings.Proxy.Port;

		}
		public void Store()
		{
			if(rbNoProxy.Active){
				MainClass.Settings.Proxy.ProxyType = 0;

			} else if ( rbCustomProxy.Active){
				MainClass.Settings.Proxy.ProxyType = 2;
				MainClass.Settings.Proxy.Name= entrName.Text;
				MainClass.Settings.Proxy.Password= entrPassword.Text;
				MainClass.Settings.Proxy.Proxy= entrProxy.Text;

				MainClass.Settings.Proxy.Port= (int)sbPort.Value;

			} else {
				MainClass.Settings.Proxy.ProxyType = 1;
			}

		}

		protected void OnRbNoProxyToggled (object sender, EventArgs e)
		{
			frmProxyConfiguration.Sensitive = false;
		}

		protected void OnRbSystemProxyToggled (object sender, EventArgs e)
		{
			frmProxyConfiguration.Sensitive = false;
		}

		protected void OnRbCustomProxyToggled (object sender, EventArgs e)
		{
			frmProxyConfiguration.Sensitive = true;
		}
	}
}

