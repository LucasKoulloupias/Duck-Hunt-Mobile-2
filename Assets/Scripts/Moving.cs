using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{
    public float speed;
    public int Score;
    public Text ScoreBorad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);
    }

    public void AddSpeed()
    {
        speed = speed + 0.01f;

        Score = Score + 10;

        ScoreBorad.text = Score.ToString();
    }
}
