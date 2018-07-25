using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AssetLoader
{
    private const string prefabPath = "Prefabs";
    private const string uiPath = prefabPath + "/UI";


    public static T LoadAsset<T>(string path) where T : Object
    {
        return ResourcesLoad<T>(path);//todo:这里暂时做resources 之后会用AB代替
    }


    private static T ResourcesLoad<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }
}
