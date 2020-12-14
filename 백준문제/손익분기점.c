#include<stdio.h>
//1712번 손익분기점

main()
{
	int i = 0;
	int A, B, C;
	scanf_s("%d %d %d", &A, &B, &C);
	while (1)
	{
		i++;
		if (C * i > A + (B * i)) { break; }
		

	}
}