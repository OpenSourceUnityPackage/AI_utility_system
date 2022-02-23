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
    public string needName = null;
    public int priority = 0;
    public AnimationCurve unitCurve = null;
    public float floor;
    public Range range;
    public Action action;

    [ContextMenu("SetDefaultName")]
    public void FileNameToNameField()
    {
        needName = Path.GetFileNameWithoutExtension(AssetDatabase.GetAssetPath(this));
    }
}
