using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileOnMap : MonoBehaviour
{
    [SerializeField] private GameObject prefabTower;

    private void OnMouseDown()
    {
        Debug.Log("tap");
        if (GameController.Instance.GetTower() != null)
        {
            GameObject clone = Instantiate(prefabTower, gameObject.transform);
            clone.GetComponent<TowerManager>().FillInfo(GameController.Instance.GetTower());
            GameController.Instance.NullTower();
        }
    }
}
