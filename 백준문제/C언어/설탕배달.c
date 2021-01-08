#include<stdio.h>

main()
{
	int input = 0;
	scanf_s("%d", &input, sizeof(input) / 4);
	int data = input % 5;
	
	if (input == 0)
		printf("%d", input / 5);
	else
	{
		if (data%3 == 0)
			printf("%d", (input / 5) + (data / 3));
		else
		{
			if (input > 10)
			{
				int i = 1;
				while (1)
				{
					if ((data + i * 5) % 3 == 0)
					{
						printf("%d", (input / 5 - i) + (data + i * 5) / 3);
						break;
					}
					i++;
				}
			}
			else
			{
				if (input % 3 == 0)
					printf("%d", input / 3);
				else if ((input % 5) % 3 == 0)
					printf("2");
				else
					printf("%d", -1);
			}
		}
	}
	return 0;
}