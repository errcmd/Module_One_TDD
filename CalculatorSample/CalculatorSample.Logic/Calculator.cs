using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSample.Logic
{
    public class Calculator
    {
        private ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }
        public int Plus(int x, int y)
        {
            _logger.Log($"Operation Plus: x ={x}, y={y}");
            return x + y;
        }

        public int Minus(int x, int y)
        {
            _logger.Log($"Operation Minus: x ={x}, y={y}");
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            _logger.Log($"Operation Multiply: x ={x}, y={y}");
            return x * y;
        }

        public double Divide(int x, int y )
        {
            //_logger.Log($"Operation Degree: x ={x}, y={y}");

            return (y == 0) ? throw new DivideByZeroException(): (double)x /(double)y;
        }
        public double Degree(int x, int y)
        {
            _logger.Log($"Operation Degree: x ={x}, y={y}");
            return Math.Pow(x, y);
        }

    }

    public class Logger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.txt", message);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }
}
