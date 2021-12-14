using System;
using System.Collections.Generic;

class Program {

static int Minsta(List<int> listan) {
    int i = listan[0];
    foreach (int element in listan){
        if (i > element){
            i=element;
        }
    }
    return i;
}

static int Största(List<int> listan) {
    int i = listan[0];
    foreach (int element in listan){
        if (i < element){
            i=element;
        }
    }
    return i;
}

static void SkrivUt(List<int> listan) {
    int i =0;
    foreach(int element in listan){
        i=(element+i);
    }
    Console.WriteLine(i);
}


public static void Main (string[] args) {
    List<int> minLista = new List<int>();
    minLista.Add(11); 
    minLista.Add(5);
    minLista.Add(12); 
    minLista.Add(3);
    minLista.Add(6); 
    minLista.Add(3);

    SkrivUt(minLista);

    Console.WriteLine("Största tal: "+Största(minLista));
    Console.WriteLine("Minsta tal: "+Minsta(minLista));
}
}