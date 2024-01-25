using Task2501;

Circle circle = new Circle() { Radius = 3 };
Circle circle1=new Circle() { Radius = 2 };
Rectangle rectangle = new Rectangle() { Height = 2, Width = 2 };
ShapeManager shapeManager = new ShapeManager();
shapeManager.AddShape(circle);
shapeManager.AddShape(circle);
shapeManager.AddShape(circle1);
shapeManager.AddShape(circle1);
shapeManager.AddShape(rectangle);
shapeManager.AddShape(rectangle);


Console.WriteLine($"Circle Count : {shapeManager.GetCircleCount()}");
Console.WriteLine($"Rectangle Count : {shapeManager.GetSquareCount()}");
Console.WriteLine($"Circles total Area: {shapeManager.GetTotalCircleAreas()}");
Console.WriteLine("Circles:");
Circle[] circles = shapeManager.GetCircles();
for (int i = 0; i < circles.Length; i++)
{
    Console.WriteLine($"Radius: {circles[i].Radius}, Area: {circles[i].CalculateArea()}");
}

