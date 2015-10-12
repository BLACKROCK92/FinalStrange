using UnityEngine;
using System.Collections;

public class ChangeLevelScript : MonoBehaviour
{
    public void ChangeScene(string levelID)
    {
        Application.LoadLevel("" + levelID);
    }
}

