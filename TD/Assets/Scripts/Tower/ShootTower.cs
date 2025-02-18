using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class ShootTower : MonoBehaviour
{
    [SerializeField] private GameObject prefabBullet;
    private Tower tower = new Tower();
    private bool isTouchEnemy = false;

    private void Start()
    {
        tower = GetComponent<TowerManager>().GetTower();
        Debug.Log(tower.CountShoot);
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        for (; ; )
        {
            if (isTouchEnemy)
            {
                for (int i = 0; i < tower.CountShoot; i++)
                {
                    Shooting();
                    yield return new WaitForSeconds(tower.SpeedShoot);
                }
            }
            yield return new WaitForSeconds(tower.TimeRecharge);
        }
    }

    private void Shooting()
    {
        GameObject bull = Instantiate(prefabBullet, transform.position,Quaternion.identity);
        bull.GetComponent<BulletFly>().FillInfo(tower.Atack);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyManager>() != null)
        {
            isTouchEnemy = true;
        }
        else isTouchEnemy = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyManager>() != null)
        {
            isTouchEnemy = false;
        }
    }
}
