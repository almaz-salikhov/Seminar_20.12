int Fibonachi(int n)
{
    if (n == 0 || n == 1)
        return n;
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}
