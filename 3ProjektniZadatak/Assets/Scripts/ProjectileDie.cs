using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDie : MonoBehaviour
{
    public float dieTime;

    void Start()
    {
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(dieTime);
        Destroy(gameObject);
    }
}
