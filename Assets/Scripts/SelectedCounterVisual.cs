using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] visualGameObjectArray;

    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if(e.selectedCounter == baseCounter)
        {
            Show();
        }
        else
        {

            Hide();
        }
    }


    void Show()
    {
        foreach(GameObject visualGameObject in visualGameObjectArray)
        {
         visualGameObject.SetActive(true);

        }
    }
    void Hide()
    {
        foreach (GameObject visualGameObject in visualGameObjectArray)
        {
            visualGameObject.SetActive(false);

        }
    }

}
