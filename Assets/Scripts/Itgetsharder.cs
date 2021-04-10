using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itgetsharder : MonoBehaviour
{
    public static int Ajastin;
    // Start is called before the first frame update
    void Start()
    {
        Ajastin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Ajastin = Ajastin + 1;
        Debug.Log(Ajastin);
    }
}
