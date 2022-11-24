// Принимаем число N 
// Выдаем число в промежутке от -N до N

int N;
N = Convert.ToInt32(Console.ReadLine());

int mN;
mN = -N;
int num = 0;
int count = 0;

for(int i = 0; i <= N * 2; i++)
{
    num = mN + count;
    Console.WriteLine(num);
    count = count + 1;
}

// ЗАВЕРШЕНО
// ПРИШЛОСЬ ПОПАРИТЬСЯ



