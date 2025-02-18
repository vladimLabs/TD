using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGameTower : MonoBehaviour
{
    [SerializeField] private GameObject panelLose;
    [SerializeField] private GameObject[] iconHearts;
    private int hp = 3;

    private void Start()
    {
        for (int i = 0; i < iconHearts.Length; i++)
        {
            iconHearts[i].SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyManager>() != null)
        {
            hp--;
            iconHearts[hp].SetActive(false);
            if (hp <= 0)
            {
                panelLose.SetActive(true);
                hp = 3;
            }
        }
    }
}
