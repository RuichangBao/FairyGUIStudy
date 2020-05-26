/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Package1
{
	public partial class UI_TestCom1 : GComponent
	{
		public GImage m_n0;
		public UI_Button1 m_n1;
		public UI_Button1 m_n2;

		public const string URL = "ui://clcclp1vhb990";

		public static UI_TestCom1 CreateInstance()
		{
			return (UI_TestCom1)UIPackage.CreateObject("Package1","TestCom1");
		}

		public UI_TestCom1()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_n0 = (GImage)this.GetChildAt(0);
			m_n1 = (UI_Button1)this.GetChildAt(1);
			m_n2 = (UI_Button1)this.GetChildAt(2);
		}
	}
}