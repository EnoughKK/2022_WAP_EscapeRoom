using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMessage : MonoBehaviour
{
    public Text text;

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            text.text = "�ΰ����� �߰����� ������ ��� �Ͽ���. �� �̻� �� �Ӹ��� ���� �� ����. �⸻��� �������� ���ļ� �����̶� ��ȸ�� ����.";
            StartCoroutine("TextOut", 3.0f);
        }
    }
    IEnumerator TextOut()
    {
        yield return new WaitForSeconds(5.0f);
        text.GetComponent<Text>().text = "";
    }
}
