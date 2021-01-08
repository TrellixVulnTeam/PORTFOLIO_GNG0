#include<stdio.h>
//1929번 소수구하기
//1.에라토스테네스의 체방식으로 구하기.



//힙 - 동적으로 할당받는 변수가 올라감
//스택 - 지역변수가 올라감
//데이터 - 전역변수가 올라감
int number = 1000000;
int a[1000001];//지역변수로 선언시,100(1MB)만이 넘으면 오버플로우 발생한다.
int main()
{
	int M, N;//1 ≤ M ≤ N ≤ 1,000,000
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

