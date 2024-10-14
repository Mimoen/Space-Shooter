using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public int score = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        text.text = $"{score}";
    }
}
