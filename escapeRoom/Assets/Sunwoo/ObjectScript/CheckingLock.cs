using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckingLock : MonoBehaviour
{
    public bool Doorlock = true;
    public GameObject Lockwindow;
    public InputField Door_InputField;

    public void CheckLock()
    {
        if (Doorlock)
        {
            Debug.Log("����");
            Lockwindow.SetActive(true);
        }
    }

    public void CheckButton()
    {
        if (Door_InputField.text == "1234" && Player.P_instance.lockname == "professor")
        {
            Debug.Log("������~");
            Door_InputField.text = "";
            Lockwindow.SetActive(false);
            Player.P_instance.currentSpot = "LabIn";
            SceneManager.LoadScene("2F_lab");
        }
        else
        {
            Debug.Log("��");
            Door_InputField.text = "";
            Lockwindow.SetActive(false);
        }
    }

}
