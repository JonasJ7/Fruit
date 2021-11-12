using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    bool isCutting = false;

    public void Move()
    {
        Debug.Log("Move");
    }

    public void Click()
    {
        StartCutting();
    }

    public void Throw()
    {
        Debug.Log("Throw");
    }

    void StartCutting()
    {
        isCutting = true;
    }

    void StopCutting()
    {
        isCutting = false;
    }
}
