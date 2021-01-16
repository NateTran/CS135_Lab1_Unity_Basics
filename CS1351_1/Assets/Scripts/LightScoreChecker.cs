using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScoreChecker : MonoBehaviour
{
    public MiniGame game = null;

    private void Start()
    {
        game = FindObjectOfType<MiniGame>();
    }

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            game.AddScore();
            game.RandomizeLight();
        }
    }
}
