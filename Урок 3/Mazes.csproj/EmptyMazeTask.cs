namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			if (width == 3)
				MoveDown(robot, height);
			else if (height == 3)
				MoveRight(robot, width);
			else
            {
				MoveDown(robot, height);
				MoveRight(robot, width);
			}
		}

		public static void MoveDown(Robot robot, int height)
        {
			for (int i = 0; i < height - 3; i++)
				robot.MoveTo(Direction.Down);
		}

		public static void MoveRight(Robot robot, int width)
		{
			for (int i = 0; i < width - 3; i++)
				robot.MoveTo(Direction.Right);
		}

	}
}