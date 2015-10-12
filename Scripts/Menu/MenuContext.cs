using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;


public class MenuContext : MVCSContext
{
    public MenuContext(MonoBehaviour view) : base(view) { }

    protected override void mapBindings()
    {
        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();
    }
}
