using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Dictionary<PlayerValue, Player> basicPlayerInputList = new Dictionary<PlayerValue, Player>();

    public enum PlayerValue {NONE, SOUTH, EAST, NORTH, WEST };
    public PlayerValue playerValue;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void Vote(Player player, PlayerValue playerValue)
    {
        DialogueSystem.Instance.Vote(playerValue);
    }

    public PlayerValue IndexToButton(int playerIndex)
    {
        if(playerIndex == 0)
        {
            return PlayerValue.SOUTH;
        } else if(playerIndex == 1) {
            return PlayerValue.WEST;
        }
        else if (playerIndex == 2)
        {
            return PlayerValue.NORTH;
        }
        else if (playerIndex == 3)
        {
            return PlayerValue.EAST;
        }

        return PlayerValue.NONE;
    }

}
