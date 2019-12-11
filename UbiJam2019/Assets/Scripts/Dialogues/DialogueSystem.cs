using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using static GameManager;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem Instance;

    [Header("UI")]
    public TextMeshProUGUI currentTitle;
    public TextMeshProUGUI currentDialogue;

    public List<DialogueScriptableObject> dialogueScriptableObjectList = new List<DialogueScriptableObject>();

    public List<ContainerAnswer> containerAnswers = new List<ContainerAnswer>();
    private int indexDialogue;
    private DialogueScriptableObject dialogue;

    public bool nextQuestion = false;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        indexDialogue = 0;
        dialogue = dialogueScriptableObjectList[indexDialogue];
        PlayDialogue();
    }

    private void Update()
    {
        if (nextQuestion)
        {
            nextQuestion = false;
            PlayNextDialogue();
        }
    }

    public void PlayNextDialogue()
    {
        indexDialogue++;
        PlayDialogue();
    }

    public void PlayPreviousDialogue()
    {
        indexDialogue--;
        PlayDialogue();
    }

    public void PlayDialogue()
    {
        dialogue = dialogueScriptableObjectList[indexDialogue];
        currentTitle.text = dialogue.title;
        currentDialogue.text = dialogue.dialogue;

        for(int i = 0; i < containerAnswers.Count; i++)
        {
            containerAnswers[i].SetAnswer(dialogue.questionTypes[i]);
        }
    }

    public void Vote(PlayerValue playerValue)
    {
        for (int i = 0; i < containerAnswers.Count; i++)
        {
            var answer = containerAnswers[i];
            if (answer.answerKey == playerValue)
            {
                answer.ValidatedOn();
            }
        }
    }
}
