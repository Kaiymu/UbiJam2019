using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CustomPlayerSpawn : MonoBehaviour
{
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        var player = PlayerInput.Instantiate(playerPrefab);
        player.defaultControlScheme = "GamePad";
        player.neverAutoSwitchControlSchemes = true;


    }
}
