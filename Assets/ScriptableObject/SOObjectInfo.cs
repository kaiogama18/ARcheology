using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ CreateAssetMenu(fileName = "New Object Info", menuName = "ScriptableObject/Object Info")]
public class SOObjectInfo : ScriptableObject
{
    public string title;
    [TextArea] public string description;
}
