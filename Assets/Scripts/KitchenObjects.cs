using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class KitchenObjects : MonoBehaviour
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;


    public KitchenObjectsSO GetKitchenObjectsSO()
    {
        return kitchenObjectsSO;
    }


}
