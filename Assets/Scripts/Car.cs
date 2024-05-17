using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float speed = 0.01f;

    // �ڵ����� ������ ��ġ
    void Start()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float y = 5.5f;
        transform.position = new Vector2(x, y);
    }

    // ���� ���� ������ ���� ��
    void Update()
    {
        //���� ȭ�� ������ ������ ����
        if(transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
    //���� ����(�÷��̾�)�� ���� ���
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            //���� ���� �޼��� ����
            GameManager.Instance.GameOver();
        }
    }
}
