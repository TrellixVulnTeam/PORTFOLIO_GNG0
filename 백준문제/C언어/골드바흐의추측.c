#include<stdio.h>
//9020�� �������� ����
int main(void)
{
	int n = 0;//¦��n, 4 �� n �� 10,000
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
	}//�Ҽ��Ǻ��ϴ� ��

	for (int i = 0; i < t; i++)
	{//Ƚ�� t
		scanf_s("%d", &n);
		for (int j = n/2; j >= 2; j--)
		{
			if (a[j] == 0)
				continue;//j�� �Ҽ� �϶��� �˻�
			if (a[n - j] != 0)
			{//j,n-j�� �Ҽ��̸� ����.
				printf("%d %d\n", j, n - j);
				break;
			}
		}
	}
	return 0;
}