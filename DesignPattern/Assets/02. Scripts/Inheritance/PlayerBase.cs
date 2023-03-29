using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public virtual void Start()
    {
        //Speak();
        //Speak2();
    }

    public virtual void Speak()
    {
        Debug.Log("Base_Speak");
    }

    public virtual void Speak2()
    {
        Debug.Log("Base_Speak2");
    }

}
