#include<stdio.h>
//11720번 숫자의 합
main()
{
	int n = 0, result = 0;//숫자 n개 1~100개
	int num[100] = { 0, };
	char ch[100] = { '0' };
	scanf_s("%d", &n, sizeof(n) / 4);
	scanf_s("%s", ch, sizeof(ch) / 1);
	for (int i = 0; i < n; i++)
	{
		num[i] = ch[i] - 48; //-48하면됨
		result += num[i];
	}
	printf("%d", result);
	return 0;
}