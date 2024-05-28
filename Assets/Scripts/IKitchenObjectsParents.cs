using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKitchenObjectsParents {
    public Transform GetKitchenObjectFollowTransform();

    public void SetKitchenObjects(KitchenObjects kitchenObjects);
    public KitchenObjects GetKitchenObjects();

    public void ClearKitchenObjects();
    public bool HasKitchenObjects();


}
