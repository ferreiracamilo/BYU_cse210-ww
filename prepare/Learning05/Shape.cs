public abstract class Shape{
    protected string _color;

    protected string GetColor(){
        return _color;
    }

    protected void SetColor(string color){
        _color = color;
    }

    public abstract double GetArea();
}