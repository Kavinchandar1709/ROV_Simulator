using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Bowl1;
    public GameObject Bowl2;
    public GameObject Bowl3;
    public GameObject Bowl4;

    public int objecttogenerate;
    public int objquan;


    private void Start()
    {
        StartCoroutine(GenerateObj());
    }

    IEnumerator GenerateObj()
    {
        while (objquan < 1)
        {
            objecttogenerate = UnityEngine.Random.Range(1, 4);

            if (objecttogenerate == 1)
            {
                Instantiate(Bowl1, new Vector3(-31f, -9.1f, 65.5f), Quaternion.identity);
            }
            if (objecttogenerate == 2)
            {
                Instantiate(Bowl2, new Vector3(-31f, -9.1f, 65.5f), Quaternion.identity);
            }
            if (objecttogenerate == 3)
            {
                Instantiate(Bowl3, new Vector3(-31f, -9.1f, 65.5f), Quaternion.identity);
            }
            if (objecttogenerate == 4)
            {
                Instantiate(Bowl4, new Vector3(-31f, -9.1f, 65.5f), Quaternion.identity);
            }

            yield return null;
            objquan++;
        }
    }
}
