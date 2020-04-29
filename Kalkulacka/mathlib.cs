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
                throw new DivideByZeroException();
                return -123456789.98765;
            }

            return A / B;
        }

        public double fac(double A){
            if(A < 0){
                throw new NotFiniteNumberException();
                return -123456789.54321;
            }
            if(A % 1 != 0){
                throw new NotFiniteNumberException();
                return -123456789.54321;
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
            if (B == 0)
            {
                throw new DivideByZeroException();
            }
            return Math.Pow(B, 1.0 / A);
        }

        public double log(double A, double B){
            double res = A * Math.Log10(B);
            if (double.IsInfinity(res) || double.IsNaN(res))
            {
                throw new NotFiniteNumberException();
            }
            return res;
        }

        public double neg(double A){
            return A * -1;
        }
        
    }
}