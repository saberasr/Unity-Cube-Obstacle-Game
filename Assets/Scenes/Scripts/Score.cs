using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoreText;


    // Update is called once per frame
    void Update()
    {
        float zPosition = playerTransform.position.z;
        string formattedScore = zPosition.ToString("F0");

        scoreText.text = "Score: " + formattedScore;
    }
}
