#include <stdio.h>
//2581번 소수

main()
{
	int M, N;//M이상,N이하 자연수 0<M<N<10000
	int sum = 0;
	int min = 0;
	int cntmin = 0;
	scanf_s("%d\n%d", &M, &N);
	for (int i = M; i <= N; i++)
	{
		int cnt = 0;
		for (int j = 1; j <= i; j++)
			if (i % j == 0)
				cnt++;
		if (cnt == 2)
		{
			sum += i;
			cntmin++;
			if (cntmin == 1)
				min = i;
		}
	}
	if (sum == 0)
		printf("-1");
	else
		printf("%d\n%d", sum, min);
	return 0;
}
