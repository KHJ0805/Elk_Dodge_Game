using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float forceGravity = 3.0f;
    public bool isItem1Active;
    Rigidbody2D rb;

    // �ڵ����� ������ ��ġ
    void Start()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float y = 5.5f;
        rb = GetComponent<Rigidbody2D>();

        if ( x < 0.0f && x >= -2.0f)
        {
            transform.position = new Vector2(x, y);
        }
        else if( x>=0.0f && x <= 2.0f)
        {
            transform.position = new Vector2(x, -y);
        }
    }

    // ���� ����� ������ ���� ��
    void Update()
    {
        isItem1Active = GameManager.Instance.isItem1Active;
        //���� ȭ�� ������ ������ ����
        if (transform.position.y < -5.6f)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y > 5.6f)
        {
            Destroy(gameObject);
        }
    }


    private void FixedUpdate()
    {
        if (transform.position.x < 0.0f && transform.position.x >= -2.0f)
        {
            rb.AddForce(Vector3.down * forceGravity);

        }
        else if (transform.position.x >= 0.0f && transform.position.x <= 2.0f)
        {
            rb.AddForce(Vector3.up * forceGravity);
        }
    }


    //���� �����(�÷��̾�)�� ���� ���
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isItem1Active)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                if (GameManager.Instance.item3Hav >= 1)
                {
                    GameManager.Instance.item3Hav -= 1;
                }

                else
                {
                    GameManager.Instance.GameOver();
                }
            }
        }

        else
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(this.gameObject);
            }
        }
    }
}
