using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnGenerate : MonoBehaviour
{
    [SerializeField] GameObject columpGroupPrefab;
    [SerializeField] ColumnAddPool columnAdd;

    public void StartGenerate()
    {
        StartCoroutine(Generate());
    }

    IEnumerator Generate()
    {
        while (true)
        {
            float randY = Random.Range(-3, 3);
            GameObject newColumnGroup;

            if (columnAdd.poolColumns.Count == 0)
            {
                newColumnGroup = Instantiate(columpGroupPrefab);
            }
            else
            {
                newColumnGroup = columnAdd.poolColumns.Pop();
            }

            columnAdd.allCurrentColumns.Add(newColumnGroup);
            Transform pos = newColumnGroup.GetComponent<Transform>();
            pos.position = new Vector3(12, randY, 90);

            yield return new WaitForSeconds(2f);
        }
    }
}