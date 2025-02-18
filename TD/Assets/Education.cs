using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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

    [SerializeField] private TextMeshProUGUI EducationT;
    private int i = 0;

    private void Start()
    {
        NextDialog();
    }

    public void NextDialog()
    {
        if (i < textEducation.Length)
        {
            EducationT.text = textEducation[i];
            i++;
        }
    }

}
