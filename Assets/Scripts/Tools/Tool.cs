using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class Tool 
{
    private const string prefabPath = "Prefabs";
    private const string uiPath = prefabPath+"/UI";


    public static GameObject CreateUIPanel(PanelType panelType)
    {
        string name = panelType.ToString();
        string path = Path.Combine(uiPath , name);
        GameObject panelPrefab = AssetLoader.LoadAsset<GameObject>(path);
        GameObject result = null;
        if (panelPrefab == null)
        {
            Debug.Log("CreateUIPanel is null    path:" + panelType);
        }
        else
        {
            result = Object.Instantiate(panelPrefab, ObjectFinder.UiRoot);
            result.name = name;
        }
        return result;
    }


    public static T LoadAsset<T>(string path) where T : Object
    {
        return ResourcesLoad<T>(path);//todo:这里暂时做resources 之后会用AB代替
    }


    private static T ResourcesLoad<T>(string path)where T:Object
    {
        return Resources.Load<T>(path);
    }


}
