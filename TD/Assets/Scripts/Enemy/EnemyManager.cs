using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private Enemy m_Enemy = new Enemy { };
    private float speed = 2.6f;
    private SpriteRenderer objectRenderer;

    void Update()
    {
        transform.Translate(speed * m_Enemy.Speed * Time.deltaTime * Vector3.up);
    }

    public void FillInfo(Enemy e, Sprite img)
    {
        objectRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
        m_Enemy = e;
        Debug.Log(img.name);
        objectRenderer.sprite = img;
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
