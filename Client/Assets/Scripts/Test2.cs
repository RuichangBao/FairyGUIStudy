using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

using Package2;

/// <summary>
/// 静态加载页面 脚本挂在FairyGUI的panel上
/// </summary>
public class Test2 : MonoBehaviour
{
	//静态加载页面
	// Use this for initialization
	void Start()
	{
		UIPanel panel = this.GetComponent<UIPanel>();
		GComponent gComponent = panel.ui;
		UI_TestCom2 uI_TestCom2 = gComponent as UI_TestCom2;
		Debug.LogError(uI_TestCom2==null);
		gComponent.GetChild("n1").onClick.Add(() => { Debug.LogError("点击了第一个按钮"); });
		gComponent.GetChild("n2").onClick.Add(() => { Debug.LogError("点击了第二个按钮"); });
	}

}