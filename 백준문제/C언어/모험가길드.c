#include<stdio.h>

//���谡�� �������� �־�����
//�׷��� �����ϱ����� �������� X�� ���谡�� �ݵ�� X���̻� ����
//�׷���� �ִ�
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
