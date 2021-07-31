using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{

   // RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        Debug.Log("RectTransform Position" + this.transform);
        Debug.Log("Screen Position : "+Camera.main.WorldToScreenPoint(Input.mousePosition));
        Debug.Log("World Position : "+Input.mousePosition);
        Debug.Log("Button Click ! ");
    }
}
