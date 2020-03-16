using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class UserClick : CommandManager
{ 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Cube"))
                {
                    ICommand click = new ClickCmd(hitInfo.collider.gameObject, 
                        new Color(Random.value, Random.value, Random.value));
                    click.Execute();
                    CommandManager.Instance.AddCommandToBuffer(click);
                }
            }
        }    
    }
}
