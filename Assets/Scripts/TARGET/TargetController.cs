using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour,ITargetInterface
{

    public void targetShot()
    {
        Destroy(gameObject);
    }
    public void playAnimation()
    {
        // to do
    }

    public void playAudio()
    {
        
    }

}
