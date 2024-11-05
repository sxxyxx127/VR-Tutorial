using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreshCan : MonoBehaviour
{
    
    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTrash);
    }

    public void InsideTrash(GameObject go)
    {
        go.SetActive(false);
    }

   
}
