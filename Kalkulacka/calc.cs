using System;
using System.Collections;

public class calcmain{ 
  
        public double getResult(string[] parts, string[] type){
            Stack stackSign = new Stack();
            Stack stackNum = new Stack();
            Stack stackRes = new Stack();
            int len = parts.Length;
            int i = 0;

            //double.Parse(parts[i])
            string peekSign;
            string peekNum;
            string peekRes;

            double leftSide = 0;
            double rightSide = 0;
            double result = 0;


            if(len > 0){
                while(i < 0){
                    
                    if(i > 0){
                        if(type[i] == "sign"){
                            if(parts[i] == "+" ^ parts[i] == "-" ){
                                if(stackRes.Count != 0){
                                    peekSign = stackSign.Peek();
                                    peekNum = stackSign.Peek();
                                    peekRes = stackRes.Peek();
                                    leftSide = double.Parse(peekNum);
                                    rightSide = double.Parse(peekRes);

                                    if(peekSign == '+'){
                                        result = add(leftSide, rightSide);
                                    }else if(peekSign == '-'){
                                        result = sub(leftSide, rightSide);
                                    }

                                    stackSign.Pop();
                                    stackNum.Pop();
                                    stackRes.Pop();

                                    parts.SetValue(string.parse(result), i-1);

                                }
                                if(stackSign.Count != 0){
                                    peekSign = stackSign.Peek();
                                    peekNum = stackSign.Peek();
                                    leftSide = double.Parse(peekNum);
                                    rightSide = double.Parse(parts[i-1]);

                                    if(peekSign == '+'){
                                        result = add(leftSide, rightSide);
                                    }else if(peekSign == '-'){
                                        result = sub(leftSide, rightSide);
                                    }

                                    stackSign.Pop();
                                    stackNum.Pop();

                                    stackSign.Push(parts[i]);
                                    stackNum.Push(result);

                                }else{
                                    stackSign.Push(parts[i]);
                                    stackNum.Push(parts[i-1]);
                                }
                                
                            }else if(parts[i] == "*" ^ parts[i] == "/"){
                                if(stackRes.Count != 0){
                                    peekRes = stackRes.Peek();
                                    leftSide = double.Parse(peekRes);
                                    rightSide = double.Parse(parts[i+1]);

                                    if(peekSign == '*'){
                                        result = mul(leftSide, rightSide);
                                    }else if(peekSign == '/'){
                                        result = div(leftSide, rightSide);
                                    }

                                    stackRes.Pop();
                                    stackRes.Push(result);

                                }else{
                                    leftSide = double.Parse(parts[i-1]);
                                    rightSide = double.Parse(parts[i+1]);

                                    if(parts[i] == '*'){
                                        result = mul(leftSide, rightSide);
                                    }else if(parts[i]  == '/'){
                                        result = div(leftSide, rightSide);
                                    }

                                    stackRes.Push(result);
                                }
                            }
                        }
                    }else{
                        if(len == 1){ // pridat fac atd.
                            return double.Parse(parts[0]);
                        }
                    }

                   i += 1; 
                }

                if(stackRes.Count != 0){
                    peekRes = stackRes.Peek();
                    peekNum = stackNum.Peek();
                    peekSign = stackSign.Peek();
                    leftSide = double.Parse(peekNum);
                    rightSide = double.Parse(peekRes);

                    if(peekSign == '+'){
                        result = add(leftSide, rightSide);
                    }else if(peekSign == '-'){
                        result = sub(leftSide, rightSide);
                    }

                    stackRes.Pop();
                    stackNum.Pop();
                    stackSign.Pop();

                }else if(stackNum.Count != 0){
                    peekNum = stackNum.Peek();
                    peekSign = stackSign.Peek();
                    leftSide = double.Parse(peekNum);
                    rightSide = double.Parse(parts[len-1]);

                    if(peekSign == '+'){
                        result = add(leftSide, rightSide);
                    }else if(peekSign == '-'){
                        result = sub(leftSide, rightSide);
                    }
                }
                return result;
            }
        }
    } 