using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
    static private GameController _instance;

    [SerializeField] private TextMeshProUGUI coinT;
    private int coin = 15;
    private Tower tower; //чтобы понимать что строим

    private void Start()
    {
        coinT.text = coin.ToString();
    }

    public bool IsBuy(int cost)
    {
        return coin >= cost;
    }

    public void Buy(int cost)
    {
        coin -= cost;
        coinT.text = coin.ToString();
    }
    public void GetCoin(int count)
    {
        coin += count;
        coinT.text = coin.ToString();
    }

    public void Build(Tower t)
    {
        tower = t;
    }

    public Tower GetTower()
    {
        return tower;
    }
    public void NullTower()
    {
        tower = null;
    }
}
