using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public List<GameObject> Gates;

    private float time = 2f;
    

    void Start()//Confirma se estão ativados
    {
        foreach (GameObject gates in Gates)
        {
            gates.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)//confirma se o player ta em cima da placa de pressao
    {

        Invoke("SetObjectTrue", time);

    }

    public void SetObjectTrue() //seta ativo o objeto
    {
        foreach (GameObject gates in Gates)
        {
            if (gates != true)
            {
                gates.SetActive(true);
            }
            else
            {
                gates.SetActive(false);
            }

        }
    }

    public void SetObjectFalse() //seta falso o objeto
    {
        foreach (GameObject gates in Gates)
        {
            if (gates != false)
            {
                gates.SetActive(true);
            }
            else
            {
                gates.SetActive(false);
            }

        }
    }

    private void OnTriggerExit(Collider other)//executa quando o player sai da placa de pressao
    {
        Invoke("SetObjectFalse", time);
    }
    
    
    
}
