using System;
using System.IO;
using System.Text;

namespace AoC2019
{
    public abstract class AoCDay 
    {
        protected abstract AoCStatus Status { get; }

        public void Run() 
        {
            var inputFileName = this.GetType().Namespace + ".input.txt";
            using var stream = this.GetType().Assembly.GetManifestResourceStream(inputFileName);
            using var reader = new StreamReader(stream, Encoding.UTF8);
            
            var inputLines = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            this.Execute(inputLines);
        }

        protected abstract void Execute(string[] inputLines);
    }
}
