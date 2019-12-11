using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector]
    public int score = 0;

    public int currentPlayerIndex = 0;

    private UIInput uiInput;

    public GameManager.PlayerValue playerValue;
    public void Awake()
    {
        playerValue = GameManager.Instance.IndexToButton(currentPlayerIndex);
        GameManager.Instance.basicPlayerInputList.Add(playerValue, this);
    }
    
}
