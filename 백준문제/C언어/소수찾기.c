#include<stdio.h>

//1978�� �Ҽ�ã��

main()
{
	int N = 0;//�׽�Ʈ ����
	scanf_s("%d", &N);
	int n = 0;//1000������ �ڿ���
	int result = 0;
	for (int i = 0; i < N; i++)
	{
		int cnt = 0;
		scanf_s("%d", &n);
		for (int j = 1; j <= n; j++)
		{
			if (n % j == 0)
				cnt++;
		}
	if (cnt == 2)
			result++;
	}
	printf("%d", result);
	return 0;
}