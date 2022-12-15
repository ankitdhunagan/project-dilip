class A
{
    public int x = 5;
    
}

// Single Inheritance
class B: A      //B inherits from A, B is of type A, A is parent of B
{
    public int y = 10;
}

// Multilevel inheritance
class C: B
{
    public int z = 15;
    int sum;
    sum = x + y + z;
    Console.WriteLine(sum);
    
}

// Multiple inheritance
interface ID
{

}

interface IF
{

}

class E: B, ID, IF
{

}
