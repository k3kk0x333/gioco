using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] GameObject LuceTorcia;
    private bool TorciaAccesa = false;
    // Start is called before the first frame update
    void Start()
    {
        LuceTorcia.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            if(TorciaAccesa == false){
                LuceTorcia.gameObject.SetActive(true);
                TorciaAccesa=true;
            }else
            {
                LuceTorcia.gameObject.SetActive(false);
                TorciaAccesa=false;
            }
        }
    }
}
