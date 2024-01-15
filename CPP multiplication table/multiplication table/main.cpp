#include <iostream>

using namespace std;


int digits_counter(int num)
{
    int number = num;
    int i = 0;
    while (number >0)
    {
        number = number / 10;
        i++;
    }
    return i;
}

int main()
{
    for (int i =1; i<10;i++)
    {
        for (int j =1; j<10;j++)
        {
            int mul = i * j;
            if (digits_counter(mul)==2)
            {
                cout << " " << mul;}
            if (digits_counter(mul)==1){
                cout << "  " << mul;
            }
        }
        cout<<endl;
    }
    return 0;
}
