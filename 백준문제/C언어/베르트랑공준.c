#include<stdio.h>
//4948번 베르트랑 공준

main()
{
	int n = 0;//n ≤ 123456
	int a[246913];
	a[0] = 0;
	a[1] = 0;
	for (int i = 2; i <= 246912; i++)
		a[i] = i;
	for (int i = 2; i <= 246912; i++)
	{
		if (a[i] == 0)
			continue;
		for (int j = 2; i * j <= 246912; j++)
		{
			if (i * j <= 246912)
			{
				a[i * j] = 0;
			}
		}
	}
	while (1)
	{
		int cnt = 0;
		scanf_s("%d", &n);
		if (n == 0)
			break;
		for (int i = n+1; i <= n * 2; i++)
		{
			if (a[i] != 0)
				cnt++;
		}
		printf("%d\n", cnt);
	}
	return 0;
}

