#include<stdio.h>
//4344번 평균은 넘겠지

main()
{
	int c = 0;//테스트 케이스 수
	int n = 0;//학생 수
	int scr[1000];//점수
	double sum,avg,ratio;
	scanf_s("%d",&c);
	for (int i = 0; i < c; i++)
	{
		scanf_s("%d", &n);
		sum = 0.0;
		avg = 0.0;
		for (int j = 0; j < n; j++)
		{
			scanf_s("%d", &scr[j]);
			sum += scr[j];
		}
		avg = sum / n;
		int cnt = 0;
		for (int k = 0; k < n; k++)
		{
			if (scr[k] > avg)
			{
				cnt++;
			}
		}
		ratio = (cnt * 100.0) / n;
		printf("%.3f%%\n", ratio);
	}
	return 0;
}