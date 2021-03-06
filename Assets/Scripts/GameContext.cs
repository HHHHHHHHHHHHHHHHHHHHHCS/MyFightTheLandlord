﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.context.impl;
using strange.extensions.context.api;
using strange.framework.api;

public class GameContext : MVCSContext
{
    public GameContext(MonoBehaviour view, bool autoMapping) 
        : base(view, autoMapping)
    {
    }

    protected override void mapBindings()
    {
        //model
        injectionBinder.Bind<IntegrationModel>().To<IntegrationModel>().ToSingleton();

        //command
        commandBinder.Bind(CommandEvent.ChangeMultiple).To<ChangeMultipleCommand>();

        //view
        mediationBinder.Bind<StartView>().To<StartMediator>();

        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();
    }
}
