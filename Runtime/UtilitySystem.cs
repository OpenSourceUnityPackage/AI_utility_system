using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitySystem : MonoBehaviour
{
    public List<NeedData> needDatas;

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
            if (needData.range.Value > needData.floor)
            {
                float newImportance = priorityNeed.unitCurve.Evaluate(needData.range.Ratio());

                if (newImportance > priorityImportance)
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