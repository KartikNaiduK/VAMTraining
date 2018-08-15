/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Linq;
class HelloWorld {
  static void Main() {
      //sumLargest3();
      //duplicates_in_array();
      //swap_string();
      //word_count();
      //substring_in_array();
      //remove_punctuation_string();
      //check_binary_101();
      //missing_num_one_to_n();
      //move_zeroes_to_end();
      //small_large_array();
  }
  
  static void sumLargest3()
  {
      int len, sum_3=0;
      Console.WriteLine("Enter Array Length : ");
      len = int.Parse(Console.ReadLine());
      int[] arr = new int[len];
      Console.WriteLine("Enter Array Elements : ");
      for(int i=0;i<arr.Length;i++)
      {
          arr[i] = int.Parse(Console.ReadLine());
      }
      Array.Sort(arr);
      sum_3 = arr[len-1] + arr[len-2] + arr[len-3];
      Console.WriteLine("Sum of largest 3 numbers = "+ sum_3);
  }
  
  static void duplicates_in_array()
  {
      int len, check_var;
      Console.WriteLine("Enter Array Length : ");
      len = int.Parse(Console.ReadLine());
      int[] arr = new int[len];
      int[] dup = new int[100];
      Console.WriteLine("Enter Array Elements : ");
      for(int i=0;i<arr.Length;i++)
      {
          arr[i] = int.Parse(Console.ReadLine());
      }
      Array.Sort(arr);
      check_var = arr[0];
      for(int i=0;i<len;i++)
      {
          if(arr[i] == check_var)
          {
              dup[arr[i]]++;
          }
          else
          check_var=arr[i];
      }
      for(int i=0;i<100;i++)
      {
          if(dup[i]>0)
          Console.Write(i+" ");
      }
      
  }
  
  static void swap_string()
  {
      String first_string, second_string;
      int first_len, second_len;
      Console.WriteLine("Enter first string : ");
      first_string = Console.ReadLine();
      first_len = first_string.Length;
      Console.WriteLine("Enter second string : ");
      second_string = Console.ReadLine();
      second_len = second_string.Length;
      Console.WriteLine("First : "+first_string+" Second : "+second_string);
      first_string = first_string + second_string;
      second_string = first_string.Substring(0,first_len-second_len);
      first_string = first_string.Substring(second_len);
      Console.WriteLine("Swapped\nFirst : "+first_string+" Second : "+second_string);
  }
  
  static void word_count()
  {
      String str;
      int space_count=0;
      Console.WriteLine("Enter string : ");
      str = Console.ReadLine();
      for(int i=0;i<str.Length;i++)
      {
          if(str[i]==' ')
          space_count++;
      }
      Console.WriteLine("Number of words in string = "+(space_count+1));
  }
  
  static void substring_in_array()
  {
      String main_string, sub_string;
      Console.WriteLine("Enter main string : ");
      main_string = Console.ReadLine();
      Console.WriteLine("Enter substring : ");
      sub_string = Console.ReadLine();
      if(main_string.Contains(sub_string))
      Console.WriteLine("Substring is present in the main string");
      else      
      Console.WriteLine("Substring not is present in the main string");
  }
  
  static void remove_punctuation_string()
  {
      String main_string;
      Console.WriteLine("Enter string : ");
      main_string = Console.ReadLine();
      for(int i=0;i<main_string.Length;i++)
      {
          if(main_string[i]=='.' || main_string[i]==',' || main_string[i]=='\'' || main_string[i]=='\"' || main_string[i]=='!' || main_string[i]=='?')
          main_string = main_string.Replace(main_string[i], '\0');
      }
      Console.WriteLine("String without puntuations : "+main_string);
  }
  
  static void check_binary_101()
  {
      String binary_string;
      Console.WriteLine("Enter binary string : ");
      binary_string = Console.ReadLine();
      if(binary_string.Contains("101"))
      Console.WriteLine("Binary String contains 101");
      else
      Console.WriteLine("Binary String does not contain 101");
  }
  
  static void missing_num_one_to_n()
  {
      int n, sum;
      Console.WriteLine("Enter number of elements(n) : ");
      n = int.Parse(Console.ReadLine());
      sum = n*(n+1)/2;
      int[] one_to_n = new int[n];
      for(int i=0;i<n-1;i++)
      {
        one_to_n[i] = int.Parse(Console.ReadLine());
      }
      for(int i=0;i<n-1;i++)
      {
         sum -= one_to_n[i];
      }
      Console.WriteLine(sum);
  }
  
  static void move_zeroes_to_end()
  {
      string binary_str;
      int last;
      char temp;
      Console.WriteLine("Enter binary string : ");
      binary_str=Console.ReadLine();
      last = binary_str.Length-1;
      char[] str_array = binary_str.ToCharArray();
      for(int i=0;i<binary_str.Length;i++)
      {
          if(binary_str[i]=='0')
          {
              temp=str_array[i];
              str_array[i]=str_array[last];
              str_array[last]=temp;
              last--;
          }
      }
      Console.WriteLine(str_array);
  }
  
  static void small_large_array()
  {
      int n, last;
      Console.WriteLine("Enter number of elements(n) : ");
      n = int.Parse(Console.ReadLine());
      int[] elements = new int[n];
      for(int i=0;i<n;i++)
      {
        elements[i] = int.Parse(Console.ReadLine());
      }
      Array.Sort(elements);
      last = n-1;
      for(int i=0;i<n/2;i++)
      {
          Console.Write(elements[i]+","+elements[last]+" ");
          last--;
      }
  }
  
}

