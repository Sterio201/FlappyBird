using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBG : MonoBehaviour
{
    [SerializeField] List<GameObject> layers;
    
    bool startParalax = false;

    public void StartParalax()
    {
        startParalax = true;
    }

    private void Update()
    {
        if (startParalax)
        {
            if (layers[0].transform.position.x <= -28.96)
            {
                GameObject temp = layers[0];

                layers[0].transform.position = new Vector3(28.96f, 0, 20);
                layers[0] = layers[1];
                layers[1] = temp;
            }

            for (int i = 0; i < layers.Count; i++)
            {
                layers[i].transform.Translate(-0.5f * Time.deltaTime, 0, 0);
            }
        }
    }
}