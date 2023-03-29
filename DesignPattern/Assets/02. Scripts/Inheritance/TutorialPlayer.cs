using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPlayer : PlayerBase
{
    public override void Start()
    {
        
        base.Start();
        //Speak3();
    }

    void Speak3()
    {
        Debug.Log("Tutorial_Speak3");
    }

    public override void Speak()
    {
        //base.Speak();
        Debug.Log("Tutorial_Speak");
    }

    
}
