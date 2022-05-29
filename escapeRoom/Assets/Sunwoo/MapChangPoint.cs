using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChangPoint : MonoBehaviour
{
    public string transferMapName; //�̵��� ���̸�       
    public Transform target; // �̵��� Ÿ�� ����

    private Player thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<Player>();
    }

    // �ڽ� �ݶ��̴��� ��� ���� �̺�Ʈ �߻�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            thePlayer.currentSpot = transferMapName;
            //SceneManager.LoadScene(transferMapName);
            thePlayer.transform.position = target.transform.position;

        }
    }
}
