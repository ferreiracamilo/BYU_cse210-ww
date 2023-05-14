public class Square : Shape{
    private double _side;

    public Square(double side, string color){
        _color = color;
        _side = side;
    }

    public override double GetArea(){
        return 2;
    }
}