using strange.extensions.mediation.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMediator : EventMediator
{
    [Inject]
    public StartView StartView { get; set; }

    public override void OnRegister()
    {
        StartView.oneButton.onClick.AddListener(OnClickOneButton);
        StartView.twoButton.onClick.AddListener(OnClickTwoButton);
    }

    public override void OnRemove()
    {
        StartView.oneButton.onClick.RemoveAllListeners();
        StartView.twoButton.onClick.RemoveAllListeners();
    }

    private void OnClickOneButton()
    {
        dispatcher.Dispatch(CommandEvent.ChangeMultiple,1);
        Destroy(StartView.gameObject);
    }

    private void OnClickTwoButton()
    {
        dispatcher.Dispatch(CommandEvent.ChangeMultiple, 2);
        Destroy(StartView.gameObject);
    }

}
