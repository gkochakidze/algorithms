// https://codeforces.com/problemset/problem/785/A
using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class AntonPolyhedrons
    {
        public void ParseSolveWrite()
        {
            var layers = Parse();
            var result = Solve(layers);
            Write(result);
        }

        private List<string> Parse()
        {
            var polyhedrons = new List<string>();
            var numOfPolyhedrons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfPolyhedrons; i++)
                polyhedrons.Add(Console.ReadLine());
            return polyhedrons;
        }

        private int Solve(List<string> polyhedrons)
        {
            var numOfFaces = 0;
            var polyhedronMappings = new Dictionary<string, int>()
            {
                { "Tetrahedron",  4 },
                { "Cube",  6 },
                { "Octahedron",  8 },
                { "Dodecahedron",  12 },
                { "Icosahedron",  20 }
            };
            foreach (var polyhedron in polyhedrons)
                numOfFaces += polyhedronMappings[polyhedron];
            return numOfFaces;
        }

        private void Write(int result)
        {
            Console.WriteLine(result);
        }
    }
}
