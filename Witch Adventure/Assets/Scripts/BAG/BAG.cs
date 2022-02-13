using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BAG : MonoBehaviour
{
    public static BAG instance;
    public bool hasshow = false;
    public GameObject ui;
    public BagITEMUI uipre;
    public Transform itemPARENT;
    private Dictionary <int ,objDATA >dicdatas;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        dicdatas = new Dictionary<int, objDATA>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input .GetKeyDown (KeyCode.I))
        {
            SetUISteate();
        }
       
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="sp"></param>
    public void CREATEITEM(objDATA data)
    {
        if(dicdatas .ContainsKey (data .id))
        {
            Debug.Log("zaicisiqu");
        }else
        {
            Instantiate(uipre, itemPARENT).OnInitialized(data.objname, data.uiicon);
            dicdatas.Add(data.id, data);
        }
        
    }

    public bool HASITEM(int id)
    {
        return dicdatas.ContainsKey(id);
    }
    public void SetUISteate()
    {
        hasshow = !hasshow;
        ui.SetActive(hasshow);
    }
}
