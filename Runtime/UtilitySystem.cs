using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitySystem : MonoBehaviour
{
    private List<NeedData> needDatas = new List<NeedData>();

    public void AddNeed(NeedData newNeedData)
    {
        if (newNeedData != null && !needDatas.Contains(newNeedData))
            needDatas.Add(newNeedData);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NeedData priorityNeed = null;
        float priorityImportance = 0.0f;
        foreach (NeedData needData in needDatas)
        {
            if (needData.range.Value < needData.floor)
            {
                float newImportance = needData.unitCurve.Evaluate(needData.range.Ratio());

                if (priorityNeed == null || newImportance > priorityImportance || (newImportance == priorityImportance && needData.priority > priorityNeed.priority))
                {
                    priorityNeed = needData;
                    priorityImportance = newImportance;
                }
            }
        }

        if (priorityNeed != null)
        {
            priorityNeed.action();
        }
    }
}