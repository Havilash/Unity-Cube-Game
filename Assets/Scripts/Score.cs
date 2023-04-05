using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerTransform;
    public Text score;

    void Update()
    {
        score.text = playerTransform.position.z.ToString("0");
    }
}
