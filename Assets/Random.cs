using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    public GameObject gate;
    public int xpos;
    public int objecttogenerate;
    public int objquan ;


    private void Start()
    {
        StartCoroutine(GenerateObj());
    }

    IEnumerator GenerateObj()
    {
        while(objquan < 1)
        {
            objecttogenerate = 1;
            xpos = UnityEngine.Random.Range(-27, 32);

            if(objecttogenerate == 1)
            {
                Instantiate(gate, new Vector3(xpos, 1, -25), Quaternion.identity);
            }
            
            yield return null;
            objquan++;
        }
    }
}
