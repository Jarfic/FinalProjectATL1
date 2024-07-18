using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject start1;
    public GameObject start2;
    public GameObject start3;

    public void HandleInputData(int num)
    {
        if (num == 0)
        {
            start1.SetActive(true);
            start2.SetActive(false);
            start2.SetActive(false);
        }
        else if (num == 1)
        {
            start1.SetActive(false);
            start2.SetActive(true);
            start3.SetActive(false);
        }
        else
        {
            start1.SetActive(false);
            start2.SetActive(false);
            start3.SetActive(true);
        }
    }  
}