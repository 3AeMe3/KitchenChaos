using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class KitchenObjects : MonoBehaviour
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;

    private IKitchenObjectsParents kitchenObjectsParents;

    public KitchenObjectsSO GetKitchenObjectsSO()
    {
        return kitchenObjectsSO;
    }



    public void SetKitchenObjectParent(IKitchenObjectsParents kitchenObjectsParents)
    {
        if(this.kitchenObjectsParents != null)
        {
            this.kitchenObjectsParents.ClearKitchenObjects(); 
        }
        this.kitchenObjectsParents = kitchenObjectsParents;

        if (kitchenObjectsParents.HasKitchenObjects())
        {
            Debug.LogError("kitchenObjectsParents already has a kitchenObject!");
        }

        kitchenObjectsParents.SetKitchenObjects(this);
        transform.parent = kitchenObjectsParents.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public IKitchenObjectsParents GetKitchenObjectParent()
    {
        return kitchenObjectsParents;
    }


}
