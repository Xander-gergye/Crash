using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicTrigger : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject cutscene;
    [SerializeField] GameObject cinematicCamera;

    private void OnTriggerEnter(Collider other)
    {
        
        player.SetActive(false);
        cutscene.SetActive(true);
        cinematicCamera.SetActive(true);
        
    }
}
