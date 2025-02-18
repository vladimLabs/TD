using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTower : DictionaryTower
{
    [SerializeField] private GameObject prefabSlotShop;
    [SerializeField] private Transform content;
    void Start()
    {
        foreach (var slot in dicTower.Values)
        {
            GameObject slotShop = Instantiate(prefabSlotShop,content);
            slotShop.GetComponent<SlotTowerShop>().FillInfo(slot);
        }
    }

    
}
