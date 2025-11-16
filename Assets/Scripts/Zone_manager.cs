using Unity.Cinemachine;
using UnityEngine;

public class Zone_manager : MonoBehaviour
{
    public CinemachineCamera[] camaras;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cambiar_camara(int num_camara)
    {
        //SI EL NUM DE LA CAMARA ES X, ESE X DEBERIA PONER EN PRIORITO AL NUM DE LA
        int camara_escogida = num_camara; 
        if (num_camara == camara_escogida)
        {
            camaras[camara_escogida].Priority = 1;

        }
        else
        {
            for (int i = 0; i < camaras.Length; i++)
            {
                //SI EL RECORRIDO ES DISTINTO AL NUMERO ESCOGIDO QUE ES LA CAMARA
                if (i != camara_escogida)
                {
                    //PONEMOS TODA LAS CAMARAS EN 
                    camaras[i].Priority = 0;
                }
                else
                {
                    camaras[i].Priority = 1;
                }
            }
        }
    }
}
