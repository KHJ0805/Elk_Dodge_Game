using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elk : MonoBehaviour
{
    float direction = 0.05f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() //���� ��Ʈ�ѷ�
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float x = mousePos.x;

        if (x > 2.0f)  //���ϰ� ���� �ȿ����� ������ �� �ִ�
        {
            x = 2.0f;
        }
        else if (x < -2.0f)
        {
            x = -2.0f;
        }
        transform.position = new Vector2(x, transform.position.y);
    }


}
