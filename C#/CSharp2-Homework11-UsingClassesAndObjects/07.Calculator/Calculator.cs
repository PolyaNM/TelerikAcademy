
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

public class ExpressionCalculator
{
    public static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };
    public static List<char> brackets = new List<char>() { '(', ')' };
    public static List<char> arithmeticOperations = new List<char>() { '+', '-', '*', '/' };
    public static List<string> SeparateTokens(string input)
    {
        var result = new List<string>();
        var number = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '(')) 
            {
                number.Append('-');
            }
            else if (char.IsDigit(input[i]) || input[i] == '.')
            {
                number.Append(input[i]);
            }
            else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
            {
                result.Add(number.ToString());
                number.Clear();
                i--;
            }
            if (brackets.Contains(input[i]))
            {
                result.Add(input[i].ToString());
            }
            else if (arithmeticOperations.Contains(input[i]))
            {
                result.Add(input[i].ToString());
            }
            else if (input[i] == ',')
            {
                result.Add(",");
            }
            else if (i + 1 < input.Length && input.Substring(i, 2) == "ln")
            {
                result.Add("ln");
                i++; // because we take 2 symbols (ln)
            }
            else if (i + 2 < input.Length && input.Substring(i, 3) == "pow")
            {
                result.Add("pow");
                i+= 2; // because we take 3 symbols (pow)
            }
            else if (i + 3 < input.Length && input.Substring(i, 4) == "sqrt")
            {
                result.Add("sqrt");
                i += 3; // because we take 4 symbols (sqrt)
            }
            else
            {
                throw new ArgumentException("Invalid expression");    
            }
        }
        if (number.Length != 0)
        {
            result.Add(number.ToString());
        }
        return result;
    }

    public static void PutInvariantCulture() // for example 3.5, not 3,5
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
    }
    public static int Precedence(string arithmeticOper)
    {
        if (arithmeticOper == "+" || arithmeticOper == "-")
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    public static Queue<string> ConvertToReversePolishNotation(List<string> tokens)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queque = new Queue<string>();
        for (int i = 0; i < tokens.Count; i++)
        {
            var currentToken = tokens[i];
            double number;

            if (double.TryParse(currentToken, out number))
            {
                queque.Enqueue(currentToken);
            }
            else if (functions.Contains(currentToken))
            {
		        stack.Push(currentToken);
            }
            else if (currentToken == ",")
	        {
		        if(!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Invalid functions separator or brackets");
                }

                while (stack.Peek() != "(")
	            {
                    queque.Enqueue(stack.Pop());
	            }   
	        }
                
            else if (arithmeticOperations.Contains(currentToken[0]))
	        {
                while (stack.Count != 0 && arithmeticOperations.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()) )
                {
                    queque.Enqueue(stack.Pop());
                }
                stack.Push(currentToken);
	        }
            else if (currentToken == "(")
	        {
                stack.Push("(");
	        }
            else if (currentToken == ")")
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("The position of the brackets is invalid!");
                }
                while (stack.Peek() != "(")
                {
                    queque.Enqueue(stack.Pop());
                }
                stack.Pop();

                if (stack.Count != 0 && functions.Contains(stack.Peek()))
                {
                    queque.Enqueue(stack.Pop());
                }
            }
        }

        while (stack.Count != 0)
        {
            if (brackets.Contains(stack.Peek()[0]))
            {
                throw new ArgumentException("Invalid Bracket Position!");
            }
            queque.Enqueue(stack.Pop());
        }
        return queque;
    }

    public static double GetResultFromReversePolishNotation(Queue<string> queue)
    {
        Stack<double> stack = new Stack<double>();
        while (queue.Count != 0)
        {
            string currentToken = queue.Dequeue();
            double number;

            if (double.TryParse(currentToken, out number))
	        {
		        stack.Push(number);
	        }
            else if (arithmeticOperations.Contains(currentToken[0]) || functions.Contains(currentToken))
	        {
                if (currentToken == "+")
	            {
		            if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid exception!");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();
                    stack.Push(firstValue + secondValue);
	            }
                else if (currentToken == "-")
	            {
		            if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid exception!");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();
                    stack.Push(secondValue - firstValue);
	            }
                else if (currentToken == "*")
	            {
		            if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid exception!");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();
                    stack.Push(firstValue * secondValue);
	            }
                else if (currentToken == "/")
	            {
		            if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid exception!");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();
                    stack.Push(secondValue / firstValue);
	            }
                else if (currentToken == "pow")
	            {
		            if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid exception!");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();
                    stack.Push(Math.Pow(secondValue, firstValue));
	            }
                                else if (currentToken == "-")
	            {
		            if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid exception!");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();
                    stack.Push(secondValue - firstValue);
	            }
                else if (currentToken == "sqrt")
	            {
		            if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid exception!");
                    }
                    double value = stack.Pop();
                    stack.Push(Math.Sqrt(value));
	            }
                else if (currentToken == "ln")
	            {
		            if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid exception!");
                    }
                    double value = stack.Pop();
                    stack.Push(Math.Log(value));
	            }
	        }
        }
        if (stack.Count == 1)
	    {
		    return stack.Pop();
	    }
        else
        {
            throw new ArgumentException("Invalid expression!");
        }
    }

    static void Main()
    {
        PutInvariantCulture();
        string input = Console.ReadLine().Trim();
        //removes the white spaces (if any) in the input 
        input.ToLower(); // If the input contains LN or POW etc.
        string trimmedInput = input.Replace(" ", string.Empty);
        var seperatedTokens = SeparateTokens(trimmedInput); // or List<string> instead of "var".
        var reversePolishNotation = ConvertToReversePolishNotation(seperatedTokens);
        var finalResult = GetResultFromReversePolishNotation(reversePolishNotation);

        Console.WriteLine(finalResult);
    }
}

