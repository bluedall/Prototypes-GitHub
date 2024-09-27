using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class is responsible for activating a target among other targets
/// </summary>
public class TargetManager : MonoBehaviour
{
    [SerializeField] GameObject[] targets;
  
    void Update()
    {
        IsolatingTarget();
    }

    int R;
    int i;
    void IsolatingTarget()
    {
        for (i = 0; i < targets.Length; i++)
        {
           
            if (targets[i].activeSelf == true)
            {
                return;
            }
        }
        if (i >= targets.Length )
        {
            R = Random.Range(0, targets.Length);
            targets[R].SetActive(true);
        }
    }
}
