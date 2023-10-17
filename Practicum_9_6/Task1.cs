class Test { 

Exception[] exceptions =
{
    new MyException(), new IOException(), new ArgumentException(), new ArgumentOutOfRangeException(), new ArithmeticException()
};

    void TestMethod() 
    { 
        try
        {
            Console.WriteLine("Практикум");
        }
        catch (MyException ex) { Console.WriteLine(ex.GetType); }

        catch (IOException ex) { Console.WriteLine(ex.GetType); }

        catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.GetType); }

        catch (ArgumentException ex) { Console.WriteLine(ex.GetType); }

        catch (ArithmeticException ex) { Console.WriteLine(ex.GetType); }
    }
}

class MyException : Exception { }
