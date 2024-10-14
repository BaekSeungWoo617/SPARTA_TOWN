using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshPro 네임스페이스 추가

public class TimeDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText; // UI 텍스트 변수

    private void Update()
    {
        // 현재 시간 가져오기
        string currentTime = System.DateTime.Now.ToString("HH:mm:ss");

        // UI 텍스트 업데이트
        timeText.text = currentTime;
    }
}