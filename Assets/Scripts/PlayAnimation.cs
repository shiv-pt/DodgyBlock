using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private Animator animationController;
    private void OnTriggerEnter(Collider other) {
        Debug.Log(animationController);
        if(other.CompareTag("Player"))
        animationController.SetBool("LvlComp",true);
    }
    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player"))
        animationController.SetBool("LvlComp",false);
    }
}
