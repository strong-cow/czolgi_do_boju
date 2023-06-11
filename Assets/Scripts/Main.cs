using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Main : MonoBehaviour
{
    public GameObject tankPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tankPlayer1 = Instantiate(tankPrefab, Vector3.zero, Quaternion.identity);
        tankPlayer1.tag = "Player1";
        tankPlayer1.SendMessage("SetColor", "Blue");
        GameObject tankPlayer2 = Instantiate(tankPrefab, Vector3.zero, Quaternion.identity);
        tankPlayer2.tag = "Player2";
        tankPlayer2.SendMessage("SetColor", "Red");
    }
}
