using System;
using System.Collections;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            FlavorComparer compareFlavors = new FlavorComparer();
            availableFlavors.Sort(compareFlavors);
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor);
            }

            ConeComparer compareCones = new ConeComparer();
            availableCones.Sort(compareCones);
            foreach (Cone c in availableCones)
            {
                Console.WriteLine(c);
            }

            
        }
        // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
        //  field.
        public class FlavorComparer : IComparer<Flavor>
        {
            public FlavorComparer()
            {

            }
            public int Compare(Flavor x, Flavor y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }

        // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
        //  field.
         public class ConeComparer : IComparer<Cone>
        {
            public ConeComparer()
            {
            }

            public int Compare(Cone x, Cone y)
            {
                double diff = x.Cost - y.Cost;
                if (diff == 0)
                {
                    return 0;
                }
                else if (diff < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
           
        }
        }
        // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
    }


