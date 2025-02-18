using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChoiceDay : MonoBehaviour
{
    private int number;
    [SerializeField] private TextMeshProUGUI numberT;

    public void FillInfo(int i)
    {
        number = i;
        numberT.text = number.ToString();
    }

    public void ChoiceDay()
    {
        PlayerPrefs.SetInt("day", number);
        SceneManager.LoadScene(2);
    }
}
