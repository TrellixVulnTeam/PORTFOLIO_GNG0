#include<stdio.h>
//1712�� ���ͺб���

main()
{
	unsigned int A = 0;//�������
	unsigned int B = 0;//������� �ΰǺ�,����
	unsigned int C = 0;//�Ǹź�� �Ѵ�����ؼ� �Ĵº��
	scanf_s("%d", &A);
	scanf_s("%d", &B);
	scanf_s("%d", &C);
	if (C > B)
		printf("%d", (A / (C - B)) + 1);
	else
		printf("%d", -1);
	return 0;
}