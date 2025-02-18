using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Education : MonoBehaviour
{
    private string[] textEducation = new string[] {
        "����� ���������� � ����!",
        "1. � ����� ������������ �����, ������� ����� ������� �� ���� (��� ������ ���������, ��� ������ ����)",
        "2. �� ��� ������ ����� �� �����",
        "3. � ���� 3 �����",
        "4. ���������� ��� ����� ������ ����",
        "�� ���� ��. �����!"
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
