public class Circle : Shape{

    private double _radius;

    public Circle(double radius, string color){
        _color = color;
        _radius = radius;
    }

    public override double GetArea(){
        return 2;
    }

}