using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimSlerp : MonoBehaviour
{
    [SerializeField]
    private Transform _greenSphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToFace = _greenSphere.position - transform.position;
        UnityEngine.Debug.DrawRay(transform.position, directionToFace, Color.green);
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
    }
}
