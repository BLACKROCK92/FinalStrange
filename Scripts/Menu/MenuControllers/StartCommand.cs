using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class StartCommand : EventCommand
{
   [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    public override void Execute()
    {
        GameObject canvasResource = Resources.Load<GameObject>("menu/Canvas");
        GameObject canvasGo = GameObject.Instantiate(canvasResource) as GameObject;
        canvasGo.name = "CanvasMenu";
        canvasGo.transform.parent = contextView.transform;
    }
}
