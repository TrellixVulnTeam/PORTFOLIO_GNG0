#include<stdio.h>
//9020번 골드바흐의 추측
int main(void)
{
	int n = 0;//짝수n, 4 ≤ n ≤ 10,000
	int t;//testcase
	int a[10001];
	scanf_s("%d", &t);
	for (int i = 2; i <= 10000; i++)
		a[i] = i;
	for (int i = 2; i <= 10000; i++)
	{
		if (a[i] == 0)
			continue;
		for (int j = 2; j * i <= 10000; j++)
			if (j * i <= 10000)
				a[i * j] = 0;
	}//소수판별하는 곳

	for (int i = 0; i < t; i++)
	{//횟수 t
		scanf_s("%d", &n);
		for (int j = n/2; j >= 2; j--)
		{
			if (a[j] == 0)
				continue;//j가 소수 일때만 검사
			if (a[n - j] != 0)
			{//j,n-j가 소수이면 종료.
				printf("%d %d\n", j, n - j);
				break;
			}
		}
	}
	return 0;
}