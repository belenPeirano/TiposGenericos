using System.Collections;
using System.Collections.Generic;
using System;


namespace SymDiff{
    class SymDiff{
        public static List<int> Dif(List<int> lista1, List<int> lista2){
            List<int> diferencia = new List<int>();
            foreach (int num in lista1){
                if (!lista2.Contains(num)){
                    diferencia.Add(num);
                }
            }
            foreach (int num2 in lista2){
                if (!lista1.Contains(num2)){
                    diferencia.Add(num2);
                }
            }
            return (diferencia);

        }
    }
}