using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlRandom : MonoBehaviour
{
    public GameObject Red1;
    public GameObject Red2;
    public GameObject Red3;
    public GameObject Blue;

    public int xpos;
    public int zpos;
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
            objecttogenerate = UnityEngine.Random.Range(1,4); ;
            xpos = UnityEngine.Random.Range(-16, -8);
            zpos = UnityEngine.Random.Range(28, 30);

            if (objecttogenerate == 1)
            {
                Instantiate(Red1, new Vector3(xpos, 0.5f, zpos), Quaternion.identity);
            }
            if (objecttogenerate == 2)
            {
                Instantiate(Red2, new Vector3(xpos, 0.5f, zpos), Quaternion.identity);
            }
            if (objecttogenerate == 3)
            {
                Instantiate(Red3, new Vector3(xpos, 0.5f, zpos), Quaternion.identity);
            }
            if (objecttogenerate == 4)
            {
                Instantiate(Blue, new Vector3(xpos, 0.5f, zpos), Quaternion.identity);
            }

            yield return null;
            objquan++;
        }
    }

}
