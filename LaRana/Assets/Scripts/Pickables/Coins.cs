using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour, IPickable
{
    public void Start()
    {
        
    }
    public void pick()
    {
        Destroy(gameObject);
    }

    public int getCurrency()
    {
        return 1;
    }

}
