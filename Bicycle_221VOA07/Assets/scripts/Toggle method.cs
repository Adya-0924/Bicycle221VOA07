using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Togglemethod : MonoBehaviour
{
    public GameObject bicycleComponent;
    private bool isVisible = true;

    public void Toggle()
    {
        if(isVisible)
        {
            bicycleComponent.SetActive(false);
            isVisible = false;
        }
        else
        {
            bicycleComponent.SetActive(true);
            isVisible = true;
        }
    }
}
