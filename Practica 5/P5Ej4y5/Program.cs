class A
{
char c;
static string st;
void metodo1()
{
    st = "string";
    c = 'A';
}
static void metodo2()
{
    new A().c = 'a';
    st = "st2";
    new A().c = 'B';
    A.st = "otro string";
}
}