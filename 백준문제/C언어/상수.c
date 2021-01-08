#include<stdio.h>
//2908¹ø »ó¼ö

main()
{
	char n1[4],n2[4];
	int num1[3], num2[3];
	int r1, r2;
	int cnt = 0;
	scanf_s("%s", n1, sizeof(n1) / 1);
	scanf_s("%s", n2, sizeof(n2) / 1);
	
	for (int i = 2; i >= 0; i--)
	{
		num1[i] = n1[cnt] - '0';
		num2[i] = n2[cnt] - '0';
		cnt++;
	}
	r1 = num1[0] * 100 + num1[1] * 10 + num1[2];
	r2 = num2[0] * 100 + num2[1] * 10 + num2[2];
	printf("%d", r1 > r2 ? r1 : r2);
	return 0;
}