using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/NeedData", order = 1)]
public class NeedData : ScriptableObject
{
    public int priority = 0;
    public string name;
    public AnimationCurve unitCurve = null;
    public float floor;
    public Range range;
    public Action action;

    [ContextMenu("SetDefaultName")]
    public void FileNameToNameField()
    {
        name = Path.GetFileNameWithoutExtension(AssetDatabase.GetAssetPath(this));
    }
}
