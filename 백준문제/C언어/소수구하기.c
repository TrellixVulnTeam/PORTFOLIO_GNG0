#include<stdio.h>
//1929�� �Ҽ����ϱ�
//1.�����佺�׳׽��� ü������� ���ϱ�.



//�� - �������� �Ҵ�޴� ������ �ö�
//���� - ���������� �ö�
//������ - ���������� �ö�
int number = 1000000;
int a[1000001];//���������� �����,100(1MB)���� ������ �����÷ο� �߻��Ѵ�.
int main()
{
	int M, N;//1 �� M �� N �� 1,000,000
	scanf_s("%d %d", &M, &N);
	for (int i = 2; i <= number; i++)
	{
		a[i] = i;
	}
	for (int i = 2; i <= number; i++)
	{
		if (a[i] == 0)
			continue;
		for (int j = 2; j * i <= number; j++)
		{
			if (i * j <= number)
				a[i * j] = 0;
			else
				break;
		}
	}
	for (int i = M; i <= N; i++)
	{
		if(a[i]!=0)
			printf("%d\n", a[i]);
	}
	return 0;
}

