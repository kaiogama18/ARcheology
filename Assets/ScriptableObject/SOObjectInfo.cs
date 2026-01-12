using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ CreateAssetMenu(fileName = "New Object Info", menuName = "ScriptableObject/Object Info")]
public class SOObjectInfo : ScriptableObject
{
    public string title;
    public Sprite icon;
    [TextArea] public string description;
}
