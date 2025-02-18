using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyList : MonoBehaviour
{
    public List<Enemy> listEnemy = new List<Enemy>()
    {
        new Enemy() { Speed = 1f, Hp = 3, RewardCoin = 5 },
        new Enemy() { Speed = 1.5f, Hp = 7, RewardCoin = 15 },
        new Enemy() { Speed = 0.8f, Hp = 15, RewardCoin = 25 },
    };

    public Sprite[] spritesImg;
}
