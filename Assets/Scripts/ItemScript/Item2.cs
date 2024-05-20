using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Item2 : MonoBehaviour
{
    public GameObject[] cars;


    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isItem2Active)
        {

            DestroyAllCars();
            GameManager.Instance.isItem2Active = false;
        }
    }

    public void ITem2Activate()
    {
        if (GameManager.Instance.item2Hav >= 1 && !GameManager.Instance.isItem2Active)
        {
            GameManager.Instance.item2Hav -= 1;
            GameManager.Instance.isItem2Active = true;
        }
    }

    void DestroyAllCars()
    {
        Invoke("InvokeDestroyAllCars", 1.0f);
    }

    void InvokeDestroyAllCars()
    {
        foreach (GameObject car in cars)
        {
            Destroy(car);
        }
    }
}
