using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public List<GameObject> Gates;
    
    void Start()//Confirma se estão ativados
    {
        foreach (GameObject gates in Gates)
        {
            gates.SetActive(true);
        }
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(3);
    }

    private void OnTriggerExit(Collider other)//ativa portas quando sair
    {

        
        foreach (GameObject gates in Gates)
        {
            waitTime();
            gates.SetActive(true);
        }
    }
    
    private void OnTriggerEnter(Collider other)//desativa portas quando entrar
    {
        foreach (GameObject gates in Gates)
        {
            gates.SetActive(false);
        }
    }
    
}
