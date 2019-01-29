using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddImages : MonoBehaviour
{
    public GameObject content;
    // Use this for initialization
    void Start()
    {
        object[] images;
        for (int i = 0; i < 7; i++)
        {
            images = Resources.LoadAll("images/" + (i+1).ToString(), typeof(Sprite));
            for (int j = 0;j < 3; j++)
            {
                Image img = content.transform.GetChild(i).GetChild(j).GetChild(1).gameObject.GetComponent<Image>();
                img.sprite = (Sprite)images[j];
                img.preserveAspect = true;
            }            
        }
    }
}
