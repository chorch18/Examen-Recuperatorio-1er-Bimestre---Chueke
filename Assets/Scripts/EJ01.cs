using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Heladería "Los tres gustos"

//Esta heladería ofrece 3 gustos: chocolate, frutilla y dulce de leche y toma pedidos mediante códigos.
//El cliente debe pedir los gustos ingresando CHO, FRU y DDL.Además debe ingresar una cantidad de helado en gramos (250 para un cuarto, 500 para medio k, etc). 
//Esta semana tiene una promoción con frutilla, por lo que el precio se reduce un %10 solo en ese gusto.


//.Mostrar un mensaje de error y ningún otro mensaje ni realizar ningún cálculo si no se ingresa un código válido o si las cantidades de helado son menores a 250 o mayores que 3000. 

//. Sabiendo que el kilo de helado sale $500, devolver el costo del pedido si los ingresos son válidos. Recuerdo contemplar la promoción.
public class EJ01 : MonoBehaviour
{

    public string gusto;
    public int gramos;
    void Start()
    {
        if (gramos<250)
        {
            Debug.Log("La cantidad debe ser mayor a 250");
        }
        else if (gramos > 3000)
        {
            Debug.Log("La cantidad debe ser menor a 3000");
        }
        else
        {
            switch (gusto)
            {
                case "CHO":
                    Debug.Log("El costo es de $" + gramos /2);
                    break;
                case "FRU":
                    Debug.Log("El costo es de $" + (gramos /2)%90);
                    break;
                case "DDL":
                    Debug.Log("El costo es de $" + gramos/2);
                    break;
                default:
                    Debug.Log("Gusto no valido");
                    break;
            }
        }
    }

    void Update()
    {
        
    }
}
