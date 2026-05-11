using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public class Noce : MonoBehaviour
{

    public int count = 10;

    List<string> nombres = new List<string>() {"pepe", "maliketh", "dash", "pepe" };

    string[] nombres2 = new string[4] {"pepe","maliketh","goku","ichigo" };
    
    public bool IsValid = false;   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      while (count > 0)
        {
            print("cuenta regresiva " + count);
            count--;
        }
        while (IsValid == false)
        {
            print("se logro verificar al jugador");
            IsValid = true;
        }

        int i = 0;

        while (i < nombres2.Length)
        {
            print ("el elemento en la pocision " + i + " tiene de valor " +  nombres2[i]);
            i++;

        }
        while ( i < nombres.Count)
        {
            print(nombres[i]);
            if (nombres[i] == "c")
            {
                print("el elemento c se encuentra en la posicion " + i);

            }

        }




    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
