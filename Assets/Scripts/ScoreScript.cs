using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public float PlayerHealth = 5;
    public float PlayerScore = 0;
    private GUIStyle guiStyle = new GUIStyle();

    // Update is called once per frame
    void Update () {
        PlayerHealth -= Time.deltaTime;
        PlayerScore += Time.deltaTime;
    }

    public void IncreaseHealth(int amount)
    {
        PlayerHealth += amount;
    }

    void OnGUI()
    {
        guiStyle.fontSize = 30;
        GUI.Label(new Rect(10, 10, 200, 100), "Health: " + (int)(PlayerHealth * 100),guiStyle);
        GUI.Label(new Rect(300, 10, 200, 100), "Score: " + (int)(PlayerScore * 100), guiStyle);
    }

}
