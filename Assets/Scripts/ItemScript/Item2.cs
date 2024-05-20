using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Item2 : MonoBehaviour
{
    //아이템 지속시간
    private float item2Duration = 5.0f;
    private float timer2 = 0f;

    public TextMeshProUGUI textMesh;

    void Awake()
    {
        if (textMesh == null)
        {
            textMesh = GetComponentInChildren<TextMeshProUGUI>();
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isItem2Active)
        {
            timer2 += Time.deltaTime;
            if (timer2 >= item2Duration)
            {
                GameManager.Instance.isItem2Active = false;
                timer2 -= Time.deltaTime;
                timer2 = 0f;
            }
        }
        textMesh.text = $"x{GameManager.Instance.item2Hav}";
    }

    public void ITem2Activate()
    {
        if (GameManager.Instance.item2Hav >= 1 && !GameManager.Instance.isItem2Active)
        {
            GameManager.Instance.item2Hav -= 1;
            GameManager.Instance.isItem2Active = true;
        }
    }
}
