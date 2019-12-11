using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContainerAnswer : MonoBehaviour
{
    public TextMeshProUGUI answer;
    private RawImage _rawImage;

    public GameManager.PlayerValue answerKey;
    private void Awake()
    {
        _rawImage = GetComponent<RawImage>();
    }

    public void SetAnswer(AnswerTypes answerTxt)
    {
        answer.text = answerTxt.answer;
        answerKey = answerTxt.playerValue;
        _rawImage.color = Color.green;
    }

    public void ValidatedOn()
    {
        _rawImage.color = Color.red;
    }
}
