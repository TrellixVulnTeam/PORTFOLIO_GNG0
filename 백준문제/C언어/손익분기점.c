#include<stdio.h>
//1712번 손익분기점

main()
{
	unsigned int A = 0;//고정비용
	unsigned int B = 0;//가변비용 인건비,재료비
	unsigned int C = 0;//판매비용 한대생산해서 파는비용
	scanf_s("%d", &A);
	scanf_s("%d", &B);
	scanf_s("%d", &C);
	if (C > B)
		printf("%d", (A / (C - B)) + 1);
	else
		printf("%d", -1);
	return 0;
}