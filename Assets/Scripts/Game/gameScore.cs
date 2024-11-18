using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"{Score}";
    }
}
