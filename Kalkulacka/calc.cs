using System;
using System.Collections;



namespace calcB{
    public class calcmain{ 
  
        public double getResult(string[] parts){

            library.basic mathLab = new library.basic();

            Stack stackSign = new Stack();
            Stack stackNum = new Stack();
            Stack stackRes = new Stack();
            int len = parts.Length;
            int i = 0;

            string[] type = new string[100]; // ++

            //double.Parse(parts[i])
            string peekSign;
            string peekNum;
            string peekRes;

            double leftSide = 0;
            double rightSide = 0;
            double result = -123456789.54321;
            int indexer = 0;

            string ms;
            string ls;
            string rs;


            if(len > 0){

                for(i = 0; i < len; i++){
                    
                    //Console.WriteLine(parts[i]);
                    
                    if(parts[i] == "+" ^ parts[i] == "-"
                    ^ parts[i] == "*" ^ parts[i] == "/"){
                        type[i] = "sign";
                    }else{
                        type[i] = "num";

                        ms = parts[i];
                        indexer = ms.IndexOf("-/"); // err
                        if(indexer > -1){
                            ls = ms.Substring(0,indexer);
                            rs = ms.Substring(indexer+2);
                            
                            if(indexer == 0){
                                ls = "2";
                            }
                            if(ms.Length == 3){
                                return result;
                            }
                            //Console.WriteLine(mathLab.root(double.Parse(ls),double.Parse(rs)));
                            parts[i] = mathLab.root(double.Parse(ls),double.Parse(rs)).ToString();

                        }else{
                            indexer = parts[i].IndexOf("^");
                            if(indexer > -1){
                                ls = ms.Substring(0,indexer);
                                rs = ms.Substring(indexer+1);
                                
                                if(indexer+1 == ms.Length){
                                    return result;
                                }

                                parts[i] = mathLab.exp(double.Parse(ls),double.Parse(rs)).ToString();

                            }else{
                                indexer = parts[i].IndexOf("!");
                                if(indexer > -1){
                                    ls = ms.Substring(0,indexer);
                                    Console.WriteLine("ls");
                                    Console.WriteLine(ls);
                                    if(double.Parse(ls) % 1 != 0){
                                        return double.Parse("-123456789,54321");
                                    }
                                    parts[i] = mathLab.fac(double.Parse(ls)).ToString();

                                }else{
                                    indexer = parts[i].IndexOf("log");
                                    if(indexer > -1){
                                        ls = ms.Substring(0,indexer);
                                        rs = ms.Substring(indexer+3);
                                        if(indexer == 0){
                                            ls = "1";
                                        }
                                        if(ms.Length == 3){
                                            return result;
                                        }
                                        parts[i] = mathLab.log(double.Parse(ls),double.Parse(rs)).ToString();
                                    }
                                }
                            }
                        }
                        
                    }
                }
                //Console.WriteLine("");

                i = 0;

                while(i < len){
                    //Console.WriteLine(parts[i]);
                    if(i > 0){
                        if(type[i] == "sign"){
                            if(parts[i] == "+" ^ parts[i] == "-" ){
                                if(stackRes.Count != 0){
                                    peekSign = stackSign.Peek().ToString();
                                    peekNum = stackNum.Peek().ToString();
                                    peekRes = stackRes.Peek().ToString();
                                    leftSide = double.Parse(peekNum);
                                    rightSide = double.Parse(peekRes);

                                    if(peekSign == "+"){
                                        result = mathLab.add(leftSide, rightSide);
                                    }else if(peekSign == "-"){
                                        result = mathLab.sub(leftSide, rightSide);
                                    }

                                    stackSign.Pop();
                                    stackNum.Pop();
                                    stackRes.Pop();

                                    parts.SetValue(result.ToString(), i-1);

                                }
                                if(stackSign.Count != 0){
                                    peekSign = stackSign.Peek().ToString();
                                    peekNum = stackNum.Peek().ToString();
                                    leftSide = double.Parse(peekNum);
                                    rightSide = double.Parse(parts[i-1]);

                                    if(peekSign == "+"){
                                        result = mathLab.add(leftSide, rightSide);
                                    }else if(peekSign == "-"){
                                        result = mathLab.sub(leftSide, rightSide);
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
                                    peekSign = stackSign.Peek().ToString();
                                    peekRes = stackRes.Peek().ToString();
                                    leftSide = double.Parse(peekRes);
                                    rightSide = double.Parse(parts[i+1]);

                                    if(peekSign == "*"){
                                        result = mathLab.mul(leftSide, rightSide);
                                    }else if(peekSign == "/"){
                                        result = mathLab.div(leftSide, rightSide);
                                    }

                                    stackRes.Pop();
                                    stackRes.Push(result);

                                }else{
                                    leftSide = double.Parse(parts[i-1]);
                                    rightSide = double.Parse(parts[i+1]);

                                    if(parts[i] == "*"){
                                        result = mathLab.mul(leftSide, rightSide);
                                    }else if(parts[i]  == "/"){
                                        result = mathLab.div(leftSide, rightSide);
                                    }

                                    stackRes.Push(result);
                                }

                                if(result == -123456789.98765){
                                    return result;
                                }
                            }
                        }
                    }else{
                        if(len == 1){ // pridat fac atd.
                            //Console.WriteLine("len == 1");
                            return double.Parse(parts[0]);
                        }
                    }

                   i += 1; 
                }

                if(stackRes.Count != 0){
                    peekRes = stackRes.Peek().ToString();
                    peekNum = stackNum.Peek().ToString();
                    peekSign = stackSign.Peek().ToString();
                    leftSide = double.Parse(peekNum);
                    rightSide = double.Parse(peekRes);

                    if(peekSign == "+"){
                        result = mathLab.add(leftSide, rightSide);
                    }else if(peekSign == "-"){
                        result = mathLab.sub(leftSide, rightSide);
                    }

                    stackRes.Pop();
                    stackNum.Pop();
                    stackSign.Pop();

                }else if(stackNum.Count != 0){
                    
                    peekNum = stackNum.Peek().ToString();
                    peekSign = stackSign.Peek().ToString();
                    leftSide = double.Parse(peekNum);
                    rightSide = double.Parse(parts[len-1]);

                    if(peekSign == "+"){
                        result = mathLab.add(leftSide, rightSide);
                    }else if(peekSign == "-"){
                        result = mathLab.sub(leftSide, rightSide);
                    }
                }
                Console.WriteLine(result);
                return result;
            }
            return result;
        }
    } 
}