using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1
             * value types are stored on the stack,
             * reference types on the heap.
             * The stack frame only exists during the execution time of a function
             * Only objects of fixed size known at compile time can be allocated on the stack
             * the heap as extra storage completely independent of the run-time
             * stack.It’s memory with no particular layout
             * 
             * 2
             * Value types can be allocated on the heap or on the stack,
             * depending on where they were declared.
             * Reference types are always allocated on the heap.
             * 
             * 3
             * y=X that means the vlaue of x(3) put it on y
             * it is passed as a vlaue 
             * Myint y= Myint x that meaning y and x refer to the same memory
             * and when y.MyValue is changed to 4 and x.MyValue refers to same memory so--- answer is 4
             */
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        Console.Clear();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
             * 
             * Answer:
             * Q2: list.count > list.Capacity start Encrease the capacity 4-8-12
             * Q3: 4-8-12
             * Q4:apacity is the number of the elements which the List can store 
             * before resizing of List needed
             * Q5:No stay same but you can decrease it manually 
             * Q6: when you need static Size of elements 
            */
            Console.Clear();
           
            Console.WriteLine("-------Add an Remove item from the list------- "
                    + "\n '+': Add the rest of the input to the list "
                    + "\nExapmle: user Enter +Adam then Adam would be added to the list"
                    + "\n '-': Remove the rest of the input from the list "
                    + "\nExample :user Enter -Adam then Adam would be removed from the list"
                    + "\nstart Enter first word with + in the begining of it :"
                    + "\n For exit Enter Quit without + or -");
            bool keepgoing = true;
            var customLists = new List<string>();
            string input="";
            
            while (keepgoing)
            {
                do
                {
                    input = Console.ReadLine();
                } while (string.IsNullOrEmpty(input));
                switch (input[0])
                {
                    case '+':
                        if (!string.IsNullOrEmpty(input.Trim('+')))
                        {
                            customLists.Add(input.Trim('+'));
                            Console.WriteLine($"list.Capacity() is :{customLists.Capacity}");
                            Console.WriteLine($"list.count() is :{customLists.Count}"
                                            + "\n print the list:");
                            customLists.ForEach(i => Console.WriteLine(i));
                            break;
                        }
                        //customLists.Capacity = customLists.Count;// normal working the important to keep Capacity > Count
                        //customLists.Capacity = 2; //that cerate Debug probelm when items more that 2
                        //Console.WriteLine($"customLists.Capacity = customLists.Count{customLists.Capacity}");
                        Console.WriteLine("Please Enter a name after +");
                        break;
                    case '-': //check if the lsit not Empty && the entered item is exist on list 
                        if(customLists.Remove($"{input.Trim('-')}")==true && customLists.Count !=0)
                        {
                            
                            Console.WriteLine($"list.Capacity() is :{customLists.Capacity}");
                            Console.WriteLine($"the size of your list is :{customLists.Count}"
                                         + "\n print the list:");
                            customLists.ForEach(i => Console.WriteLine(i));//print out the list 
                            
                        }else if (customLists.Count==0)
                        {
                            Console.WriteLine("your list is Empty now, to add item start with +");
                        }
                        else Console.WriteLine("Please Enter an item has existed on the List");
                        break;
                    
                    default: // Quit or wrong enterd word 
                        if (input[0] == 'Q'&& input == "Quit") { keepgoing = false; break; }
                        Console.WriteLine("Please add item starts with '+' or '-':");
                        break;
                }
            }
            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Console.WriteLine("this program simulates ICA Queue "
                              + "\nyou have pre initiat Queue with some names"
                              +"\nyou can Enqueue when add '+' before the name "
                              +"\n        Dequeue when Enter D"
                              +"\n        remove name from the Queue add '-' before name"
                              +"\nStart play with this Queue:");
            string input;
            bool keepgoing = true;

            var queuetest = new Queue<string>();
            var customLists = new List<string>();
            queuetest.Enqueue("CHarlis");
            queuetest.Enqueue("Greta");
            queuetest.Enqueue("Kalle");
            queuetest.Enqueue("Stina");
            queuetest.Enqueue("ahmad");
            queuetest.Enqueue("Olle");
            foreach (var item in queuetest)
            {
                Console.WriteLine(item);
            }
            while (keepgoing)
            {
                do
                {
                    input = Console.ReadLine();
                } while (string.IsNullOrEmpty(input));
                
                switch (input[0])
                {
                    case '+':
                        if (!string.IsNullOrEmpty(input.Trim('+')))
                        {
                            queuetest.Enqueue(input.Trim('+'));
                            Console.WriteLine("new Queue:");
                            queuetest.ToList().ForEach(i => Console.WriteLine(i));
                            break;
                        }

                        Console.WriteLine("Please Enter a name after +");
                        break;

                    case '-': //Creat list from queue 
                        customLists = queuetest.ToList();
                        //Remove Item form the queue
                        if (customLists.Remove($"{input.Trim('-')}") == true && customLists.Count != 0)
                        {

                            queuetest.Clear();
                            foreach (var item in customLists)
                            {
                                queuetest.Enqueue(item);
                            }
                            Console.WriteLine("updated Queue:");
                            queuetest.ToList().ForEach(i => Console.WriteLine(i));

                        }
                        else if (customLists.Count == 0)
                        {
                            Console.WriteLine("your Queue is Empty now, to add item start with +");
                        }
                        else Console.WriteLine("Please Enter an item has existed on the List");
                        break;
                    case 'D':

                        //Console.WriteLine(input.Trim('D'));
                        if (string.IsNullOrEmpty(input.Trim('D')))
                        {
                            queuetest.Dequeue();
                            Console.WriteLine("updated Queue:");
                            queuetest.ToList().ForEach(i => Console.WriteLine(i));
                            break;
                        }
                            Console.WriteLine("Please Enter a name starts with '+' ,'-' or write 'D' :");
                        break;
                    default: // Dequeue or wrong enterd word 
                        if (input[0] == 'Q' && input == "Quit") { keepgoing = false; break; }
                        Console.WriteLine("Please Enter a name starts with '+' ,'-' or write 'D' :");
                        break;
                }
            }
            //foreach (var item in queuetest)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine("-----------");
            //Console.WriteLine("-----------");
            //queuetest.ToList().ForEach(i => Console.WriteLine(i));
            //Console.WriteLine("-----------");
            //List<string> test = queuetest.ToList();
            //test.Remove("ahmad");
            //test.ForEach(i => Console.WriteLine(i));


            //queuetest.Clear();
            //foreach (var item in test)
            //{
            //    queuetest.Enqueue(item);
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine("-----------");
            //queuetest.ToList().ForEach(i => Console.WriteLine(i));
            
            //Console.ReadLine();
            
        }

                        /// <summary>
                        /// Examines the datastructure Stack
                        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }





    }
    
}
