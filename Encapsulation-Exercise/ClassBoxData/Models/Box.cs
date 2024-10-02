using System;
using System.Text;

namespace ClassBoxData
{
	public class Box 
	{
		private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length;
			private set // or use (init) only in inicialization can be set the value ! 
			{
				if (value <= 0)
				{
					throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");

                    // is that (nameof) work right ?
				}
				length = value;
			}
		}
        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                height = value;
            }
        }

        public double SurfaceArea() => 2 * length * width + LateralSurfaceArea();
        public double LateralSurfaceArea() => 2 * length * height + 2 * width * height;
        public double Volume() => length * width * height;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {Volume():f2}");
            return sb.ToString().TrimEnd();
        }

    }
}

