using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NameInput : MonoBehaviour
{
    public TMP_InputField inputField;      // 씬에서 InputField 오브젝트를 드래그하여 연결
    public Button joinButton;          // 씬에서 Button 오브젝트를 드래그하여 연결
    public GameObject character;       // 캐릭터 오브젝트
    public TextMeshProUGUI nameTag;                 // 이름표 UI 오브젝트

    void Start()
    {
        // Join 버튼 클릭 시 OnJoinClicked 함수 호출
        joinButton.onClick.AddListener(OnJoinClicked);
        joinButton.interactable = false; // 버튼 비활성화

        // InputField의 내용이 변경될 때마다 OnInputChanged 함수 호출
        inputField.onValueChanged.AddListener(OnInputChanged);

        // 이름표 비활성화
        nameTag.gameObject.SetActive(false);
    }

    void OnInputChanged(string input)
    {
        // 2~10 글자 사이인지 검증
        joinButton.interactable = input.Length >= 2 && input.Length <= 10;
    }

    void OnJoinClicked()
    {
        // 입력된 텍스트 가져오기
        string enteredText = inputField.text;
        Debug.Log("사용자가 입력한 텍스트: " + enteredText);

        // 이름표 설정
        nameTag.text = enteredText;
        nameTag.gameObject.SetActive(true); // 이름표 활성화
        this.gameObject.SetActive(false);// UI비활성화
    }

    void Update()
    {
        if (nameTag.gameObject.activeSelf)
        {
            // 캐릭터 위에 이름표 위치 설정
            Vector3 nameTagPosition = Camera.main.WorldToScreenPoint(character.transform.position + new Vector3(0, 1.5f, 0));
            nameTag.transform.position = nameTagPosition;
        }
    }
}