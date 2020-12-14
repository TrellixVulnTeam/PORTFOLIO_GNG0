#include<stdio.h>
//1546¹ø Æò±Õ
main()
{
	int N = 0;
	unsigned int score[1000] = { 0, };
	float sum = 0.0, max = 0.0;
	scanf_s("%d", &N, sizeof(N) / sizeof(int));
	for (int i = 0; i < N; i++)
	{
		scanf_s("%d", &score[i], sizeof(score[i]) / sizeof(unsigned int));
		if (max < score[i])
			max = score[i];
	}
	for (int i = 0; i < N; i++)
	{
		sum += score[i] / max * 100;
	}
	printf("%f", sum / N);
	return 0;
}

