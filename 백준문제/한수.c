#include<stdio.h>

void Hansu(int n, int* num)
{
	int n1 = 0, n10 = 0, n100 = 0;
	int d1 = 0, d2 = 0;
	for (int i = 1; i <= n; i++)
	{
		if (i < 100)
			num[i]++;
		else if (100 <= i && i < 1000)
		{
			n100 = i / 100;
			n10 = (i / 10) % 10;
			n1 = i % 10;
			d1 = n100 - n10;
			d2 = n10 - n1;
			if (d1 == d2)
				num[i]++;
		}
		else if (i == 1000)
		{
			num[1000] == 0;
		}
	}
}
main()
{
	int n = 0;//입력받을 수 0~1000
	int num[1001] = { 0, };
	int count = 0;
	scanf_s("%d", &n, sizeof(n), sizeof(int));
	Hansu(n, num);
	for (int i = 1; i <= n; i++)
	{
		if (num[i] == 1)
		{
			count++;
		}
	}
	printf("%d", count);
	return 0;
}