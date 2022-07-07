using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Declaration des variables : (variables globals)
    public float a, b;
    public string vide = " ";

    //Declaration des fonctions : 
    void Start()
    {
        Sum(a, b);
    }
    float Sum(float a,float b)
    {
        // variable local : ( variable bach nesta-3malha kan fil fonction alli ktebt fiha ) 
        float resultat = (a + b);
        // Le message a afficher dans la consol :
        Debug.Log(resultat);
        // le retour du resultat :
        return resultat;
    }
}
