using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour
{
   public MyController myController;
    private Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.insideUnitCircle;
        myController = MyController.Instance();
        myController.FoundMe();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
