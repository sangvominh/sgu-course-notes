public class Main {
  public static void main(String[] args) {
    Shape[] shapes = new Shape[5];
    shapes[0] = new Circle(Math.random() * 10);
    shapes[1] = new Rectangle(Math.random() * 10, Math.random() * 10);
    shapes[2] = new Square(Math.random() * 10);
    shapes[3] = new Circle(Math.random() * 10);
    shapes[4] = new Rectangle(Math.random() * 10, Math.random() * 10);

    double SumPerimeter = 0;
    for (Shape shape : shapes) {
      SumPerimeter += shape.getPerimeter();
    }
    System.out.println("Sum of perimeters: " + SumPerimeter);
  }
}
