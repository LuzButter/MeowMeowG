using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Massage[] message;
    public actorID[] actor;
}

[System.Serializable]
public class Massage
{
    public int actorID;
    public string message;
}

[System.Serializable]
public class actorID
{
    public string name;
    public Sprite sprite;
}