namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
		    if (height == 5)
			{
				FullCycleOfGoingOneTime(robot, width, height);
			}
			else
				FullCycleOfGoingThrowLabirinth(robot, width, height);
		}
		public static void MoveDown(Robot robot, int height)
		{
			for (int i = 0; i < 2; i++)
				robot.MoveTo(Direction.Down);
		}

		public static void MoveRight(Robot robot, int width)
		{
			for (int i = 0; i < width - 3; i++)
				robot.MoveTo(Direction.Right);
		}

		public static void MoveLeft(Robot robot, int width)
		{
			for (int i = 0; i < width - 3; i++)
				robot.MoveTo(Direction.Left);
		}
		
		public static void FullCycleOfGoingOneTime(Robot robot, int width, int height)
        {
			MoveRight(robot, width);
			MoveDown(robot, height);
			MoveLeft(robot, width);
		}

		public static void FullCycleOfGoingThrowLabirinth(Robot robot, int width, int height)
        {
			for (int i = 0; i < (height - 1) / 4; i++)
			{
				if (!robot.Finished)
				{
					for (int j = 0; j < (height - 1) / 4; j++)
					{
						FullCycleOfGoingOneTime(robot, width, height);
						if (!robot.Finished)
							MoveDown(robot, height);
						else break;
					}
				}
				else break;
			}
		}
	}
}