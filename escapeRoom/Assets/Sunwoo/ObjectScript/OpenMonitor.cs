using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMonitor : MonoBehaviour
{
    public GameObject windowPassword;
    public InputField monitor_Input;
    public GameObject nextHint;

    public void CheckLock()
    {
        Player.P_instance.moveMouse = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("����");
        windowPassword.SetActive(true);
    }

    public void CheckButton()
    {
        if (monitor_Input.text == "1955" && Player.P_instance.lockname == "Monitor")
        {
            Debug.Log("������~");
            monitor_Input.text = "";
            windowPassword.SetActive(false);
            nextHint.SetActive(true);
        }
        else
        {
            Player.P_instance.moveMouse = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("��");
            monitor_Input.text = "";
            windowPassword.SetActive(false);
        }
    }

    public void CheckHintButton()
    {
        nextHint.SetActive(false);
        Player.P_instance.moveMouse = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
