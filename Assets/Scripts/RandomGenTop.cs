using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenTop : MonoBehaviour
{
    public GameObject bullet;
    public float xPos;
    public float yPos;
    public int objectToGenerate;
    public int objectQuantity;
    void Start()
    {
        StartCoroutine(GenerateObjects());
    }

    IEnumerator GenerateObjects()
    {
        while(objectQuantity < 50)
        {
            objectToGenerate = Random.Range(1,2);
            xPos = Random.Range(-3.8f, 3.8f);
            yPos = Random.Range(1f, 4.8f);
            if (objectToGenerate == 1)
            {
                Instantiate(bullet, new Vector3(xPos,yPos,0),Quaternion.identity);
            }
            yield return new WaitForSeconds(4.5f);
            objectQuantity += 1;
        }
    }


}
