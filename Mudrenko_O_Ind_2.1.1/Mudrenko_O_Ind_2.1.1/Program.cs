﻿/*
 * Created by SharpDevelop.
 * User: Ксюха
 * Date: 19.04.2021
 * Time: 19:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Mudrenko_O_Ind_2_1_2
{
	class Program
	{
		private static int [] array = new int [] {4, 5, 3, 1, 2};
		private static int [] inArray () 
		{
			Console.WriteLine("Write array");
			
			return Array.ConvertAll (Console.ReadLine ().Split(), Convert.ToInt32);
		}
		public static int [] InsertionSort (int [] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				int current = array[i];
				int j = i;
				while (j > 0 && current > array [j - 1])
				{
					array[j] = array [j - 1];
					j--;
				}
				array [j] = current;
			}
			return array;
		}
		static void Main (string [] args)
		{
			foreach (var element in InsertionSort (inArray())) 
			{
				Console.Write (element + " ");
			}
			Console.ReadKey (true);
		}
	}
}