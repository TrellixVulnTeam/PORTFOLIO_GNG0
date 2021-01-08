exam = []
while True:
    exam = list(map(int,input().split()))
    if exam[0] == 0:
        break
    Heru = exam.pop(exam.index(max(exam)))
    Ausar = exam.pop()
    Auset = exam.pop()
    if Heru ** 2 == (Ausar ** 2 )+(Auset **2):
        print("right")
    else:
        print("wrong")
