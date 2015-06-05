using System;

namespace SnakeGame
{
	/// <summary>
	/// Summary description for Queue.
	/// </summary>
	public class Queue
	{
		private	int size;
		private int top;
		private int bottom;
		private int elementsAdded;
		private Direction[] arayptr;
					
		public Queue()
		{
			InitializeDataFields(10);
		}

		public Queue(int max)
		{
			InitializeDataFields(max);
		}

		private void InitializeDataFields(int max)
		{
			size = max;
			top = bottom = -1;
			elementsAdded = 0;
			arayptr = new Direction[size];																
		}

		public bool IsFull()
		{
			if(elementsAdded == size)
				return true;

			return false;
		}

		public bool IsEmpty()
		{
			if(elementsAdded == 0)
				return true;
			else
				return false;
		}

		public bool Push(Direction pushvalue)
		{
			if(!IsFull())
			{
				bottom = (++bottom)%(size);
				arayptr[bottom]=pushvalue;
				elementsAdded++;
			}
			else
				return false;
			
			return true;
		}
		
		public Direction Pop()
		{
			if(IsEmpty())
				return Direction.unassigned;

			top = (++top)%(size);
			Direction popvalue = arayptr[top];
			elementsAdded--;
			return popvalue;
		}

		//without popping anything, returns the bottommost element
		internal Direction GetBottomElement()
		{
			if(IsEmpty())
				return Direction.unassigned;

			return arayptr[bottom];
		}

		//without popping anything, returns the bottommost element
		internal Direction GetTopElement()
		{
			if(IsEmpty())
				return Direction.unassigned;

			return arayptr[bottom];
		}	

		public void Clear()
		{
			while(IsEmpty() != true)
				Pop();
		}
	}
}
