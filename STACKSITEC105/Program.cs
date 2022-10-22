using System;
using System.Collections;
namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        // So this is to set stack with Push operation to add elements to the Stack.
        {
            Stack st = new Stack();
            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');
        // So the current stack is readable by "W" to "A", like this, (W, G, M, A) if you run it.
        // Because stack is readable by the end of the data to the top.
        // That's what we called LIFO, Last in-Frist Out.
    Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            st.Push('V');
            st.Push('H');

        // So here we use "push" to add collection in the data, so the "V" and "H" were added in the stack.
        // Then the first poppable value is "H" because the last element we put is H.
        // Then it is readable by "H, V, W, G, M, A" 

    Console.WriteLine("The next poppable value in stack: {0}",
            st.Peek());

            // In this line you can see that the letter "H" is being pop because we use Peek
            // to get the top data element of the stack, without removing it.

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
          
            //So here we use Pop to remove the element in the end of the data or collection.
            //So the output is G, M, A, because we uses pop and the last element to be add in the data
            //must be the one to be removed.
        Console.WriteLine("Removing values");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " " + " ");
            }
            Console.ReadKey(true);
        }
    }
}