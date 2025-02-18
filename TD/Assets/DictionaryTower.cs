using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTower : MonoBehaviour
{
    public static Dictionary<string, Tower> TowerMap()
    {
        Dictionary<string, Tower> map = new Dictionary<string, Tower>();
        map.Add("Submachinegunner", new Tower { Atack = 1, CountShoot = 5, DistanceShoot = 3, Cost = 5, LineShoot = 1, Health = 3, KeyTower = "Submachinegunner", NameTower = "Автоматчик", SpeedShoot = 0.3f, TimeRecharge = 1f });
        map.Add("tower2", new Tower { Atack = 1, CountShoot =2, DistanceShoot = 3, Cost = 25, LineShoot = 1, Health = 3, KeyTower = "tower2", NameTower = "Башня2", SpeedShoot = 1f, TimeRecharge = 2f });
        map.Add("tower3", new Tower { Atack = 3, CountShoot = 1, DistanceShoot = 3, Cost = 55, LineShoot = 1, Health = 3, KeyTower = "tower3", NameTower = "Башня3", SpeedShoot = 0.5f, TimeRecharge = 3f });
        return map;
    }

    public Dictionary<string, Tower> dicTower = TowerMap();
}
