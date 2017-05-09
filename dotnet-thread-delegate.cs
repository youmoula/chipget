private static void Method1()
{
    //Method1 implementation
}

private static void Method1(int Param1)
{
    //Method1 implementation
}

private static void Method1(int Param1, int Param2)
{
    //Method1 implementation
}

new Thread(delegate () {
    Method1(param1, param2);
}).Start();
