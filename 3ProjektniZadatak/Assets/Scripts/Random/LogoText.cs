using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoText : MonoBehaviour
{
    public GameObject logotext;

    public void Start()
    {
        logotext.SetActive(false);
    }

    // Update is called once per frame

    public void OnMouseOver()
    {
        logotext.SetActive(true);
    }
    public void OnMouseExit()
    {
        logotext.SetActive(false);

    }
    void Update()
    {

    }
}
