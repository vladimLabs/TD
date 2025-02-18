using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{
    private float speed = 4;
    private int atack;

    private void Start()
    {
        Destroy(gameObject, 15);
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.down);
    }

    public void FillInfo(int at)
    {
        atack = at;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<EnemyManager>() != null)
        {
            collision.gameObject.GetComponent<EnemyManager>().GetDamage(atack);
            Destroy(gameObject);
        }
    }
}
