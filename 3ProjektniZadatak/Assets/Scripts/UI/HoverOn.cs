using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOn : MonoBehaviour
{
    public GameObject text;
    public void Start()
    {
        text.SetActive(false);
    }
    public void OnMouseOver()
    {
        text.SetActive(true);
    }
    public void OnMouseExit()
    {
        text.SetActive(false);
    }
}
