﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//这是一个管理全局变量的脚本
public class GlobalModel : MonoBehaviour {
	public static int Currentlevel;//当前关卡

	public static Dictionary<string, GameObject> NoteCollection = new Dictionary<string, GameObject>();
	public static Dictionary<string, GameObject> InstrumentsCollection = new Dictionary<string, GameObject>();


}
