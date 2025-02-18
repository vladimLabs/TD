using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotTowerShop : MonoBehaviour
{
    private Tower tower;
    [SerializeField] private TextMeshProUGUI cost;
    [SerializeField] private Image img;
    public void FillInfo(Tower t)
    {
        tower = t;
        cost.text = tower.Cost.ToString();
        img.sprite = Resources.Load<Sprite>(tower.KeyTower);
    }

    public void BuyTower()
    {
        if (GameController.Instance.IsBuy(tower.Cost))
        {
            GameController.Instance.Build(tower);
            GameController.Instance.Buy(tower.Cost);
        }
    }
}
