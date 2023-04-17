using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Garden
    {
        private List<Tree> _trees;
        private List<Fence> _fences;
        private List<Tree> _hull;
        private double _fencesLength;

        public List<Tree> Trees { get { return _trees; } }
        public List<Fence> Fences { get { return _fences; } }
        public List<Tree> Hull { get { return _hull; } }
        public double FencesLength { get { return _fencesLength; } }


        public Garden(List<Tree> trees)
        {
            _hull = new List<Tree>();
            _fences = new List<Fence>();
            _trees = trees;
            CreateFences();
            CalcualteFancesLenght();
        }

        private double CalcualteFancesLenght()
        {
            double sum = 0;

            foreach (Fence fence in _fences)
            {
                sum += fence.Length;
            }

            return sum;
        }

        private void CreateFences()
        {
            _hull = JarvisAlgorithm();
            for (int i = 0; i < _hull.Count; i++)
            {
                if (i + 1 >= _hull.Count)
                {
                    _fences.Add(new Fence(_hull[i], _hull[0]));
                }
                else
                {
                    _fences.Add(new Fence(_hull[i], _hull[i + 1]));
                }
            }
        }

        private List<Tree> JarvisAlgorithm()
        {
            Tree first = _trees[0];
            foreach (Tree tree in _trees)
            {
                if (tree.Y < first.Y || (tree.Y == first.Y && tree.X < first.X))
                {
                    first = tree;
                }
            }

            Tree current = first;
            Tree next;

            do
            {

                _hull.Add(current);

                next = _trees[0];

                for (int i = 1; i < _trees.Count; i++)
                {
                    if (next == current || CrossProductLength(current, next, _trees[i]) < 0)
                    {
                        next = _trees[i];
                    }
                    else if (CrossProductLength(current, next, _trees[i]) == 0 && Distance(current, next) < Distance(current, _trees[i]))
                    {
                        next = _trees[i];
                    }
                }

                current = next;

            } while (current != first);

            return _hull;
        }

        private double CrossProductLength(Tree a, Tree b, Tree c)
        {
            double ABx = b.X - a.X;
            double ABy = b.Y - a.Y;
            double ACx = c.X - a.X;
            double ACy = c.Y - a.Y;

            return ABx * ACy - ABy * ACx;
        }

        private double Distance(Tree a, Tree b)
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }



        public static bool operator ==(Garden gardenLeft, Garden gardenRight)
        {
            return gardenLeft._fencesLength == gardenRight._fencesLength;
        }

        public static bool operator !=(Garden gardenLeft, Garden gardenRight)
        {
            return !(gardenLeft == gardenRight);
        }

        public static bool operator <(Garden gardenLeft, Garden gardenRight)
        {
            return gardenLeft._fencesLength < gardenRight._fencesLength;
        }

        public static bool operator >(Garden gardenLeft, Garden gardenRight)
        {
            return !(gardenLeft > gardenRight);
        }

        public static bool operator <=(Garden gardenLeft, Garden gardenRight)
        {
            return gardenLeft._fencesLength <= gardenRight._fencesLength;
        }

        public static bool operator >=(Garden gardenLeft, Garden gardenRight)
        {
            return !(gardenLeft <= gardenRight);
        }
    }
}
