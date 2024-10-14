using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NameInput : MonoBehaviour
{
    public TMP_InputField inputField;      // ������ InputField ������Ʈ�� �巡���Ͽ� ����
    public Button joinButton;          // ������ Button ������Ʈ�� �巡���Ͽ� ����
    public GameObject character;       // ĳ���� ������Ʈ
    public TextMeshProUGUI nameTag;                 // �̸�ǥ UI ������Ʈ

    void Start()
    {
        // Join ��ư Ŭ�� �� OnJoinClicked �Լ� ȣ��
        joinButton.onClick.AddListener(OnJoinClicked);
        joinButton.interactable = false; // ��ư ��Ȱ��ȭ

        // InputField�� ������ ����� ������ OnInputChanged �Լ� ȣ��
        inputField.onValueChanged.AddListener(OnInputChanged);

        // �̸�ǥ ��Ȱ��ȭ
        nameTag.gameObject.SetActive(false);
    }

    void OnInputChanged(string input)
    {
        // 2~10 ���� �������� ����
        joinButton.interactable = input.Length >= 2 && input.Length <= 10;
    }

    void OnJoinClicked()
    {
        // �Էµ� �ؽ�Ʈ ��������
        string enteredText = inputField.text;
        Debug.Log("����ڰ� �Է��� �ؽ�Ʈ: " + enteredText);

        // �̸�ǥ ����
        nameTag.text = enteredText;
        nameTag.gameObject.SetActive(true); // �̸�ǥ Ȱ��ȭ
        this.gameObject.SetActive(false);// UI��Ȱ��ȭ
    }

    void Update()
    {
        if (nameTag.gameObject.activeSelf)
        {
            // ĳ���� ���� �̸�ǥ ��ġ ����
            Vector3 nameTagPosition = Camera.main.WorldToScreenPoint(character.transform.position + new Vector3(0, 1.5f, 0));
            nameTag.transform.position = nameTagPosition;
        }
    }
}