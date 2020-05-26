/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Package2
{
	public partial class UI_Button1 : GButton
	{
		public Controller m_button;
		public GGraph m_n0;
		public GGraph m_n1;
		public GGraph m_n2;

		public const string URL = "ui://cznjof93vpg52";

		public static UI_Button1 CreateInstance()
		{
			return (UI_Button1)UIPackage.CreateObject("Package2","Button1");
		}

		public UI_Button1()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_n0 = (GGraph)this.GetChildAt(0);
			m_n1 = (GGraph)this.GetChildAt(1);
			m_n2 = (GGraph)this.GetChildAt(2);
		}
	}
}