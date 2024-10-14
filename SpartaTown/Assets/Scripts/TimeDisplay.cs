using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshPro ���ӽ����̽� �߰�

public class TimeDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText; // UI �ؽ�Ʈ ����

    private void Update()
    {
        // ���� �ð� ��������
        string currentTime = System.DateTime.Now.ToString("HH:mm:ss");

        // UI �ؽ�Ʈ ������Ʈ
        timeText.text = currentTime;
    }
}