#include<stdio.h>
//4637¹ø ¼¿ÇÁ ³Ñ¹ö

void Self(int* num)
{
	int n1, n10, n100, n1000, n10000,result = 0;
	for (int i = 0; i <= 10000; i++)
	{
		n10000 = i % 10000;
		if (i < 10)
			n1 = i;
		if (i < 100)
		{
			n10 = i / 10;
			n1 = i % 10;
		}
		if (i < 1000)
		{
			n100 = i / 100;
			n10 = (i / 10) % 10;
			n1 = i % 10;
		}
		if (i < 10000)
		{
			n1000 = i / 1000;
			n100 = (i / 100) % 10;
			n10 = (i / 10) % 10;
			n1 = i % 10;
		}
		result = n1 + n10 + n100 + n1000 + n10000;
		if (result >= 10000)
			continue;
		num[result]++;
	}
}
main()
{
	int num[10000] = { 0, };
	Self(num);
	for (int i = 0; i <= 10000; i++)
	{
		if (num[i] == 0)
			printf("%d\n", i);
	}
	return 0;
}