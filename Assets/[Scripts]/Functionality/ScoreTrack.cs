using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ScoreTrack : MonoBehaviour
{
    private Text score_Text;
    private int scoreCount;

    public static ScoreTrack instance;

    public GameObject bomb_PickUp;

    private float min_X = 4.25f, max_X = 4.25f, min_Y = -2.26f, max_Y = 2.26f;
    private float z_Pos = 5.8f;

    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void start()
    {
        score_Text = GameObject.Find("Score").GetComponent<Text>();
        Invoke("StartSpawning", 0.1f);
    }

    void StartSpawning()
    {
        StartCoroutine(SpawnPickUps());
    }

    public void CancelSpawning()
    {
        CancelInvoke("StartSpawning");
    }

    IEnumerator SpawnPickUps()
    {
        yield return new WaitForSeconds(Random.Range(0.1f, 0.6f));

        if(Random.Range(0, 10) >= 2)
        {
            Instantiate(bomb_PickUp, new Vector3(Random.Range(min_X, max_X), Random.Range(min_Y, max_Y), z_Pos), Quaternion.identity);
        }

        Invoke("StartSpawning", 0f);
    }

    public void IncreaseScore()
    {
        scoreCount++;
        score_Text.text = "Score: " + scoreCount;
    }
}
