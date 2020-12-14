#include<stdio.h>
//1157번 단어공부
void convert(char* input)
{
	for (int i = 0; input[i] != '\0'; i++)
	{
		if ('a' <= input[i] && input[i] <= 'z')
			input[i] -= 32;//소문자-32 = 대문자
	}
}
void Sort(int* alphabet,int n)
{
	int temp = 0;
	
	for (int i = 0; i < n; i++) {
		for (int j = i; j < n-1; j++) {
			if (alphabet[i] < alphabet[j + 1]) {
				temp = alphabet[i];
				alphabet[i] = alphabet[j + 1];
				alphabet[j + 1] = temp;
			}
		}
	}
}
main()
{
	char input[1000000];
	int alphabet[26] = { 0, };
	int alphabet2[26] = { 0, };
	scanf_s("%s", input,sizeof(input)/1);
	convert(input);
	for (int i = 0; input[i] != '\0'; i++)
	{
		alphabet[input[i] - 65]++;//A=65
	}
	for (int i = 0; i < 26; i++)
	{
		alphabet2[i] = alphabet[i];
	}
	Sort(alphabet,26);
	int max1 = alphabet[0];
	int max2 = alphabet[1];
	if (max1 == max2)
	{
		printf("?");
	}
	else if (max1 > max2)
	{
		for (int i = 0; i < 26; i++)
			if (alphabet2[i] == max1)
				printf("%c", i + 'A');
	}
	return 0;
}