#include<stdio.h>
//4344�� ����� �Ѱ���

main()
{
	int c = 0;//�׽�Ʈ ���̽� ��
	int n = 0;//�л� ��
	int scr[1000];//����
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