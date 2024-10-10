
using PrimerParcialEjercicio7;

namespace Calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            ExpressionEvaluator evaluator = new ExpressionEvaluator();

            // Ejemplo de uso con expresión infija
            Console.WriteLine("Calculadora Infix:");
            string infixExpression = "3 + 5 * ( 2 - 8 )";
            Console.WriteLine($"Evaluando: {infixExpression}");
            double infixResult = evaluator.EvaluateInfix(infixExpression);
            Console.WriteLine($"Resultado: {infixResult}");

            // Ejemplo de uso con expresión prefija
            Console.WriteLine("\nCalculadora Prefix:");
            string prefixExpression = "+ 3 * 5 2";
            Console.WriteLine($"Evaluando: {prefixExpression}");
            double prefixResult = evaluator.EvaluatePrefix(prefixExpression);
            Console.WriteLine($"Resultado: {prefixResult}");

            Console.ReadLine();
        }
    }
}