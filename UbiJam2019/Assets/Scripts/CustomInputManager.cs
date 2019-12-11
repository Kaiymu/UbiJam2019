using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CustomInputManager : MonoBehaviour
{
    public Transform parent;
    public void PlayerJoined(PlayerInput uiJoined)
    {
        uiJoined.transform.SetParent(parent, false);
        uiJoined.GetComponent<Player>().currentPlayerIndex = uiJoined.playerIndex;
        uiJoined.gameObject.SetActive(true);
    }
}
