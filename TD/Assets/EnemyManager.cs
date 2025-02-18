using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private Enemy m_Enemy = new Enemy { Attack = 2, Hp = 3, RewardCoin = 15};
    private float speed = 2.6f;
    private SpriteRenderer objectRenderer;

    void Start()
    {
        objectRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.up);
    }

    public void FillInfo(Enemy e)
    {
        m_Enemy = e;
    }

    public void GetDamage(int hit)
    {
        StartCoroutine(FlashRed());
        m_Enemy.Hp -= hit;
        if(m_Enemy.Hp < 0)
        {
            Debug.Log("die");
            GameController.Instance.GetCoin(m_Enemy.RewardCoin);
            Destroy(gameObject);
        }
    }
    private IEnumerator FlashRed()
    {
        Color originalColor = objectRenderer.material.color;
        objectRenderer.material.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        objectRenderer.material.color = Color.white;
    }
}
