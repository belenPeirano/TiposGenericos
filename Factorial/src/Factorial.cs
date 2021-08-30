using System;
namespace Factorial{
    class Factorial{
        public static int FactFor(int n){
            int m = 1;
            for (int i = 1; i < n+1; i++){
                m *= i;
            }
            return m;
        }

        public static int FactWhile(int N){
            int r = 1;
            int t = 1;
            while (r < N+1){
                t *= r;
                r += 1;
            }
            return t;
        }
    }
}