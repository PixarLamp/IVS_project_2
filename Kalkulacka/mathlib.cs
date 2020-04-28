using System;

namespace library{
    public class basic{

        public double add(double A, double B){
            return A + B;
        }

        public double sub(double A, double B){
            return A - B;
        }

        public double mul(double A, double B){
            return A * B;
        }

        public double div(double A, double B){
            if(B == 0){
                return 0;
            }

            return A / B;
        }

        public double fac(double A){
            if(A < 0){
                return 0;
            }

            int result = 1;
            int counter = 1;

            while(counter <= A){
                result = result * counter;
                counter = counter + 1;
            }

            return result;
        }

        public double exp(double A, double B){
            if(B == 0){
                return 1;
            }

            return Math.Pow(A, B);
            
        }

        public double root(double A, double B){
            return Math.Pow(A, 1.0 / B);
        }

        public double log(double A){
            return Math.Log(A);
        }

        public double neg(double A){
            return A * -1;
        }
        
    }
}