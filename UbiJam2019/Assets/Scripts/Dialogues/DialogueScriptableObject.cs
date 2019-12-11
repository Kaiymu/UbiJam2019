using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Dialogue")]
public class DialogueScriptableObject : ScriptableObject
{
    public string title;

    [TextArea]
    public string dialogue;

    [Header("Validation")]
    public bool validate = false;

    [Header("Sounds")]
    public AudioSource soundToPlay;
    public float delaySound = 0f;

    public List<AnswerTypes> questionTypes = new List<AnswerTypes>(4);
}

[Serializable]
public class AnswerTypes
{
    public string answer;
    public GameManager.PlayerValue playerValue;
}
