using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
