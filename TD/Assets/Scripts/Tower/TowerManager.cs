using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    private Tower tower = new Tower();

    public Tower GetTower()
    {
        return tower;
    }

    public void FillInfo(Tower t)
    {
        tower = t;
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(tower.KeyTower);
    }
}
