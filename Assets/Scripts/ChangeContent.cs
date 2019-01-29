using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ChangeContent : MonoBehaviour {

    public void Next()
    {
        int i = EventSystem.current.currentSelectedGameObject.transform.parent.GetSiblingIndex();
        i = (i + 1) % 3;
        this.transform.parent.parent.GetChild(i).gameObject.SetActive(true);
        this.transform.parent.gameObject.SetActive(false);
    }

    public void Prev()
    {
        int i = this.transform.parent.GetSiblingIndex();
        i = (Mathf.Abs(i - 1)) % 3;
        this.transform.parent.parent.GetChild(i).gameObject.SetActive(true);
        this.transform.parent.gameObject.SetActive(false);
    }
}
