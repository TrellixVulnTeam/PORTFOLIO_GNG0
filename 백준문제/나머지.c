#include<stdio.h>
//3052�� ������

main()
{
	int num = 0, cnt = 0;
	int arr[42] = { 0, };
	for (int i = 0; i < 10; i++)//10���� ���� �Է�.
	{
		scanf_s("%d", &num,sizeof(num)/4);
		arr[num % 42]++;
	}
	for (int i = 0; i < 42; i++)
	{
		if (arr[i] >= 1)
			cnt++;
	}
	printf("%d", cnt);
	
	return 0;
}
