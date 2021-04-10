using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static int Pisteita;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Pisteita = 0;
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        scoreText.text = Pisteita.ToString();
    }
}
