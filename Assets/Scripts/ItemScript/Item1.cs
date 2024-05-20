using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item1 : MonoBehaviour
{
    //아이템 지속시간
    private float item1Duration = 10.0f;
    private float timer1 = 0f;

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
        if (GameManager.Instance.isItem1Active)
        {
            timer1 += Time.deltaTime;
            if (timer1 >= item1Duration)
            {
                GameManager.Instance.isItem1Active = false;
                timer1 -= Time.deltaTime;
                timer1 = 0f;
            }
        }

        textMesh.text = $"x{GameManager.Instance.item1Hav}";
    }

    public void ITem1Activate()
    {
        if (GameManager.Instance.item1Hav >= 1 && !GameManager.Instance.isItem1Active)
        {
            GameManager.Instance.item1Hav -= 1;
            GameManager.Instance.isItem1Active = true;
        }
    }
}
