using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    // Start is called before the first frame update
    int currentScore = 0;
    public TextMeshProUGUI scoreText = null;
    public List<LightScoreChecker> lightList = new List<LightScoreChecker>();
    public int currentCount = 0;
    public float tempTimeLightOn = 3;

    void Start()
    {
        foreach(var light in lightList)
        {
            light.gameObject.SetActive(false);
        }
        lightList[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (tempTimeLightOn <= 0)
        {
            lightList[currentCount].gameObject.SetActive(false);
            RandomizeLight();
            lightList[currentCount].gameObject.SetActive(true);
            tempTimeLightOn = 3;
        }
        else
        {
            tempTimeLightOn -= Time.deltaTime;
        }
    }

    public void AddScore()
    {
        currentScore++;
        scoreText.text = "Score : " + currentScore;
    }

    public void RandomizeLight()
    {
        int tempCount = currentCount;
        do
        {
            currentCount = Random.Range(0, 4);
        }
        while (currentCount == tempCount);
        lightList[tempCount].gameObject.SetActive(false);
        lightList[currentCount].gameObject.SetActive(true);
        tempTimeLightOn = 3;
    }

}
