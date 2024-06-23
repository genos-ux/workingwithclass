using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Program
{
    class WorkingWithLists
    {
        public static void Main(string[] args)
        {
            //QUESTION II
            // Read- Only Collections , attempt to add another element to a read-only collection
            List<string> colors = new List<string>{"red","green","blue"};

            ReadOnlyCollection<string> readOnlyColor = new ReadOnlyCollection<string>(colors);

            //Tried adding elements to the readonly collection but caught an exception
            // readOnlyColor.Add("grey");
            // readOnlyColor.Add("black");

            //QUESTION II
            //Create a list collection and use list capacity

            List<int> numbers = new List<int>{};
            numbers.Capacity = 100;
            numbers.Add(3);numbers.Add(4);numbers.Add(11);
            numbers.Add(5);numbers.Add(6);numbers.Add(12);
            numbers.Add(7);numbers.Add(8);
            numbers.Add(9);numbers.Add(10);

            Console.WriteLine($"Capacity: {numbers.Capacity}");
            Console.WriteLine($"Count: {numbers.Count}");

            //QUESTION III
            //Create a list collection and provide the maximum value

            List<int> integers = new List<int>{};

            int count = 1;

            int max = 0;

            while(count <= 10)
            {
                Random random = new Random();
                integers.Add(random.Next(0, 100));
                count++;
            }

            Console.Write("The integers in the list are: ");
            for(int i = 0; i < integers.Count; i++)
            {
                Console.Write(integers[i] + " ");
                if(max < integers[i])
                {
                    max = integers[i];
                }

            }
            Console.WriteLine();
            Console.WriteLine($"The maximum value of the list is {max}");

            // QUESTION IV
            //
            int[] firstArray = new int[]{1,2,3};
            int[] secondArray = new int[]{4,5,6};

            List<int> mergedArray = firstArray.ToList().Concat(secondArray.ToList()).ToList();

            foreach(int number in mergedArray)
                Console.Write(number + " ");

            //QUESTION V

            List<Book> books = new List<Book>();


            Book book1 = new Book("Fire and Ice","Veronica Ans");
            Book book2 = new Book("Game Of Thrones","Gabriel Shakes");
            Book book3 = new Book("The Last Airbender","Wang Tu");

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            foreach(var book in books)
            {
                Console.WriteLine(book.Title + " " + book.Author);
            }

            //QUESTION VI
            int[] integerArray = new int[]{3,1,4,1,5,9,2,6,5,3,5};
            Array.Sort(integerArray);
            Array.Reverse(integerArray);

            foreach(int number in integerArray)
                Console.Write(number + " ");

            //QUESTION VII
            int[] numberArrays = new int[]{10,20,30,40,50};
            Console.WriteLine("The length of the array is " + numberArrays.Length);
            numberArrays[2] = 35;

            foreach(int number in numberArrays)
                Console.Write(number + " ");

            //QUESTION VIII
            List<string> fruits = new List<string>{"apple","banana","cherry"};
            fruits.Add("date");
            fruits.Remove("banana");
            Console.WriteLine("Fruits list contains cherry: "+fruits.Contain("cherry"));

            foreach(var fruit in fruits)
                Console.Write(fruit + " ");



        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title , string author)
        {
            Title = title;
            Author = author;
        }
    }

}
