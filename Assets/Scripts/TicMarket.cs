using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicMarket : MonoBehaviour
{
    /*El supermercado TicMarket nos pide que realicemos un programa para que sus clientes puedan calcular el costo de algunos productos
      que se encuentran en promoción

    Se pide que se ingrese por inspector:
    . Los nombre de tres productos
    . Los precios de cada producto
    . La cantidad de unidades deseada de cada producto

    El programa debe cumplir los siguientes requerimientos:

    Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

    El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.

    El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto
    total sin descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.
    */

    public string nombre1 = "";
    public string nombre2 = "";
    public string nombre3 = "";
    public float precio1 = 0;
    public float precio2 = 0;
    public float precio3 = 0;
    public int cantidad1 = 1;
    public int cantidad2 = 1;
    public int cantidad3 = 1;
    float monto1 = 0;
    float monto2 = 0;
    float monto3 = 0;
    float Descuento1 = 0;
    float Descuento2 = 0;
    float Descuento3 = 0;
    float montoTotal = 0;
    float montoDescuentos = 0;
    float montoTotalConDescuento = 0;
    bool descuentoAplicado1 = false;
    bool descuentoAplicado2 = false;
    bool descuentoAplicado3 = false;
    // Start is called before the first frame update
    void Start()
    {
        if (precio1 >= 1 && precio2 >= 1 && precio3 >= 1)
        {
            if (cantidad1 >= 1 && cantidad2 >= 1 && cantidad3 >= 1)
            {
                monto1 = precio1 * cantidad1;
                monto2 = precio2 * cantidad2;
                monto3 = precio3 * cantidad3;

                montoTotal = monto1 + monto2 + monto3;

                if (cantidad1 > 3)
                {
                    Descuento1 = precio1 * cantidad1 * 0.20f;
                    descuentoAplicado1 = true;
                }
                if (cantidad2 > 3)
                {
                    Descuento2 = precio2 * cantidad2 * 0.20f;
                    descuentoAplicado2 = true;
                }
                if (cantidad3 > 3)
                {
                    Descuento3 = precio3 * cantidad3 * 0.20f;
                    descuentoAplicado3 = true;
                }
                montoDescuentos = Descuento1 + Descuento2 + Descuento3;
                montoTotalConDescuento = montoTotal - montoDescuentos;

                Debug.Log("Nombre del primer producto: " + nombre1 + ", Precio: $" + monto1 + ", Cantidad: " + cantidad1 + " y Se aplico el descuento? " + descuentoAplicado1 +
                    "\nNombre del segundo producto: " + nombre2 + ", Precio: $" + monto2 + ", Cantidad: " + cantidad2 + " y Se aplico el descuento? " + descuentoAplicado2);
                Debug.Log("Nombre del tercer producto: " + nombre3 + ", Precio: $" + monto2 + ", Cantidad: " + cantidad3 + " y Se aplico el descuento? " + descuentoAplicado3 +
                    "\nMonto total sin descuentos: " + montoTotal);
                Debug.Log("Monto de los descuentos: " + montoDescuentos +
                    "\nMonto final: " + montoTotalConDescuento);
            }
            else
            {
                Debug.Log("Alguna de las tres cantidades de " + nombre1 + ", " + nombre2 + " o " + nombre3 + " era menor a 1");
            }
        }
        else
        {
            Debug.Log("Alguno de los tres precios de " + nombre1 + ", " + nombre2 + " o " + nombre3 + " era menor a 1");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
