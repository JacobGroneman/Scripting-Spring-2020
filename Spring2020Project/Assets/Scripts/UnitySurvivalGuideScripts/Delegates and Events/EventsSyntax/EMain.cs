using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMain : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;
    
    public void ButtonClick()
    {
        onClick?.Invoke();
    }
}
