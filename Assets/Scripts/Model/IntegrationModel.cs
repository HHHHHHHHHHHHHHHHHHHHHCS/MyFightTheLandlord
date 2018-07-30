using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegrationModel
{
    private int basePoint;  //底分
    private int multiple;   //倍数
    private int playerIntegration;  //玩家分数
    private int leftIntegration;    //左边分数
    private int rightIntegration;   //右边分数

    /// <summary>
    /// 底分
    /// </summary>
    public int BasePoint
    {
        get
        {
            return basePoint;
        }

        set
        {
            basePoint = Mathf.Max(value, 0);
        }
    }

    /// <summary>
    /// 倍数
    /// </summary>
    public int Multiple
    {
        get
        {
            return multiple;
        }

        set
        {
            multiple = Mathf.Max(value, 0);
        }
    }

    /// <summary>
    /// 最后的分数
    /// </summary>
    public int Result
    {
        get
        {
            return Multiple * BasePoint;
        }
    }

    /// <summary>
    /// 玩家的分数
    /// </summary>
    public int PlayerIntegration
    {
        get
        {
            return playerIntegration;
        }

        set
        {
            playerIntegration = Mathf.Max(value, 0);
        }
    }

    /// <summary>
    /// 左边的分数
    /// </summary>
    public int LeftIntegration
    {
        get
        {
            return leftIntegration;
        }

        set
        {
            leftIntegration = Mathf.Max(value, 0);
        }
    }

    /// <summary>
    /// 右边的分数
    /// </summary>
    public int RightIntegration
    {
        get
        {
            return rightIntegration;
        }

        set
        {
            rightIntegration = Mathf.Max(value, 0);
        }
    }

    public  IntegrationModel OnInitIntegrationModel()
    {
        BasePoint = 100;
        Multiple = 1;
        PlayerIntegration = 1500;
        LeftIntegration = 1500;
        RightIntegration = 1500;
        return this;
    }

    public IntegrationModel OnInitIntegrationModel(int basePoint, int multiple, int playerIntegration, int leftIntegration, int rightIntegration)
    {
        this.basePoint = basePoint;
        this.multiple = multiple;
        this.playerIntegration = playerIntegration;
        this.leftIntegration = leftIntegration;
        this.rightIntegration = rightIntegration;
        return this;
    }
}
