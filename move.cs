using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    public int playerX, playerZ;
    public GameObject textobject;

    // Use this for initialization
    void Start()
    {
        playerX = -2;
        playerZ = -5;
        //Debug.Log (transform.position);
        transform.position = new Vector3(playerX, 0, playerZ);

        textobject.GetComponent<TextMesh>().text = "test";
    }

    // Update is called once per frame
    void Update()
    {
        playerZ = (int)transform.position.z;
        playerX = (int)transform.position.x;
        textobject.GetComponent<TextMesh>().text = ("reach the end of the hallway to win ");

        if (playerX == 2 && playerZ == 2)
        { //player is in bad position}
            Debug.Log("reset the player's position");

        }
        if (playerX == -2 && playerZ == 3)
            textobject.GetComponent<TextMesh>().text = ("you win.goodbye");

        if (Input.GetKeyDown("up"))
        {
            transform.position += new Vector3(0, 0, 1);
        }


        }        } 