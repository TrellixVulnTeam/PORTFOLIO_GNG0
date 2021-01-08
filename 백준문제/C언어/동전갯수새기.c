#include<stdio.h>

main()
{
	int n = 0;
	scanf_s("%d", &n);
	int coin[4] = { 500,100,50,10 };
	int cnt = 0;
	for (int i = 0; i < 4; i++)
	{
		cnt += n / coin[i];
		n %= coin[i];
	}
	printf("%d",cnt);
}