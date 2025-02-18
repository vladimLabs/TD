using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Education : MonoBehaviour
{
    private string[] textEducation = new string[] {
        "Добро пожаловать в игру!",
        "1. В вашем распоряжении башни, которые можно ставить на поле (чем больше стоимость, тем больше урон)",
        "2. Не дай врагам дойти до верха",
        "3. У тебя 3 жизни",
        "4. Продержись как можно больше дней",
        "На этом всё. Удачи!"
    };
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private Image img;
    [SerializeField] private TextMeshProUGUI EducationT;
    [SerializeField] private SpawnController spawnController;
    private int i = 0;

    private void Start()
    {
        if (PlayerPrefs.GetInt("startGame") == 0)
        {
            NextDialog();
            PlayerPrefs.SetInt("startGame", 1);
        }
        else
        {
            gameObject.SetActive(false);
            spawnController.StartGame();
        }
    }

    public void NextDialog()
    {
        if (i < textEducation.Length)
        {
            img.sprite = sprites[i];
            EducationT.text = textEducation[i];
            i++;
        }
    }

}
