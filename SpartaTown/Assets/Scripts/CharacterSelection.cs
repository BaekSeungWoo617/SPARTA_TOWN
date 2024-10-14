using UnityEngine;
using UnityEngine.UI; // UI 관련 네임스페이스 추가

public class CharacterSelection : MonoBehaviour
{
    public Button JoinPlayerButton;
    public GameObject JoinNameInput;
    public GameObject JoinSelectionInput;
    public Image JoinPlayerImage;
    public Image PlayerImage1;
    public Image PlayerImage2;
    public SpriteRenderer MainSprite;
    public void ClickJoinPlayerButton()
    {
        JoinNameInput.SetActive(false);
        JoinSelectionInput.SetActive(true);
    }
    public void ClickJoinPlayer1Button()
    {
        SetMainSpriteAnimator(false);
        JoinPlayerImage.sprite = PlayerImage1.sprite;
        MainSprite.sprite = JoinPlayerImage.sprite;
        JoinSelectionInput.SetActive(false);
        JoinNameInput.SetActive(true);
        SetMainSpriteAnimator(true);
    }
    public void ClickJoinPlayer2Button()
    {
        SetMainSpriteAnimator(false);
        JoinPlayerImage.sprite = PlayerImage2.sprite;
        MainSprite.sprite = JoinPlayerImage.sprite;
        JoinSelectionInput.SetActive(false);
        JoinNameInput.SetActive(true);
        //SetMainSpriteAnimator(true);

    }
    public void SetMainSpriteAnimator(bool temp)
    {
        Animator animator = MainSprite.GetComponent<Animator>();
        if (animator != null)
        {
            animator.enabled = temp;
        }
    }
}