/**
 * @file mathlib.cs
 * @author ¼uboš Šèevik
 * @date 4-28-2020
 */
using System;

namespace library{
    public class basic{

        /**
         * @brief adds 2 numbers
         * @param A first number
         * @param B second number
         * @pre parameter A&B
         * @post sum of A&B
         */
        public double add(double A, double B){
            return A + B;
        }
        /**
         * @brief subtracts 2 numbers
         * @param A first number
         * @param B second number
         * @pre parameter A&B
         * @post subtraction of B from A
         */
        public double sub(double A, double B){
            return A - B;
        }
        /**
         * @brief multiplies 2 numbers
         * @param A first number
         * @param B second number
         * @pre parameter A&B
         * @post product of A&B
         */
        public double mul(double A, double B){
            return A * B;
        }
        /**
         * @brief divides 2 numbers
         * @param A first number
         * @param B second number
         * @pre parameter A&B
         * @post the result after division of A by B
         */
        public double div(double A, double B){
            if(B == 0){
                throw new DivideByZeroException();
                return -123456789.98765;
            }

            return A / B;
        }
        /**
         * @brief calculates factorial of the given number
         * @param A first number
         * @pre parameter A
         * @post factorial of A
         */
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
        /**
        * @brief calculates value of the entered number to the power of n
        * @param A first number
        * @param B second number
        * @pre parameter A&B
        * @post A to the power of B
        */
        public double exp(double A, double B){
            if(B == 0){
                return 1;
            }

            return Math.Pow(A, B);
            
        }
        /**
        * @brief calculates n-th root of the entered number
        * @param A first number
        * @param B second number
        * @pre parameter A&B
        * @post Bth root of A
        */
        public double root(double A, double B){
            if (B == 0)
            {
                throw new DivideByZeroException();
            }
            return Math.Pow(B, 1.0 / A);
        }
        /**
        * @brief calculates the value of the decadical logarithm 
        * @param A first number
        * @param B second number
        * @pre parameter A&B
        * @post A times log of B 
        */
        public double log(double A, double B){
            double res = A * Math.Log10(B);
            if (double.IsInfinity(res) || double.IsNaN(res))
            {
                throw new NotFiniteNumberException();
            }
            return res;
        }
        
    }
}