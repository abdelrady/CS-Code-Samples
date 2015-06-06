using System;

namespace Towers_of_Hanoi
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class TowerHanoi
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			// Read in the number of disks, numDisk, for this game.
			Console.Write("Enter number of disks: ");
			int numDisk = Int32.Parse(Console.ReadLine());

			// Find the solution in a recursive method.
			Console.WriteLine("The moves are: ");
			moveDisks(numDisk, 'A', 'B', 'C');
			Console.WriteLine(i.ToString()+"\nGame Over.");
		}
        static int i = 0;
		// The method for finding the solution to move n from fromTower to toTower with auxTower.
		public static void moveDisks(int n, char TowerA, char TowerB, char TowerC) {
			// Stopping Condition.
			if (n == 1)
            {
				Console.WriteLine("Move disk " + n + " from " + TowerA + " to " + TowerB);
                
			} 
            else 
            {
				moveDisks(n-1, TowerA, TowerC, TowerB);
				Console.WriteLine("Move disk " + n + " from " + TowerA + " to " + TowerB);
				moveDisks(n-1, TowerC, TowerB, TowerA);
			}
            i++;
		}
	}
}
