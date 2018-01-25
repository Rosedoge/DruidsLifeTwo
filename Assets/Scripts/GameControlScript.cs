using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour {

    int GameCount = 0;

    [SerializeField]
    GameObject finalDoor;
    // Use this for initialization
    void Start()
    {
        if(GameCount == 0)
        {
            finalDoor.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] games = GameObject.FindGameObjectsWithTag("SubGame");
        foreach(GameObject game in games)
        {
            Debug.Log("Found a game completion");
            GameCount += 1;
            Destroy(game);
        }
    }
}
