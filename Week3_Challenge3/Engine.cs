namespace Week3_Challenge3;

public class Engine
{
    private int cylinders;
    private double horsepower;

    public int Cylinders
    {
        get { return cylinders; }
        set { cylinders = value; }
    }
    
    

    public double Horsepower
    {
            get {return horsepower; }
            set { horsepower = value; }
    }


    public Engine()
    {
        cylinders = 5;
        horsepower = 1000;
    }

    public Engine(int cylinders, double horsepower)
    {
        this.cylinders = cylinders;
        this.horsepower = horsepower;
        

    }
}