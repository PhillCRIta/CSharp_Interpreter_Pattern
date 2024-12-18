using Behavioral_Interpreter;

string input = "1 + 2 * 3";
//context can contain the information needed for interpretation process
//in our case context is empty
Context context = new Context();
Interpreter interpreter = new Interpreter(context);
int result = interpreter.Interpret(input);

Console.WriteLine("Result: " + result);