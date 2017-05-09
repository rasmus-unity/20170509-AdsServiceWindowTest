using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ads : MonoBehaviour
{
    void Start () 
    {
        #if UNITY_ADS
        StartCoroutine (ShowAdWhenReady());
        #endif
    }

    #if UNITY_ADS
    IEnumerator ShowAdWhenReady()
    {
        while (!UnityEngine.Advertisements.Advertisement.IsReady())
            yield return null;

        UnityEngine.Advertisements.Advertisement.Show ();
    }
    #endif
}
