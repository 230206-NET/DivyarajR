using System;
					
public class Program
{
	public sealed class Student
	{
		// The lock
		private static readonly object SingleInstanceLock = new object();
			
		// Stores the single instance if this class.
		private static Student? oStudent;
		
		// Returns the single instance of this class.
		public static Student GetInstance()
		{
			lock(SingleInstanceLock)
			{
				if(oStudent == null)
				{
					oStudent = new Student();
				}
			
				return oStudent;
			}
		}
		
		// Constructor declared private. 
		private Student()
		{
			//Initialization here
		}
		
		public void DisplayStudentInfo()
		{
			Console.WriteLine("Display Student info here.");
		}
		
		public void DisplayStudentName(string name)
		{
			Console.WriteLine(String.Format("Student name is {0}", name));
		}
	}
	
	public static void Main()
	{
		// Create and get the single instance of class Student.
		Student oStudent1 = Student.GetInstance();
		oStudent1.DisplayStudentInfo();
		oStudent1.DisplayStudentName("John");
		
		// Get the single instance of class Student
		Student oStudent2 = Student.GetInstance();
		oStudent2.DisplayStudentName("Jake");		
	}
}