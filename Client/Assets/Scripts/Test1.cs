using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
using Package1;
using System;
using System.Reflection;

/// <summary>
/// 动态加载UI 用代码加载FairyGUI页面
/// </summary>
public class Test1 : MonoBehaviour
{
	
	void Start()
	{
		UIPackage.AddPackage("FairyGUI/Package1");

		//GObject gObject = UIPackage.CreateObject("Package1", "TestCom1");
		//GComponent view = gObject.asCom;

		//以下几种方式都可以将view显示出来：

		//1，直接加到GRoot显示出来
		//GRoot.inst.AddChild(view);


		//2，使用窗口方式显示
		//gameObject.transform.SetParent(gObjec);
		Package1Binder.BindAll();
		UI_TestCom1 UIpage = UI_TestCom1.CreateInstance();
		Window aWindow = new Window();
		aWindow.contentPane = UIpage;
		aWindow.Show();


		
		//UI_TestCom1 UIpage = UI_TestCom1.CreateInstance();
		UIpage.m_n1.onClick.Add(() => { Debug.LogError("AAAAAA"); });
	}
}