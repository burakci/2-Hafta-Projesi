using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class HelloWorld : MonoBehaviour
{
    //int tam sayi 
    //float virg�l 
    //string text 
    //bool true false


    void bolenleriBul(int ilkSayi, int ikinciSayi)
    {   
            List<int> sayilar = new List<int>();

        //T�m Liste Elemanlar�
            for (int i = ilkSayi; i <= ikinciSayi; i++)
            {
                sayilar.Add(i);
            }
        print("T�m Liste : "+ string.Join(" - ", sayilar.ToArray()));


        //Sadece 2'ye Tam B�l�nebilenler
        List<int> ikiyeBolunebilenler = new List<int>();
        foreach (int eleman in sayilar)
        {
            if (eleman % 2 == 0)
            {
                ikiyeBolunebilenler.Add(eleman);
            }          
        }
        print("2'ye b�l�nebilenler : " + string.Join(" - ", ikiyeBolunebilenler.ToArray()));


        //Sadece 3'e Tam B�l�nebilenler
        List<int> uceBolunebilenler = new List<int>();
        foreach (int eleman in sayilar)
        {
            if (eleman % 3 == 0)
            {
                uceBolunebilenler.Add(eleman);
            }
        }
        print("3'e b�l�nebilenler : " + string.Join(" - ", uceBolunebilenler.ToArray()));

        //Sadece 4'e Tam B�l�nebilenler
        List<int> dordeBolunebilenler = new List<int>();
        foreach (int eleman in sayilar)
        {
            if (eleman % 4 == 0)
            {
                dordeBolunebilenler.Add(eleman);
            }
        }
        print("4'e b�l�nebilenler : " + string.Join(" - ", dordeBolunebilenler.ToArray()));

        //Sadece 5'e Tam B�l�nebilenler
        List<int> beseBolunebilenler = new List<int>();
        foreach (int eleman in sayilar)
        {
            if (eleman % 5 == 0)
            {
                beseBolunebilenler.Add(eleman);
            }
        }
        print("5'e b�l�nebilenler : " + string.Join(" - ", beseBolunebilenler.ToArray()));

    }
    void Start()
    {
        bolenleriBul(6, 77);
    }
}

