using System;
using System.Xml;
using System.Xml.Serialization;

namespace Moscrif.IDE.Iface.Entities
{
	public class Account
	{
		public Account()
		{
			this.LicenseId = "-100";
		}

		[XmlAttribute("token")]
		public string Token{
			get;
			set;
		}

		[XmlAttribute("login")]
		public string Login{
			get;
			set;
		}

		[XmlAttribute("name")]
		public string Name{
			get;
			set;
		}

		[XmlAttribute("remember")]
		public bool Remember{
			get;
			set;
		}

		[XmlAttribute("licence")]
		public string LicenseId{
			get;
			set;
		}

		//[XmlAttribute("licences")]
		private License license;
		[XmlIgnore]
		public License License{
			get{
				//if(licenses!=null)
				//	return licenses;
				license = MainClass.LicencesSystem.GetLicence(LicenseId);
				return license;
			}
		}
	}
}

