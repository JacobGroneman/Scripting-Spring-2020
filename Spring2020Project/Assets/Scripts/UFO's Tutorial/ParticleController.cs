using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem[] sparks;
    
    // Start is called before the first frame update
    void Start()
    {
        sparks = GetComponentsInChildren<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 100 * Time.deltaTime);
            if(Input.GetKeyDown(KeyCode.E));
            {
                foreach (ParticleSystem spark in sparks)
                {
                    spark.Pause();
                    spark.Emit(100);
                }
            }
    }
}
