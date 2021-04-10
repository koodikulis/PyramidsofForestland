using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itgetsharder : MonoBehaviour
{
    public static int Ajastin;
    public int vaikeustaso1 = 10;
    public int vaikeustaso2 = 20;
    public int vaikeustaso3 = 30;
    public int vaikeustaso4 = 40;
    public int vaikeustaso5 = 50;
    public int vaikeustaso6 = 60;
    // Start is called before the first frame update
    void Start()
    {
        Ajastin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Ajastin = Ajastin + 1;
        //Debug.Log(Ajastin);

        if (Points.Pisteita < vaikeustaso1)
        {
            Group.harder = 0.5f;
        }
        if (Points.Pisteita > vaikeustaso1 && Points.Pisteita < vaikeustaso2)
        {
            Group.harder = 0.4f;
        }
        if (Points.Pisteita > vaikeustaso2 && Points.Pisteita < vaikeustaso3)
        {
            Group.harder = 0.3f;
        }
        if (Points.Pisteita > vaikeustaso3 && Points.Pisteita < vaikeustaso4)
        {
            Group.harder = 0.2f;
        }
        if (Points.Pisteita > vaikeustaso4)
        {
            Group.harder = 0.15f;
        }
        Debug.Log(Group.harder);
    }
}

