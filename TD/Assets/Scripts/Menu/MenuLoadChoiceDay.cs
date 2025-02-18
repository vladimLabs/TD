using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLoadChoiceDay : MonoBehaviour
{
    [SerializeField] private GameObject prefabButton;
    [SerializeField] private GameObject Content;

    private int maxCountDay = 30;
    void Start()
    {
        for(int i = 1; i <= maxCountDay; i++)
        {
            GameObject button = Instantiate(prefabButton, Content.transform);
            button.GetComponent<ButtonChoiceDay>().FillInfo(i);
        }
    }
}
