using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Hanoi
    {
        public void moveDisk(int n, char source, char auxilary, char destination)
        {
            // base case to exit recursive loop.
            if (n == 1)
            {
                // since we only have to move one disk (n = 1), we don't want to make another
                // recursive call. we just wnat to output the move that we are performing.
                Console.WriteLine("Move disk from tower {0} to tower {1}.", source, destination);
            }

            else
            {
                //NOTE: the descriptions of source, axulary, and destination are referring to 
                // the first time this moveDisk method is called. As recursion works, it may 
                // not make sense to associate the work source with a peg letter. 

                // attempt to move (n-1) disks from source location (A) to auxilary location (B), using
                // the destination (C) as temprary storage. 
                moveDisk(n - 1, source, destination, auxilary);

                // move the source disk (A) to the destination (C)
                moveDisk(1, source, auxilary, destination);

                // move the (n-1) disks from auxilary (B) to destination (C) using the beginning (A)
                // as temporary storage.
                moveDisk(n - 1, auxilary, source, destination);
            }
        }
    }
}
