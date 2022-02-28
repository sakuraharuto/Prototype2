using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem Victory;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(PlayerController.WholeScore == 5)
        {
            Victory.Play();
            //Destroy(gameObject);
        }
    }
}
