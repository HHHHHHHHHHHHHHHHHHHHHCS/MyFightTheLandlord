using strange.extensions.command.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMultipleCommand:EventCommand
{
    [Inject]
    public IntegrationModel IntegrationModel { get; set; }

    public override void Execute()
    {
        //1.改变model
        IntegrationModel.Multiple *= (int)evt.data;
    }
}
