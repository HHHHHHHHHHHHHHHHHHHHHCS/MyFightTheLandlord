using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;

public class StartCommand : Command
{
    [Inject]
    public IntegrationModel IntegrationModel { get; set; }

    public override void Execute()
    {
        Tool.CreateUIPanel(PanelType.StartPanel);
        IntegrationModel.OnInitIntegrationModel();
    }
}
