using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;
    [SerializeField] private Transform counterTopPoint;

    public void Interact()
    {
        Transform kitchenObjectSoTransform = Instantiate(kitchenObjectsSO.prefab, counterTopPoint) ;
        kitchenObjectSoTransform.localPosition = Vector3.zero;
    }
}
