using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour {

    int GameCount = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] games = GameObject.FindGameObjectsWithTag("SubGame");
        foreach(GameObject game in games)
        {
            GameCount += 1;
            Destroy(game);
        }
    }
}
