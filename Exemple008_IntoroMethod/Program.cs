int Max(int arg1, int arg2, int arg3)
{
     int result = arg1;
     if(arg2>result) result = arg2;
     if(arg3>result) result = arg3;
     return result;
}


int a1 = 13;
int b1 = 25;
int c1 = 4;
int a2= 137;
int b2 = 15;
int c2 = 34;
int a3 = 83;
int b3 = 12;
int c3 = 517;

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
     Max(a3, b3, c3));

Console.WriteLine(max);