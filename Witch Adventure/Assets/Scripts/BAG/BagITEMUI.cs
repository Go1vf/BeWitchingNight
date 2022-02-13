using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 
/// </summary>
public class BagITEMUI : MonoBehaviour
{
    public Text NAMETEX;
    public Image IMG;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="namestr"></param>
    /// <param name="sp"></param>
    public void OnInitialized(string namestr ,Sprite sp)
    {
        NAMETEX.text = namestr;
        IMG.sprite = sp;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
