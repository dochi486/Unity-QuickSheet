using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLoader : MonoBehaviour
{

    public ��Ʈ1 playerItem;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("Value: {0}", playerItem.dataArray[0].Name);
    }


}
