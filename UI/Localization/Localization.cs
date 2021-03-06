﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//本地化，不同语言的文字会存储在不同JSON文件中

	public class Localization 
    {
        /* Language Types */
        public const string CHINESE = "Localization/Chinese.json";
        public const string ENGLISH = "Localization/English.json";

        private string _language;
        public string Language
        {
            get
            {
                return _language;
            }
            set
            {
                _language = value;
                TextAsset asset = Resources.Load<TextAsset>(_language);
                //_languageNode = SimpleJSON.JSON.Parse(asset.text);
            }
        }

        /*private SimpleJSON.JSONNode _languageNode;

        private Localization()
        {
            Language = CHINESE;
        }

        public string GetText(string id)
        {
            return _languageNode[id];
        }*/
	}
