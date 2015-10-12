using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;


public class GameContext : MVCSContext
{
    public GameContext(MonoBehaviour view) : base(view) { }

    protected override void mapBindings()
    {
        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();
    }
}