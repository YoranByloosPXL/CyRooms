using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupController : MonoBehaviour
{
    public GameObject panel;
    public Button[] buttons;
    public Text questionText;

    public void ShowPopup(string question, string[] answers)
    {
        questionText.text = question;
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponentInChildren<Text>().text = answers[i];
            buttons[i].onClick.AddListener(() => CheckAnswer(answers[i]));
        }
        panel.SetActive(true);
    }

    void CheckAnswer(string answer)
    {
        Debug.Log(answer);
    }

    public void HidePopup()
    {
        panel.SetActive(false);
    }
}