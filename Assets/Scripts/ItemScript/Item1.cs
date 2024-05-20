using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item1 : MonoBehaviour
{
    //아이템 지속시간
    private float item1Duration = 2.0f;
    private float timer = 0f;

    private TextMeshPro item1HaveTextMesh;

    void Awake()
    {
        item1HaveTextMesh = GetComponentInChildren<TextMeshPro>();
    }


    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isItem1Active)
        {
            timer += Time.deltaTime;
            if (timer >= item1Duration)
            {
                GameManager.Instance.isItem1Active = false;
                timer -= Time.deltaTime;
                timer = 0f;
            }
        }

        //item1HaveTextMesh.text = GameManager.Instance.item1Hav.ToString();
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
