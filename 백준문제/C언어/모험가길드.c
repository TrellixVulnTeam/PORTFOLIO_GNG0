#include<stdio.h>

//모험가의 공포도가 주어진다
//그룹을 구성하기위해 공포도가 X인 모험가는 반드시 X명이상 구성
//그룹수의 최댓값
void bubble_sort(int* arr, int n)
{
	int temp = 0;
	for(int i = 0;i< n;i++)
		for(int j=0;j<n-1;j++)
			if (arr[j] <= arr[j + 1])
			{
				temp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = temp;
			}
}

int main(void)
{
	int n;
	scanf_s("%d", &n);
	int arr[100000];
	int count = 0, result = 0;
	int temp;
	for (int i = 0; i < n; i++)
	{
		temp = scanf_s("%d", &temp);
		arr[i] = temp;
		printf("%d",temp);
	}
	bubble_sort(arr, n);
	/*for (int i = 0; i < 5; i++)
	{
		printf("%d", arr[i]);
	}*/
	for (int i = 0; i < n;i++)
	{
		count++;
		if (count >= arr[i])
		{
			result++;
			count = 0;
		}
	}
	printf("%d", result);
}
