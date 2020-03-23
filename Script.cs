using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour{

    void Start(){
        //typ_zmiennej nazwa
        //deklaracja
          int a;
        //inicjalizacja
          a = 10;
        //2 w 1
          int b = 20;
          Debug.Log(a);

          float fa = 1.5f;
          fa = 20.0f;

        //zmienna logiczna
          bool logiczna = true; //albo false

        //napis
          string str = "napis";

          Debug.Log("fa: " + fa + " logiczna: " + logiczna + " str: " + str);
    
        //operacje na zmiennych
          Debug.Log(a/b);
          Debug.Log(a/fa);
          Debug.Log(Mathf.Sqrt(2));

        //operacje
          Debug.Log(a == b); //rowne
          Debug.Log(a != b); //rozne
          Debug.Log(a > b);
          Debug.Log(a >= b);
          Debug.Log(a < b);
          Debug.Log(a <=b);


        //if (warunek_logiczny) {}
    
         Koniunkcja(a,b);
         Alternatywa(a,b);

        int hp = 2, time = 1;
        bool amulet = true;

        if (hp <= 0 || time <= 0) {
         if (!amulet){ //sprawdzamy czy jest false  

         } else {
         }


    
    }

    public void Koniunkcja(int a, int b) {

         if(a == b) {
              Debug.Log("Tak, jest taka sama.");
          } else if (a > b) {
             Debug.Log("a > b");
	      } else 
            Debug.Log("Żadne z powyższych");

                if ((a != b) && (a > 0)) {
                 //kod
    	         }


	public void Alternatywa(int a, int b){
    
        int hp = 2, time = 1;
        bool amulet = true;

        if (hp <= 0 || time <= 0) {
         if (!amulet){ //sprawdzamy czy jest false  

         } else {
    
	     }
    }
    





    void Update(){
        
    }
}
