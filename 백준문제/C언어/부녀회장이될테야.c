#include<stdio.h>
//2775�� �γ�ȸ���� ���׾�

main()
{
	int testCase = 0;
	int k = 0, n = 0;
	int apt[15][15] = { 0, };
	for (int i = 1; i <= 14; i++)
	{
		apt[0][i] = i;
	}
	for (int i = 1; i <= 14; i++)
	{//��
		for (int j = 1; j <= 14; j++)
		{//ȣ
			for (int m = 1; m <= j; m++)
			{
				apt[i][j] += apt[i - 1][m];

			}
			//printf("%d\t", apt[i][j]);
		}
		//printf("\n");
	}
	scanf_s("%d", &testCase);
	for (int a = 0; a < testCase; a++)
	{
		scanf_s("%d %d", &k, &n);
		printf("%d\n", apt[k][n]);
	}
	return 0;
}