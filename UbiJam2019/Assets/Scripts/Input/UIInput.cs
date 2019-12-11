using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class UIInput : MonoBehaviour
{
    private float _southButton;
    private float _estButton;
    private float _northButton;
    private float _westButton;
    // Called when the device is disconnected
    public void DeviceLostEvent(PlayerInput test)
    {
        Destroy(gameObject);
    }

    public void OnSouthButton(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            _southButton = context.ReadValue<float>();
            GameManager.Instance.Vote(GetComponent<Player>(), GameManager.PlayerValue.SOUTH);
        }
    }

    public void OnEstButton(InputAction.CallbackContext context)
    {
        _estButton = context.ReadValue<float>();

        if (context.started)
        {
            _southButton = context.ReadValue<float>();
            GameManager.Instance.Vote(GetComponent<Player>(), GameManager.PlayerValue.EAST);
        }
    }

    public void OnNorthButton(InputAction.CallbackContext context)
    {
        _westButton = context.ReadValue<float>();

        if (context.started)
        {
            _southButton = context.ReadValue<float>();
            GameManager.Instance.Vote(GetComponent<Player>(), GameManager.PlayerValue.NORTH);
        }
    }

    public void OnWestButton(InputAction.CallbackContext context)
    {
        _northButton = context.ReadValue<float>();

        if (context.started)
        {
            _southButton = context.ReadValue<float>();
            GameManager.Instance.Vote(GetComponent<Player>(), GameManager.PlayerValue.WEST);
        }
    }
}
