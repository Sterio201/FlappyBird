using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnAddPool : MonoBehaviour
{
    [HideInInspector]
    public List<GameObject> allCurrentColumns;
    [HideInInspector]
    public Stack<GameObject> poolColumns;

    private void Start()
    {
        allCurrentColumns = new List<GameObject>();
        poolColumns = new Stack<GameObject>();
    }

    private void Update()
    {
        for(int i = 0; i<allCurrentColumns.Count; i++)
        {
            if(allCurrentColumns[i].transform.position.x <= -12)
            {
                poolColumns.Push(allCurrentColumns[i]);
                allCurrentColumns.RemoveAt(i);
            }
        }
    }
}