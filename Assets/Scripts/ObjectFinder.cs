using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFinder 
{
    private static Transform uiRoot;

    public static Transform UiRoot
    {
        get
        {
            if (uiRoot == null)
            {
                uiRoot = GameObject.Find("UIRoot").transform;
            }
            return uiRoot;
        }
    }
}
